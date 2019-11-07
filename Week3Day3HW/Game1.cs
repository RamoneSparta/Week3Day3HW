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
    public partial class Game1 : Form
    {
        int count = 0;
        public Game1()
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
                    displaytxt1.Text = "This is the first game:";
                    break;
                case 2:
                    displaytxt1.Text = "This game is a 2 player shooter vs game.";
                    break;
                case 3:
                    displaytxt1.Text = "You get upgrades and weapons as you play";
                    break;
                case 4:
                    displaytxt1.Text = "And once a player wins, the game is over";
                    break;
                default:
                    displaytxt1.Text = "";
                    ResetCount();
                        break;
            }
        }


        private void ResetCount ()
        {
            count = 0;
        }
    }
}
