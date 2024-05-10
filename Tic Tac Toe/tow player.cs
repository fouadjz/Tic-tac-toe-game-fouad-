using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class tow_player : Form
    {
        public tow_player()
        {
            InitializeComponent();
        }
        Player p = new Player();
        private void tow_player_Load(object sender, EventArgs e)
        {
            foreach (Control c in panelofbutton.Controls)
            {
                if (c is Button)
                {
                    c.Click += new System.EventHandler(but_click);
                }
            }

        }
        private void but_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Equals(""))
            {
                if (p.X_o % 2 == 0)
                {
                    btn.Text = "X";
                    btn.ForeColor = Color.Red;
                    p.Getthewiner(btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, lbp1, lbp2, lbdrow);
                }
                else
                {
                    btn.Text = "O";
                    btn.ForeColor = Color.Blue;
                    p.Getthewiner(btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, lbp1, lbp2, lbdrow);
                }
                p.X_o++;
            }
        }



        private void btnexit_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();

        }

        private void btnagain_Click_1(object sender, EventArgs e)
        {
            p.Playagain(panelofbutton);
            p.Resrtcolor(btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9);

        }


    }
}
