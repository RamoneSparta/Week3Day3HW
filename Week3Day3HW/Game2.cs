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
    public partial class Game2 : Form
    {
        int count = 0;
        public Game2()
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
                    displaytxt1.Text = "The second game, This game is a matching game";
                    break;
                case 2:
                    displaytxt1.Text = "where the items on the cards will match a card that the player, and they'll need to find it";
                    break;
                case 3:
                    displaytxt1.Text = "And I could introduce a counter to speed up the process (like a timer that counts down";
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
