using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyBoardMangement
{
    public partial class Key : Form
    {
        public Key()
        {
            InitializeComponent();
        }

        private void btnMove_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnMove_KeyDown(object sender, KeyEventArgs e)
        {
           // label1.Text = "Please enter A  in Keyboard";
            if (e.KeyCode==Keys.A && btnMove.Left>=0)
            {
                btnMove.Left = btnMove.Left-10;
            }
          //  label1.Text = "Please enter T in Keyboard";
            else if (e.KeyCode==Keys.T&& btnMove.Top>=0)
            {
                btnMove.Top = btnMove.Top-10;
            }
            else if (e.KeyCode==Keys.D && btnMove.Left > 0)
            {
                btnMove.Left = btnMove.Left + 10; ;
            }
            else if (e.KeyCode == Keys.B&& btnMove.Top >= 0)
            {
                btnMove.Top = btnMove.Top+ 10; ;
            }
            else
            {
                Environment.Exit(0);
            }
            
        }
    }
}
