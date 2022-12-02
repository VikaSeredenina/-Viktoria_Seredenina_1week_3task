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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Задание_1 odin = new Задание_1();
            odin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Задание_2 two = new Задание_2();
            two.Show();
        }

       
    }
}
