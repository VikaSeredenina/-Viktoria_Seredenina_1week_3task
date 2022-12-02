using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadania_3_form_
{
    public partial class Задание_1 : Form
    {
        public Задание_1()
        {
            InitializeComponent();
        }
        static public double znach (int n, double x)
        {
            return Math.Pow(x, n) / n;
        }
       

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
                MessageBox.Show("Введите число");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);

            double z = znach(2, x) + znach(4, x) + znach(6, x);
            textBox2.Text="z=" + z;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Clear();
            textBox2.Text = "";
            textBox2.Clear();

        }
    }
}
