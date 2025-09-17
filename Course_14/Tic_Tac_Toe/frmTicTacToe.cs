using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    public partial class frmTicTacToe : Form
    {
        public frmTicTacToe()
        {
            InitializeComponent();
        }

        private int _NumberOfRound = 0;

        void UpdatePlayerTurn()
        {
            if (lblTurn.Tag.ToString() == "o")
            {
                lblPlayer.Text = "Player 2 - O";
            }
            else if (lblTurn.Tag.ToString() == "x")
            {
                lblPlayer.Text = "Player 1 - X";
            }

        }

        void ShowGameOverMessage()
        {
            lblWinnerPlayer.Text = lblPlayer.Text;
            lblPlayer.Text = "Game Over";
            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                if (btn1.Tag.ToString() == "x")
                {
                    btn1.BackgroundImage = Resources.xGreen;
                    btn2.BackgroundImage = Resources.xGreen;
                    btn3.BackgroundImage = Resources.xGreen;

                    ShowGameOverMessage();

                    return true;
                }
                else
                {
                    btn1.BackgroundImage = Resources.oGreen;
                    btn2.BackgroundImage = Resources.oGreen;
                    btn3.BackgroundImage = Resources.oGreen;

                    ShowGameOverMessage();

                    return true;
                }
            }

            return false;
        }

        void CheckIfAnyoneWin()
        {
            if (CheckValues(btn00, btn11, btn22))
            {
                return;
            }
            else if (CheckValues(btn00, btn10, btn20))
            {
                return;
            }
            else if (CheckValues(btn01, btn11, btn21))
            {

                return;
            }
            else if (CheckValues(btn02, btn12, btn22))
            {
                return;
            }
            else if (CheckValues(btn00, btn01, btn02))
            {
                return;
            }
            else if (CheckValues(btn10, btn11, btn12))
            {
                return;
            }
            else if (CheckValues(btn20, btn21, btn22))
            {
                return ;
            }
            else if (CheckValues(btn02, btn11, btn20))
            {
                return;
            }
            else if (_NumberOfRound >= 9)
            {
                lblPlayer.Text = "Draw";
                ShowGameOverMessage();

                return;
            }
            else 
            {
                UpdatePlayerTurn();
            }

        }

        void ChangeImage(Button btn) 
        {
            if (btn.Tag.ToString() == "?")
            {
                if (lblTurn.Tag.ToString() == "x")
                {
                    btn.BackgroundImage = Resources.xYellow;
                    lblTurn.Tag = "o";
                    btn.Tag = "x";
                }
                else if (lblTurn.Tag.ToString() == "o")
                {
                    btn.BackgroundImage = Resources.oYellow;
                    lblTurn.Tag = "x";
                    btn.Tag = "o";
                }

                _NumberOfRound++;
                CheckIfAnyoneWin();

            }
            else 
            {
                CheckChoice(true);
            }
        }

        void CheckChoice(bool isClicked)
        {
            if (isClicked)
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color myColor = Color.FromArgb(170, 35, 35, 35);

            Pen myPen = new Pen(myColor);
            myPen.Width = 14;

            myPen.StartCap = System.Drawing.Drawing2D.LineCap.Flat;
            myPen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;

            e.Graphics.DrawLine(myPen, 560, 10, 560, 420);
            e.Graphics.DrawLine(myPen, 760, 10, 760, 420);
            e.Graphics.DrawLine(myPen, 400, 130, 900, 130);
            e.Graphics.DrawLine(myPen, 400, 280, 900, 280);

        }

        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

        public void ResetButton(Button btn) 
        {
            btn.Tag = "?";
            btn.BackgroundImage = Resources.QuestionMarkRed;

        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {

            _NumberOfRound = 0;
            lblTurn.Tag = "x";

            lblPlayer.Text = "Player 1 - X";
            lblWinnerPlayer.Text = "In Progress";

            ResetButton(btn00);
            ResetButton(btn01);
            ResetButton(btn02);
            ResetButton(btn10);
            ResetButton(btn11);
            ResetButton(btn12);
            ResetButton(btn20);
            ResetButton(btn21);
            ResetButton(btn22);

        }

    }
}
