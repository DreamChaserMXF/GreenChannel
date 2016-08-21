using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 绿色通道人数统计
{
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();
        }

        // 设置是否全屏
        public void SetFullScreen(bool isFullScreen)
        {
            if (isFullScreen)
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
            }
        }

        // ESC快捷键退出全屏
        private void GraphForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                SetFullScreen(true);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                SetFullScreen(false);
            }
        }

        // 生成图例
        public void GenerateBarGraph()
        {

            string filePath = Application.StartupPath + "\\backimg.jpg";
            if (File.Exists(filePath))
            {
                chart1.BackImage = filePath;
            }
            else 
            {
                chart1.ChartAreas[0].BackColor = Color.DeepSkyBlue;
            }

            //chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            //chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            //chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            //chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
            //chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            //chart1.ChartAreas[0].Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            //chart1.ChartAreas[0].AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            
            //chart1.ChartAreas[0].BackColor = Color.AliceBlue;
            //chart1.ChartAreas[0].BackImage = "C:/Users/Administrator/Desktop/backimg.jpg";
            //chart1.ChartAreas[0].BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            //chart1.ChartAreas[0].BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            //chart1.Series[0].Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            //chart1.BackColor = Color.Green;
            //chart1.ChartAreas[0].BackColor = Color.GhostWhite;
            //chart1.ChartAreas[0].Area3DStyle.Rotation = 0;     // 绕z轴转
            //chart1.ChartAreas[0].Area3DStyle.Inclination = 0;  // 绕x轴转

        }

        // 绑定数据
        public void BindDataY(int[] yvals, int[] ceilVals)
        {
            string[] xvals = {"贫困专项预约",
                              "绿色通道预约",
                              "受灾地区学生",
                              "缓交学费",
                              "爱心大礼包",
                              "爱心小礼包"
                             };
            int max = yvals.Max();
            if (max > 300)
            {
                max = ((max - 1) / 100 + 1) * 100;
                chart1.ChartAreas[0].AxisY.Maximum = max;
            }
            else if (max <= 300)
            {
                chart1.ChartAreas[0].AxisY.Maximum = 300;
            }

            

            chart1.Series[0].Points.DataBindXY(xvals, yvals);
            chart1.Series[0].Points[0].Color = Color.Yellow;
            chart1.Series[0].Points[1].Color = Color.Lime;
            chart1.Series[0].Points[3].Color = Color.Chocolate;
            chart1.Series[0].Points[4].Color = Color.DeepPink;
            chart1.Series[0].Points[5].Color = Color.Fuchsia;

            chart1.Series[0].Points[0].Label = yvals[0].ToString() + " / " + ceilVals[0].ToString();
            chart1.Series[0].Points[1].Label = yvals[1].ToString() + " / " + ceilVals[1].ToString();
            chart1.Series[0].Points[2].Label = yvals[2].ToString() + " / " + ceilVals[2].ToString();

            //chart1.Series[0].Points[0].Label = yvals[0].ToString() + " / 150";
            //chart1.Series[0].Points[1].Label = yvals[1].ToString() + " / 93";
            //chart1.Series[0].Points[2].Label = yvals[2].ToString() + " / 50";
            //chart1.Series[0].Points[0].Label = "abc";
            System.Console.WriteLine(chart1.Series[0].Points[0].Label);
        }
    }
}
