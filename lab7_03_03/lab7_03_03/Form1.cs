using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7_03_03
{
    public partial class Lab7_03_03 : Form
    {
        public Lab7_03_03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int counter = 0;
            double sum = 0;
            double summand = 0.0;
            double x;
            bool f = false;
            if (double.TryParse(txtPrecision.Text, out x))
            {
                f = true;
            }
            do
            {
                counter++;
                if (double.TryParse(txtX.Text, out x))
                {
                    summand = double.Parse(txtX.Text) / counter;
                }
                sum += summand;
            }
            while (Math.Abs(summand) > double.Parse(txtPrecision.Text));
            if (f)
            {
                lblResult.Text = "Сумма =" + sum + ", количество =" + counter;
            }
            else
            {
                MessageBox.Show("Введите числовое значение!");
            }
            
        }

        private void lblResult_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
