using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chart ayarları
            chart1.ChartAreas[0].AxisX.Title = "kullanıcılar";
            chart1.ChartAreas[0].AxisY.Title = "yaşlar";


            chart1.Series["UsersAge"].Points.AddXY("u1", 12);
            chart1.Series["UsersAge"].Points.AddXY("u2", 13);
            chart1.Series["UsersAge"].Points.AddXY("u3", 12);

            chart1.Series["UsersAge"].Points.AddXY("u4", 14);

            chart1.Series["UsersAge"].Points.AddXY("u5", 15);


            chart2.Series["Cars"].Points.AddXY("BMW", 25);
            chart2.Series["Cars"].Points.AddXY("Audi", 50);
            chart2.Series["Cars"].Points.AddXY("Mercedes", 15);
            chart2.Series["Cars"].Points.AddXY("Dacia", 10);
            chart2.Series["Cars"].Points.AddXY("opel", 20);








        }

        private void button2_Click(object sender, EventArgs e)
        {
            userPointChart.Series["final"].Points.AddXY("User2", 70);
            userPointChart.Series["final"].Points.AddXY("User1", 60);

            
            userPointChart.Series["final"].Points.AddXY("User3", 90);

            userPointChart.Series["midterm"].Points.AddXY("User1", 50);
            userPointChart.Series["midterm"].Points.AddXY("User2", 100);
           
        }
    }
}
