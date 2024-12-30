using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("kldsfjlad");
            }
            else
            {
                string item = textBox1.Text+" "+textBox2.Text;
                listBox1.Items.Add(item);
                textBox1.Clear(); 
                textBox2.Clear();

            }
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex >= 0)
            {
                string fullName = listBox1.SelectedItem.ToString();
                string[] item = fullName.Split(' ');

                textBox1.Text = item[0];
                textBox2.Text = item[1];

            }
            else
            {
                MessageBox.Show("You should select a item");
            }
           

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
           /* int index = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index); //index değerine göre çalışır*/
            listBox1.Items.Remove(listBox1.SelectedItem); //seçili item a göre çalışır
        }
    }
}
