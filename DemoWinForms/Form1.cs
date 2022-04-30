using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = 0;
            try
            {
                 x = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Вводите цифорки");
                return;
            }
            
            
            double z = 0;


            try
            {
                 z = Convert.ToDouble(comboBox1.SelectedItem.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Будет возведено в степень 2!");
                z = 2;
            }

            double result = Math.Pow(x, z);
            textBox2.Text = result.ToString();
        }
    }
}
