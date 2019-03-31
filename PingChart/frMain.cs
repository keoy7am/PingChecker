using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PingChart
{
    public partial class frMain : Form
    {
        ThreadStart pingThreadStart;
        Thread pingThread;
        bool startPing = false;
        string target;
        List<PingResult> pingResults = new List<PingResult>();
        public class PingResult
        {
            public long PingTime { get; set; }
            public DateTime PingDateTime { get; set; }
        }
        public frMain()
        {
            InitializeComponent();
            pingThreadStart = new ThreadStart(PingLoop);
            pingThread = new Thread(pingThreadStart);
            pingThread.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Test();

            if (tbIp.Text.Trim().Length == 0)
            {
                MessageBox.Show("請輸入內容!");
                return;
            }
            string tmp = GetValidatedIPEx(tbIp.Text.Trim());
            if (tmp == "")
            {
                MessageBox.Show("請輸入合法的IP");
                return;
            }
            pingResults.Clear();
            target = tmp;
            startPing = true;
        }

        private void frMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //關閉線程
            pingThread.Abort();
        }
        #region Chart
        private void UpdatePingChart()
        {
            try
            {
                int yLen = pingResults.Count > 120 ? 120 : pingResults.Count; 
                this.Invoke(new Action(() =>
                {
                    // 清除資料
                    PingChart.Series.Clear();
                    PingChart.Legends.Clear();
                    PingChart.Titles.Clear();

                    // 設定 Legends------------------------------------------------------------------------  
                    PingChart.Legends.Add("legned"); // 圖例集合
                    PingChart.Legends["legned"].DockedToChartArea = "ChartArea1"; // 顯示在圖表內
                    PingChart.Legends["legned"].Docking = Docking.Top; // 自訂顯示位置
                    PingChart.Legends["legned"].BackColor = Color.FromArgb(235, 235, 235); // 背景色
                    PingChart.Legends["legned"].BackHatchStyle = ChartHatchStyle.DarkDownwardDiagonal;
                    PingChart.Legends["legned"].BorderWidth = 1;
                    PingChart.Legends["legned"].BorderColor = Color.FromArgb(200, 200, 200);
                    
                    // 設定 Series-----------------------------------------------------------------------
                    Series series = this.PingChart.Series.Add("series");
                    PingChart.Series["series"].ChartType = SeriesChartType.Column;
                    PingChart.Series["series"].Legend = "legned";
                    PingChart.Series["series"].LabelFormat = "#,###"; // 金錢格式
                    PingChart.Series["series"].BorderColor = Color.FromArgb(200, 200, 200);

                    PingChart.Series["series"].MarkerSize = 8; // Label 範圍大小
                    PingChart.Series["series"].LabelForeColor = Color.FromArgb(0, 90, 255); // 字體顏色
                                                                                            // 字體設定
                    PingChart.Series["series"].Font = new System.Drawing.Font("Trebuchet MS", 10, System.Drawing.FontStyle.Bold);

                    // Label 背景色
                    //PingChart.Series[d].LabelBackColor = Color.FromArgb(150, 255, 255, 255);
                    //PingChart.Series[d].Color = Color.FromArgb(240, 65, 140, 240); //背景色
                    PingChart.Series["series"].IsValueShownAsLabel = true; // Show data points labels

                    // 設定 Title
                    PingChart.Titles.Add($"即時Ping圖表 (數量:{yLen})");

                    // 設定 Areas------------------------------------------------------------------------  
                    // 設定Y軸
                    PingChart.ChartAreas[0].AxisY.Maximum = 
                    pingResults.OrderByDescending(x => x.PingDateTime).Take(yLen).Max(x => x.PingTime);
                                                               //PingChart.ChartAreas[0].AxisY.Maximum = 200;
                                                               // 設定X軸
                                                               //PingChart.ChartAreas[0].AxisX.Maximum = 2;
                    //PingChart.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = false; // 3D效果
                    //PingChart.ChartAreas["ChartArea1"].Area3DStyle.IsClustered = true; // 並排顯示
                    //PingChart.ChartAreas["ChartArea1"].Area3DStyle.Rotation = 40; // 垂直角度
                    //PingChart.ChartAreas["ChartArea1"].Area3DStyle.Inclination = 50; // 水平角度
                    //PingChart.ChartAreas["ChartArea1"].Area3DStyle.PointDepth = 20; // 數據條深度
                    //PingChart.ChartAreas["ChartArea1"].Area3DStyle.WallWidth = 0; // 外牆寬度
                    //PingChart.ChartAreas["ChartArea1"].Area3DStyle.LightStyle = LightStyle.Realistic; // 光源
                    PingChart.ChartAreas["ChartArea1"].BackColor = Color.FromArgb(240, 240, 240); // 背景色
                    PingChart.ChartAreas["ChartArea1"].AxisX2.Enabled = AxisEnabled.False; // 隱藏 X2 標示
                    PingChart.ChartAreas["ChartArea1"].AxisY2.Enabled = AxisEnabled.False; // 隱藏 Y2 標示
                    PingChart.ChartAreas["ChartArea1"].AxisY2.MajorGrid.Enabled = false;   // 隱藏 Y2 軸線
                    PingChart.ChartAreas["ChartArea1"].AxisX.Enabled = AxisEnabled.False; // 隱藏 X 軸
                                                                                          // Y 軸線顏色
                    PingChart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.FromArgb(150, 150, 150);
                    // X 軸線顏色
                    PingChart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.FromArgb(150, 150, 150);
                    PingChart.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "#,###";
                    //PingChart.ChartAreas["ChartArea1"].AxisY2.Maximum = 160;
                    //PingChart.ChartAreas["ChartArea1"].AxisY2.Interval = 20;

                    // 抓出最大最小值
                    UpdateStatus();

                    // 秀出前30 筆
                    foreach (var p in pingResults.OrderByDescending(x => x.PingDateTime).Take(yLen))
                    {
                        var dateTime = p.PingDateTime.ToLongTimeString();
                        var value = p.PingTime;

                        // Add Point
                        series.Points.Add(double.Parse(value.ToString()));
                    }
                    var lastP = pingResults.LastOrDefault();
                    PingChart.Series["series"].LegendText = lastP.PingDateTime.ToLongTimeString() + " Ping值:" + lastP.PingTime;
                }));
            }
            catch (Exception ex)
            {

            }
        }
        private void UpdateStatus()
        {
            try
            {
                lbMaxPing.Text = $"最高值：{pingResults.Max(x => x.PingTime)}";
                lbMinPing.Text = $"最低值：{pingResults.Min(x => x.PingTime)}";
                lbLoss.Text = $"丟失：{pingResults.Where(x=>x.PingTime == 0).Count()}";
                lbPingCount.Text = $"Ping總數：{pingResults.Count()}";
            }
            catch (Exception ex)
            {
                lbMaxPing.Text = $"最高值：例外狀況";
                lbMinPing.Text = $"最低值：例外狀況";
                lbLoss.Text = $"丟失：例外狀況";
                lbPingCount.Text = $"Ping總數：例外狀況";
            }
        }
        #endregion
        #region Ping

        private void Ping()
        {
            try
            {

                string message;
                Ping p = new Ping();
                var ip = tbIp.Text.Trim();
                PingReply r = p.Send(ip);
                long ping = 0;
                if (r.Status == IPStatus.Success)
                {
                    ping = r.RoundtripTime;
                    message = string.Format($"IP:{0} pint test ok！ PingTime:{ping}", ip);
                }
                else
                    message = string.Format("IP:{0} pint test failed！", ip);
                Console.WriteLine(message);
                pingResults.Add(new PingResult() { PingTime = ping, PingDateTime = DateTime.Now });
            }
            catch (Exception ex)
            {

            }
        }
        public void PingLoop()
        {
            while (true)
            {
                if (startPing)
                {
                    Ping();
                    UpdatePingChart();
                }
                else
                {

                }
                Thread.Sleep(1000);
            }
        }
        #endregion
        #region IP
        private string GetValidatedIPEx(string ipStr)
        {
            string validatedIP = string.Empty;
            //如果ip + Port的話，使用IPAddress.TryParse會無法解析成功
            //所以加入Uri來判斷看看
            Uri url;
            IPAddress ip;
            if (Uri.TryCreate(string.Format("http://{0}", ipStr), UriKind.Absolute, out url))
            {
                if (IPAddress.TryParse(url.Host, out ip))
                {
                    //合法的IP
                    validatedIP = ip.ToString();
                }
            }
            else
            {
                //可能是ipV6，所以用Uri.CheckHostName來處理
                var chkHostInfo = Uri.CheckHostName(ipStr);
                if (chkHostInfo == UriHostNameType.IPv6)
                {
                    //V6才進來處理
                    if (IPAddress.TryParse(ipStr, out ip))
                    {
                        validatedIP = ip.ToString();
                    }
                    else
                    {
                        //後面有Port Num，所以再進行處理
                        int colonPos = ipStr.LastIndexOf(":");
                        if (colonPos > 0)
                        {
                            string tempIp = ipStr.Substring(0, colonPos - 1);
                            if (IPAddress.TryParse(tempIp, out ip))
                            {
                                validatedIP = ip.ToString();
                            }
                        }
                    }
                }
            }
            return validatedIP;
        }
        #endregion
    }
}
