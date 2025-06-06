using Rock_Paper_Scissors_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace Rock_Paper_Scissors_Game
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        enum enWinner { Player = 1, Computer = 2, Draw = 3 };
        enum enTurnPlayer { Player = 1, Computer = 2 };

        enum enChoice { Rock = 1, Paper = 2, Scissors = 3 };

        struct stGameResults
        {
            public short GameRounds;
            public short PlayerWonTimes;
            public short ComputerWonTimes;
            public short DrawTimes;
            public enWinner FinalWinner;
        }

        stGameResults GameResults = new stGameResults();

        Random RandNumber = new Random();
        private int RandomNumber (int From, int To)
        {
            return RandNumber.Next(From, To);
        }

        private bool ValidateNumber(string Input)
        {
            short Number = 0;
            bool isValidateNumber = short.TryParse(Input, out Number) && Number >= 0;

            return isValidateNumber;
        }

        private void SetPlayerPicture(enChoice Choice)
        {
            switch (Choice)
            {
                case enChoice.Rock:
                    pbPlayer.Image = Resources.Rock;
                    break;

                case enChoice.Paper:
                    pbPlayer.Image = Resources.paper;
                    break;

                default:
                    pbPlayer.Image = Resources.Scissors;
                    break;
            }
        }

        private void SetComputerPicture(enChoice Choice)
        {
            switch (Choice)
            {
                case enChoice.Rock:
                    pbComputer.Image = Resources.Rock;
                    break;

                case enChoice.Paper:
                    pbComputer.Image = Resources.paper;
                    break;

                default:
                    pbComputer.Image = Resources.Scissors;
                    break;
            }
        }

        private void SetBackColor(enWinner Winner)
        {
            switch(Winner)
            {
                case enWinner.Player:
                    this.BackColor = Color.Chartreuse;
                    break;

                case enWinner.Computer:
                    SystemSounds.Beep.Play();
                    this.BackColor = Color.Red;
                    break;

                default:
                    this.BackColor = Color.Orange;
                    break;
            }
        }

        private enChoice GetPlayerChoice()
        {
            if (rbRock.Checked)
            {
                SetPlayerPicture(enChoice.Rock);
                return enChoice.Rock;
            }

            if (rbPaper.Checked)
            {
                SetPlayerPicture(enChoice.Paper);
                return enChoice.Paper;
            }

            if (rbScissors.Checked)
            {
                SetPlayerPicture(enChoice.Scissors);
                return enChoice.Scissors;
            }

            else
            {
                SetPlayerPicture(enChoice.Rock);
                return enChoice.Rock;
            }
        }

     

        private enChoice GetComputerChoice()
        {
            enChoice ChoiceComputer;
            ChoiceComputer = (enChoice)RandomNumber(1, 4);
            SetComputerPicture(ChoiceComputer);

         

            return ChoiceComputer;
        }

        private void SetLabelWinner(enWinner Winner)
        {
            lblWinner.Text = Winner.ToString();
        }

        private void SetLabelDraw()
        {
            lblDraw.Tag = (Convert.ToInt16(lblDraw.Tag) + 1).ToString();
            lblDraw.Text = lblDraw.Tag.ToString();
            SetLabelWinner(enWinner.Draw);
            SetBackColor(enWinner.Draw);
        }

        private void SetLabelComputer()
        {
            lblComputer.Tag = (Convert.ToInt16(lblComputer.Tag) + 1).ToString();
            lblComputer.Text = lblComputer.Tag.ToString();
            SetLabelWinner(enWinner.Computer);
            SetBackColor(enWinner.Computer);
        }

        private void SetLabelPlayer()
        {
            lblPlayer.Tag = (Convert.ToInt16(lblPlayer.Tag) + 1).ToString();
            lblPlayer.Text = lblPlayer.Tag.ToString();
            SetLabelWinner(enWinner.Player);
            SetBackColor(enWinner.Player);
        }

        private enWinner WhoIsWinnerInRound(enChoice PlayerChoice, enChoice ComputerChoice)
        {
            if (PlayerChoice == ComputerChoice)
            {
                SetLabelDraw();
                GameResults.DrawTimes++;
                return enWinner.Draw;
            }

            if (PlayerChoice == enChoice.Rock && ComputerChoice == enChoice.Paper)
            {
                SetLabelComputer();
                GameResults.ComputerWonTimes++;
                return enWinner.Computer;
            }

            if (PlayerChoice == enChoice.Paper && ComputerChoice == enChoice.Scissors)
            {
                SetLabelComputer();
                GameResults.ComputerWonTimes++;
                return enWinner.Computer;
            }

            if (PlayerChoice == enChoice.Scissors && ComputerChoice == enChoice.Rock)
            {
                SetLabelComputer();
                GameResults.ComputerWonTimes++;
                return enWinner.Computer;
            }

            else
            {
                SetLabelPlayer();
                GameResults.PlayerWonTimes++;
                return enWinner.Player;
            }
        }

        private enWinner FinalWinner()
        {
            if (GameResults.PlayerWonTimes > GameResults.ComputerWonTimes)
            {
                SetBackColor(enWinner.Player);
                return enWinner.Player;
            }


            if (GameResults.ComputerWonTimes > GameResults.PlayerWonTimes)
            {
                SetBackColor(enWinner.Computer);
                return enWinner.Computer;
            }

            else
            {
                SetBackColor(enWinner.Draw);
                return enWinner.Draw;
            }
        }

        private void FinalResults()
        {
            lblGameRounds.Text = GameResults.GameRounds.ToString();
            lblPlayerWonTimes.Text = GameResults.PlayerWonTimes.ToString();
            lblComputerWonTimes.Text = GameResults.ComputerWonTimes.ToString();
            lblDrawTimes.Text = GameResults.DrawTimes.ToString();
            lblFinalWinner.Text = FinalWinner().ToString();
        }

        private void StartGame()
        {
            timer1.Enabled = false;

            if (GameResults.GameRounds < Convert.ToInt16(txtNumberOfRounds.Text))
            {
                GameResults.GameRounds++;
                lblRounds.Text = GameResults.GameRounds.ToString();

                WhoIsWinnerInRound(GetPlayerChoice(), GetComputerChoice());
            }

            else
            {
                if (MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    pFinalResults.Visible = true;
                }

                lblWinner.Text = "Game Over";
                FinalResults();
            }
        }

        private void ResetPictures()
        {
            pbComputer.Image = Resources.question_mark_96;
            pbPlayer.Image = Resources.question_mark_96;
        }
        
        private void ResetLabel()
        {
            txtNumberOfRounds.Text = "";
            lblWinner.Text = "In Progress";

            lblPlayer.Text = "0";
            lblDraw.Text = "0";
            lblComputer.Text = "0";

            lblRounds.Text = "0";
        }
        
        private void ResetGameResult()
        {
            GameResults = new stGameResults();

            lblComputer.Tag = "0";
            lblDraw.Tag = "0";
            lblPlayer.Tag = "0";
        }
        
        private void UpdateUserInterface(bool Bool)
        {
            pFinalResults.Visible = false;
            pPlayerChoice.Enabled = Bool;
            btnRestartGame.Enabled = Bool;
            btnStart.Enabled = Bool;

            this.BackColor = Color.Yellow;
        }
        
        private void RestartGame()
        {
            ResetLabel();
            ResetGameResult();
            ResetPictures();
            UpdateUserInterface(false);
        }






        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            StartGame();
        }

        private void txtNumberOfRounds_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumberOfRounds.Text) || !ValidateNumber(txtNumberOfRounds.Text))
            {
                e.Cancel = true;
                txtNumberOfRounds.Focus();
                errorProvider1.SetError(txtNumberOfRounds, "Please enter a positive number!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNumberOfRounds, "");
                UpdateUserInterface(true);
            }
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
