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
    public partial class Задание_2 : Form
    {
        public Задание_2()
        {
            InitializeComponent();
        }
        static void f(double x, out double y)
        {
            y = 0;
            if (Math.Abs(x) <= 1) y = x * x - 1;
            else if (Math.Abs(x) <= 2) y = 2 * x - 1;
            else if (Math.Abs(x) > 2) y = Math.Pow(x, 5) - 1;

        }
        static double f(double x)
        {
            double y=0;
            if (Math.Abs(x) <= 1) y = x * x - 1;
            else if (Math.Abs(x) <= 2) y = 2 * x - 1;
            else if (Math.Abs(x) > 2) y = Math.Pow(x, 5) - 1;
            return y;
        }

            
private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);

            double b = Convert.ToDouble(textBox2.Text);

            double h = Convert.ToDouble(textBox3.Text);

            if (h ==0)
            {
                MessageBox.Show("Шаг должен быть больше 0");
                return;
            }

            for (double i = a; i <= b; i += h)
                richTextBox1.Text += $"f({Math.Round(i, 2)})={Math.Round(f(i),4)}"+Environment.NewLine;

            for (double i = a; i <= b; i += h)
            {
                f(i, out double y);
                richTextBox2.Text += $"f({Math.Round(i, 2)})={Math.Round(f(i), 4)}" + Environment.NewLine;

            }

            if (a > b)
            {
                MessageBox.Show("Должно быть a<b");

            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Clear();
            textBox2.Text = "";
            textBox2.Clear();
            textBox3.Text = "";
            textBox3.Clear();
            richTextBox1.Text = "";
            richTextBox1.Clear();
            richTextBox2.Text = "";
            richTextBox2.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
                MessageBox.Show("Введите число");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ','))

       
            {
                e.Handled = true;
                MessageBox.Show("Введите число больше 0");
            }
           
        }
    }
}
