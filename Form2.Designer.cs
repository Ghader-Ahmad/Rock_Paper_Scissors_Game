namespace Rock_Paper_Scissors_Game
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.pPlayerChoice = new System.Windows.Forms.Panel();
            this.rbScissors = new System.Windows.Forms.RadioButton();
            this.rbPaper = new System.Windows.Forms.RadioButton();
            this.rbRock = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumberOfRounds = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRounds = new System.Windows.Forms.Label();
            this.pFinalResults = new System.Windows.Forms.Panel();
            this.lblFinalWinner = new System.Windows.Forms.Label();
            this.lblDrawTimes = new System.Windows.Forms.Label();
            this.lblComputerWonTimes = new System.Windows.Forms.Label();
            this.lblPlayerWonTimes = new System.Windows.Forms.Label();
            this.lblGameRounds = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.Label();
            this.pbComputer = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.pPlayerChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pFinalResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(472, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rock Paer Scissors Game";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GreenYellow;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnRestartGame);
            this.panel1.Controls.Add(this.pPlayerChoice);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.lblWinner);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNumberOfRounds);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 575);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Lime;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Blue;
            this.btnClose.Location = new System.Drawing.Point(104, 528);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 42);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.Lime;
            this.btnRestartGame.Enabled = false;
            this.btnRestartGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRestartGame.FlatAppearance.BorderSize = 2;
            this.btnRestartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.Color.Blue;
            this.btnRestartGame.Location = new System.Drawing.Point(72, 469);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(165, 41);
            this.btnRestartGame.TabIndex = 5;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // pPlayerChoice
            // 
            this.pPlayerChoice.BackColor = System.Drawing.Color.Yellow;
            this.pPlayerChoice.Controls.Add(this.rbScissors);
            this.pPlayerChoice.Controls.Add(this.rbPaper);
            this.pPlayerChoice.Controls.Add(this.rbRock);
            this.pPlayerChoice.Enabled = false;
            this.pPlayerChoice.Location = new System.Drawing.Point(0, 328);
            this.pPlayerChoice.Name = "pPlayerChoice";
            this.pPlayerChoice.Size = new System.Drawing.Size(315, 72);
            this.pPlayerChoice.TabIndex = 10;
            // 
            // rbScissors
            // 
            this.rbScissors.AutoSize = true;
            this.rbScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbScissors.ForeColor = System.Drawing.Color.OrangeRed;
            this.rbScissors.Location = new System.Drawing.Point(205, 19);
            this.rbScissors.Name = "rbScissors";
            this.rbScissors.Size = new System.Drawing.Size(106, 28);
            this.rbScissors.TabIndex = 4;
            this.rbScissors.TabStop = true;
            this.rbScissors.Text = "Scissors";
            this.rbScissors.UseVisualStyleBackColor = true;
            // 
            // rbPaper
            // 
            this.rbPaper.AutoSize = true;
            this.rbPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPaper.ForeColor = System.Drawing.Color.OrangeRed;
            this.rbPaper.Location = new System.Drawing.Point(104, 19);
            this.rbPaper.Name = "rbPaper";
            this.rbPaper.Size = new System.Drawing.Size(83, 28);
            this.rbPaper.TabIndex = 3;
            this.rbPaper.TabStop = true;
            this.rbPaper.Text = "Paper";
            this.rbPaper.UseVisualStyleBackColor = true;
            // 
            // rbRock
            // 
            this.rbRock.AutoSize = true;
            this.rbRock.Checked = true;
            this.rbRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRock.ForeColor = System.Drawing.Color.OrangeRed;
            this.rbRock.Location = new System.Drawing.Point(11, 19);
            this.rbRock.Name = "rbRock";
            this.rbRock.Size = new System.Drawing.Size(75, 28);
            this.rbRock.TabIndex = 2;
            this.rbRock.TabStop = true;
            this.rbRock.Text = "Rock";
            this.rbRock.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Enabled = false;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnStart.FlatAppearance.BorderSize = 2;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Blue;
            this.btnStart.Location = new System.Drawing.Point(91, 406);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(127, 45);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.Font = new System.Drawing.Font("Segoe Marker", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Purple;
            this.lblWinner.Location = new System.Drawing.Point(55, 243);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(199, 57);
            this.lblWinner.TabIndex = 8;
            this.lblWinner.Text = "In Progress";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Marker", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(97, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 40);
            this.label4.TabIndex = 6;
            this.label4.Text = "Winner";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumberOfRounds
            // 
            this.txtNumberOfRounds.BackColor = System.Drawing.Color.LawnGreen;
            this.txtNumberOfRounds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumberOfRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfRounds.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtNumberOfRounds.Location = new System.Drawing.Point(104, 126);
            this.txtNumberOfRounds.Name = "txtNumberOfRounds";
            this.txtNumberOfRounds.Size = new System.Drawing.Size(100, 31);
            this.txtNumberOfRounds.TabIndex = 0;
            this.txtNumberOfRounds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumberOfRounds.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumberOfRounds_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(11, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "How many Rounds you want to play?";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::Rock_Paper_Scissors_Game.Properties.Resources.paper;
            this.pictureBox3.Location = new System.Drawing.Point(124, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Rock_Paper_Scissors_Game.Properties.Resources.Scissors;
            this.pictureBox2.Location = new System.Drawing.Point(237, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Rock_Paper_Scissors_Game.Properties.Resources.Rock;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Marker", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(436, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 40);
            this.label7.TabIndex = 9;
            this.label7.Text = "Player";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Marker", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(854, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 40);
            this.label8.TabIndex = 11;
            this.label8.Text = "Computer";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Segoe Marker", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPlayer.Location = new System.Drawing.Point(471, 115);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(36, 43);
            this.lblPlayer.TabIndex = 12;
            this.lblPlayer.Tag = "0";
            this.lblPlayer.Text = "0";
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Segoe Marker", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblComputer.Location = new System.Drawing.Point(912, 115);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(36, 43);
            this.lblComputer.TabIndex = 13;
            this.lblComputer.Tag = "0";
            this.lblComputer.Text = "0";
            this.lblComputer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(628, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 40);
            this.label11.TabIndex = 14;
            this.label11.Text = "Rounds :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.Font = new System.Drawing.Font("Segoe Marker", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRounds.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblRounds.Location = new System.Drawing.Point(684, 266);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(36, 43);
            this.lblRounds.TabIndex = 15;
            this.lblRounds.Text = "0";
            this.lblRounds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pFinalResults
            // 
            this.pFinalResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pFinalResults.Controls.Add(this.lblFinalWinner);
            this.pFinalResults.Controls.Add(this.lblDrawTimes);
            this.pFinalResults.Controls.Add(this.lblComputerWonTimes);
            this.pFinalResults.Controls.Add(this.lblPlayerWonTimes);
            this.pFinalResults.Controls.Add(this.lblGameRounds);
            this.pFinalResults.Controls.Add(this.label15);
            this.pFinalResults.Controls.Add(this.label14);
            this.pFinalResults.Controls.Add(this.label13);
            this.pFinalResults.Controls.Add(this.label12);
            this.pFinalResults.Controls.Add(this.label10);
            this.pFinalResults.Controls.Add(this.label9);
            this.pFinalResults.Location = new System.Drawing.Point(414, 328);
            this.pFinalResults.Name = "pFinalResults";
            this.pFinalResults.Size = new System.Drawing.Size(590, 234);
            this.pFinalResults.TabIndex = 16;
            this.pFinalResults.Visible = false;
            // 
            // lblFinalWinner
            // 
            this.lblFinalWinner.AutoSize = true;
            this.lblFinalWinner.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalWinner.ForeColor = System.Drawing.Color.Black;
            this.lblFinalWinner.Location = new System.Drawing.Point(234, 195);
            this.lblFinalWinner.Name = "lblFinalWinner";
            this.lblFinalWinner.Size = new System.Drawing.Size(23, 28);
            this.lblFinalWinner.TabIndex = 25;
            this.lblFinalWinner.Text = "0";
            this.lblFinalWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDrawTimes
            // 
            this.lblDrawTimes.AutoSize = true;
            this.lblDrawTimes.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawTimes.ForeColor = System.Drawing.Color.Black;
            this.lblDrawTimes.Location = new System.Drawing.Point(234, 161);
            this.lblDrawTimes.Name = "lblDrawTimes";
            this.lblDrawTimes.Size = new System.Drawing.Size(23, 28);
            this.lblDrawTimes.TabIndex = 24;
            this.lblDrawTimes.Text = "0";
            this.lblDrawTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComputerWonTimes
            // 
            this.lblComputerWonTimes.AutoSize = true;
            this.lblComputerWonTimes.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerWonTimes.ForeColor = System.Drawing.Color.Black;
            this.lblComputerWonTimes.Location = new System.Drawing.Point(234, 127);
            this.lblComputerWonTimes.Name = "lblComputerWonTimes";
            this.lblComputerWonTimes.Size = new System.Drawing.Size(23, 28);
            this.lblComputerWonTimes.TabIndex = 23;
            this.lblComputerWonTimes.Text = "0";
            this.lblComputerWonTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerWonTimes
            // 
            this.lblPlayerWonTimes.AutoSize = true;
            this.lblPlayerWonTimes.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWonTimes.ForeColor = System.Drawing.Color.Black;
            this.lblPlayerWonTimes.Location = new System.Drawing.Point(234, 93);
            this.lblPlayerWonTimes.Name = "lblPlayerWonTimes";
            this.lblPlayerWonTimes.Size = new System.Drawing.Size(23, 28);
            this.lblPlayerWonTimes.TabIndex = 22;
            this.lblPlayerWonTimes.Text = "0";
            this.lblPlayerWonTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGameRounds
            // 
            this.lblGameRounds.AutoSize = true;
            this.lblGameRounds.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameRounds.ForeColor = System.Drawing.Color.Black;
            this.lblGameRounds.Location = new System.Drawing.Point(234, 59);
            this.lblGameRounds.Name = "lblGameRounds";
            this.lblGameRounds.Size = new System.Drawing.Size(23, 28);
            this.lblGameRounds.TabIndex = 17;
            this.lblGameRounds.Text = "0";
            this.lblGameRounds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(16, 199);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(155, 24);
            this.label15.TabIndex = 21;
            this.label15.Text = "FINAL WINNER : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(16, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 24);
            this.label14.TabIndex = 20;
            this.label14.Text = "Draw Times : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(16, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(210, 24);
            this.label13.TabIndex = 19;
            this.label13.Text = "Computer Won Times : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(16, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 24);
            this.label12.TabIndex = 18;
            this.label12.Text = "Player Won Times : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(16, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "Game Rounds : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(32, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(541, 40);
            this.label9.TabIndex = 17;
            this.label9.Text = "Thang you for using my game\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Marker", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(657, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 40);
            this.label3.TabIndex = 17;
            this.label3.Text = "Draw";
            // 
            // lblDraw
            // 
            this.lblDraw.AutoSize = true;
            this.lblDraw.Font = new System.Drawing.Font("Segoe Marker", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraw.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblDraw.Location = new System.Drawing.Point(684, 115);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(36, 43);
            this.lblDraw.TabIndex = 18;
            this.lblDraw.Tag = "0";
            this.lblDraw.Text = "0";
            this.lblDraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbComputer
            // 
            this.pbComputer.BackColor = System.Drawing.Color.White;
            this.pbComputer.Image = global::Rock_Paper_Scissors_Game.Properties.Resources.question_mark_96;
            this.pbComputer.Location = new System.Drawing.Point(853, 161);
            this.pbComputer.Name = "pbComputer";
            this.pbComputer.Size = new System.Drawing.Size(151, 151);
            this.pbComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbComputer.TabIndex = 10;
            this.pbComputer.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.White;
            this.pbPlayer.Image = global::Rock_Paper_Scissors_Game.Properties.Resources.question_mark_96;
            this.pbPlayer.Location = new System.Drawing.Point(414, 158);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(151, 151);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer.TabIndex = 9;
            this.pbPlayer.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1066, 574);
            this.Controls.Add(this.lblDraw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pFinalResults);
            this.Controls.Add(this.lblRounds);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbComputer);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Rock_Paper_Scissors Game";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pPlayerChoice.ResumeLayout(false);
            this.pPlayerChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pFinalResults.ResumeLayout(false);
            this.pFinalResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumberOfRounds;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbComputer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Panel pPlayerChoice;
        private System.Windows.Forms.RadioButton rbRock;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rbScissors;
        private System.Windows.Forms.RadioButton rbPaper;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.Panel pFinalResults;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFinalWinner;
        private System.Windows.Forms.Label lblDrawTimes;
        private System.Windows.Forms.Label lblComputerWonTimes;
        private System.Windows.Forms.Label lblPlayerWonTimes;
        private System.Windows.Forms.Label lblGameRounds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDraw;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timer1;
    }
}