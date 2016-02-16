using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem1
{
    public partial class Form1 : Form
    {
        int x2;
        int x3;
        int wynik;

        public Form1()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
          
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            x2 = x * x;
            x3 = x2 * x;
            wynik = x3;
            textBox2.Text = wynik.ToString();
        }
    }
}
