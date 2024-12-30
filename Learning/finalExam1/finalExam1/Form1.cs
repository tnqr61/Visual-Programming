using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace finalExam1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ayranBox.Text) && string.IsNullOrEmpty(sodaBox.Text) && string.IsNullOrEmpty(suBox.Text))
                MessageBox.Show("En az bir tane değer girmelisin");

            else
            {
                Series series = new Series("Produtcs");
                
                series.ChartType = SeriesChartType.Pie;

                series.Points.AddXY("Ayran", 5);
                series.Points.AddXY("su", 3);
                series.Points.AddXY("soda",4);

                chart1.Series.Add(series);
            }

        }
    }
}
