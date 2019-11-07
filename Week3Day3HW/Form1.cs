using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3Day3HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game1 g1 = new Game1();
            g1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game2 g2 = new Game2();
            g2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Game3 g3 = new Game3();
            g3.Show();
        }
    }
}
