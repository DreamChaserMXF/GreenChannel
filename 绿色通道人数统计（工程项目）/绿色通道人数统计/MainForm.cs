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
    public partial class MainForm : Form
    {

        public GraphForm barForm;
        public GraphForm BarForm()
        {
            if (barForm == null || barForm.IsDisposed)
            {
                barForm = new GraphForm();
            }
            return barForm;
        }


        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void SaveData()
        {
            StreamWriter swriter = new StreamWriter(new FileStream("data.dat", FileMode.Create, FileAccess.Write));
            swriter.WriteLine(numericUpDown1.Value);
            swriter.WriteLine(numericUpDown2.Value);
            swriter.WriteLine(numericUpDown3.Value);
            swriter.WriteLine(numericUpDown4.Value);
            swriter.WriteLine(numericUpDown5.Value);
            swriter.WriteLine(numericUpDown6.Value);
            swriter.WriteLine(numericUpDown7.Value);
            swriter.WriteLine(numericUpDown8.Value);
            swriter.WriteLine(numericUpDown9.Value);
            swriter.Flush();
            swriter.Close();
        }

        private void LoadData()
        {
            try
            {
                //FileStream file = new FileStream("data.bin", FileMode.Open);
                StreamReader sreader = new StreamReader(new FileStream("data.dat", FileMode.Open, FileAccess.Read));
                string savedVals = sreader.ReadToEnd();
                sreader.Close();

                string[] split = savedVals.Split(' ', '\n');
                numericUpDown1.Value = int.Parse(split[0]);
                numericUpDown2.Value = int.Parse(split[1]);
                numericUpDown3.Value = int.Parse(split[2]);
                numericUpDown4.Value = int.Parse(split[3]);
                numericUpDown5.Value = int.Parse(split[4]);
                numericUpDown6.Value = int.Parse(split[5]);
                numericUpDown7.Value = int.Parse(split[6]);
                numericUpDown8.Value = int.Parse(split[7]);
                numericUpDown9.Value = int.Parse(split[8]);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void GenerateBarGraph()
        {
            int[] barValue = new int[6];
            barValue[0] = Convert.ToInt32(numericUpDown1.Value);
            barValue[1] = Convert.ToInt32(numericUpDown2.Value);
            barValue[2] = Convert.ToInt32(numericUpDown3.Value);
            barValue[3] = Convert.ToInt32(numericUpDown4.Value);
            barValue[4] = Convert.ToInt32(numericUpDown5.Value);
            barValue[5] = Convert.ToInt32(numericUpDown6.Value);
            int[] ceilValue = new int[3];
            ceilValue[0] = Convert.ToInt32(numericUpDown7.Value);
            ceilValue[1] = Convert.ToInt32(numericUpDown8.Value);
            ceilValue[2] = Convert.ToInt32(numericUpDown9.Value);
            BarForm().GenerateBarGraph();
            BarForm().BindDataY(barValue, ceilValue);
        }

        private void ChangeCeilValues()
        {
            numericUpDown1.Maximum = numericUpDown7.Value;
            numericUpDown2.Maximum = numericUpDown8.Value;
            numericUpDown3.Maximum = numericUpDown9.Value;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ChangeCeilValues();
            GenerateBarGraph();
            SaveData();
        }

        private void buttonBarGraphGenerate_Click(object sender, EventArgs e)
        {
            BarForm().Visible = true;
            GenerateBarGraph();
        }

        private void buttonFullScreen_Click(object sender, EventArgs e)
        {
            if (BarForm().Visible)
            {
                BarForm().SetFullScreen(true);
            }
        }

        private void buttonQuitFullScreen_Click(object sender, EventArgs e)
        {
            if (BarForm().Visible)
            {
                BarForm().SetFullScreen(false);
            }
        }
    }
}
