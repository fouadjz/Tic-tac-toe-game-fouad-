using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Tic_Tac_Toe
{
    class Player
    {
        int player1;
        int player2;
        bool win;
        int drow;
        int x_o;
        public int Player1
        {
            get { return player1; }
            set { player1 = value; }
        }
        public int Player2
        {
            get { return player2; }
            set { player2 = value; }
        }
        public bool Win
        {
            get { return win; }
            set { win = value; }
        }
        public int Drow
        {
            get { return drow; }
            set { drow = value; }
        }
        public int X_o
        {
            get { return x_o; }
            set { x_o = value; }
        }
        public void wineffect(Button b1, Button b2, Button b3, Label l1, Label l2)
        {

            b1.ForeColor = Color.Yellow;
            //b1.BackColor = Color.Black;
            b2.ForeColor = Color.Yellow;
            // b2.BackColor = Color.Black;
            b3.ForeColor = Color.Yellow;
            //b3.BackColor = Color.Black;

            if (b1.Text == "X" && Win == false)
            {
                Player1++;
                MessageBox.Show("the winner is X");
                l1.Text = Convert.ToString(Player1);
            }
            else if (Win == false)
            {
                Player2++;
                MessageBox.Show("the winner is O");
                l2.Text = Convert.ToString(Player2);

            }
        }

        public void Getthewiner(Button btn1, Button btn2, Button btn3, Button btn4, Button btn5, Button btn6, Button btn7, Button btn8, Button btn9, Label lbp1, Label lbp2, Label lbdrow)
        {


            if (btn1.Text != "" && btn1.Text == btn2.Text && btn1.Text == btn3.Text)
            { wineffect(btn1, btn2, btn3, lbp1, lbp2); Win = true; }

            else if (btn4.Text != "" && btn4.Text == btn5.Text && btn4.Text == btn6.Text)
            { wineffect(btn4, btn5, btn6, lbp1, lbp2); Win = true; }
            else if (btn7.Text != "" && btn7.Text == btn8.Text && btn7.Text == btn9.Text)
            { wineffect(btn7, btn8, btn9, lbp1, lbp2); Win = true; }
            else if (btn1.Text != "" && btn1.Text == btn4.Text && btn1.Text == btn7.Text)
            { wineffect(btn1, btn4, btn7, lbp1, lbp2); Win = true; }

            else if (btn2.Text != "" && btn2.Text == btn5.Text && btn2.Text == btn8.Text)
            { wineffect(btn5, btn2, btn8, lbp1, lbp2); Win = true; }

            else if (btn3.Text != "" && btn3.Text == btn6.Text && btn3.Text == btn9.Text)
            { wineffect(btn9, btn6, btn3, lbp1, lbp2); Win = true; }

            else if (btn1.Text != "" && btn1.Text == btn5.Text && btn1.Text == btn9.Text)
            { wineffect(btn1, btn5, btn9, lbp1, lbp2); Win = true; }
            else if (btn3.Text != "" && btn3.Text == btn5.Text && btn3.Text == btn7.Text)
            { wineffect(btn7, btn5, btn3, lbp1, lbp2); Win = true; }

            if (Win == false && btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
            {


                Drow++;
                MessageBox.Show("Drow");
                lbdrow.Text = Drow.ToString();
            }


        }
        public void Resrtcolor(Button btn1, Button btn2, Button btn3, Button btn4, Button btn5, Button btn6, Button btn7, Button btn8, Button btn9)
        {
            btn1.ForeColor = Color.Black;
            btn2.ForeColor = Color.Black;
            btn3.ForeColor = Color.Black;
            btn4.ForeColor = Color.Black;
            btn5.ForeColor = Color.Black;
            btn6.ForeColor = Color.Black;
            btn7.ForeColor = Color.Black;
            btn8.ForeColor = Color.Black;
            btn9.ForeColor = Color.Black;

        }
        public void Playagain(Panel panelofbutton)
        {
            X_o = 0;
            Win = false;
            foreach (Control c in panelofbutton.Controls)
            {
                if (c is Button)
                {
                    c.Text = "";


                }
            }
        }
        
    }
}
