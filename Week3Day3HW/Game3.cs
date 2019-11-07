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
    public partial class Game3 : Form
    {
        int count = 0;
        public Game3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count += 1;
            ChangeTxt(count);
        }

        private void ChangeTxt(int count)
        {
            switch (count)
            {
                case 1:
                    displaytxt1.Text = "This one could be a simple Naughts and Crosses game";
                    break;
                case 2:
                    displaytxt1.Text = "Since we only have a week and I have no idea how far my skills will take me";
                    break;
                case 3:
                    displaytxt1.Text = "Or how hard the work will be";
                    break;
                default:
                    displaytxt1.Text = "";
                    ResetCount();
                    break;
            }
        }


        private void ResetCount()
        {
            count = 0;
        }
    }
}
