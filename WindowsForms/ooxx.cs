using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class ooxx : Form
    {
        private int XorO = 0;
        private bool win = false;

        public ooxx()
        {
            InitializeComponent();
            LoadButtons();
        }

        private void LoadButtons()
        {
            foreach (Control c in Controls)
            {
                if (c is Button btn && btn.Name != "button10" && btn.Name != "button11")
                {
                    btn.Click += Btn_Click;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Equals(""))
            {
                if (XorO % 2 == 0)
                {
                    btn.Text = "X";
                    btn.ForeColor = Color.Red;
                }
                else
                {
                    btn.Text = "O";
                    btn.ForeColor = Color.Green;
                }

                XorO++;
                CheckForWin();
            }
        }

        private void CheckForWin()
        {
            if (CheckLine(button1, button2, button3) ||
                CheckLine(button4, button5, button6) ||
                CheckLine(button7, button8, button9) ||
                CheckLine(button1, button4, button7) ||
                CheckLine(button2, button5, button8) ||
                CheckLine(button3, button6, button9) ||
                CheckLine(button1, button5, button9) ||
                CheckLine(button3, button5, button7))
            {
                win = true;
                MessageBox.Show("玩家 " + (XorO % 2 == 0 ? "O" : "X") + " 贏!");
                ResetGame();
            }
            else if (XorO == 9)
            {
                MessageBox.Show("平手!!");
                ResetGame();
            }
        }

        private bool CheckLine(Button btn1, Button btn2, Button btn3)
        {
            return !btn1.Text.Equals("") && btn1.Text.Equals(btn2.Text) && btn1.Text.Equals(btn3.Text);
        }

        private void ResetGame()
        {
            XorO = 0;
            win = false;

            foreach (Control c in Controls)
            {
                if (c is Button btn && btn.Name != "button10" && btn.Name != "button11")
                {
                    btn.Text = "";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ooxx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                ResetGame();
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

       
    }
}
