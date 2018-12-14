namespace WerewolfClient
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GBChat = new System.Windows.Forms.GroupBox();
            this.TbChatBox = new System.Windows.Forms.TextBox();
            this.TbChatInput = new System.Windows.Forms.TextBox();
            this.GBAction = new System.Windows.Forms.GroupBox();
            this.BtnVote = new System.Windows.Forms.Button();
            this.BtnAction = new System.Windows.Forms.Button();
            this.GBStatus = new System.Windows.Forms.GroupBox();
            this.LBTime = new System.Windows.Forms.Label();
            this.LBDay = new System.Windows.Forms.Label();
            this.LBPeriod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPlayer3 = new System.Windows.Forms.Button();
            this.BtnPlayer0 = new System.Windows.Forms.Button();
            this.BtnPlayer1 = new System.Windows.Forms.Button();
            this.BtnPlayer2 = new System.Windows.Forms.Button();
            this.BtnPlayer4 = new System.Windows.Forms.Button();
            this.BtnPlayer5 = new System.Windows.Forms.Button();
            this.BtnPlayer6 = new System.Windows.Forms.Button();
            this.BtnPlayer7 = new System.Windows.Forms.Button();
            this.BtnPlayer8 = new System.Windows.Forms.Button();
            this.BtnPlayer9 = new System.Windows.Forms.Button();
            this.BtnPlayer10 = new System.Windows.Forms.Button();
            this.BtnPlayer11 = new System.Windows.Forms.Button();
            this.BtnPlayer12 = new System.Windows.Forms.Button();
            this.BtnPlayer13 = new System.Windows.Forms.Button();
            this.BtnPlayer14 = new System.Windows.Forms.Button();
            this.BtnPlayer15 = new System.Windows.Forms.Button();
            this.GBPlayers = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_Join = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.GBStatus.SuspendLayout();
            this.GBPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Join)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // GBChat
            // 
            this.GBChat.BackColor = System.Drawing.Color.Transparent;
            this.GBChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBChat.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.GBChat.Location = new System.Drawing.Point(760, 99);
            this.GBChat.Name = "GBChat";
            this.GBChat.Size = new System.Drawing.Size(303, 407);
            this.GBChat.TabIndex = 2;
            this.GBChat.TabStop = false;
            // 
            // TbChatBox
            // 
            this.TbChatBox.BackColor = System.Drawing.Color.White;
            this.TbChatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbChatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbChatBox.Location = new System.Drawing.Point(428, 12);
            this.TbChatBox.Multiline = true;
            this.TbChatBox.Name = "TbChatBox";
            this.TbChatBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbChatBox.Size = new System.Drawing.Size(290, 365);
            this.TbChatBox.TabIndex = 0;
            // 
            // TbChatInput
            // 
            this.TbChatInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbChatInput.Location = new System.Drawing.Point(428, 383);
            this.TbChatInput.Name = "TbChatInput";
            this.TbChatInput.Size = new System.Drawing.Size(290, 26);
            this.TbChatInput.TabIndex = 1;
            this.TbChatInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbChatInput_Enter);
            // 
            // GBAction
            // 
            this.GBAction.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GBAction.Location = new System.Drawing.Point(809, 510);
            this.GBAction.Name = "GBAction";
            this.GBAction.Size = new System.Drawing.Size(198, 82);
            this.GBAction.TabIndex = 3;
            this.GBAction.TabStop = false;
            this.GBAction.Text = "Action";
            // 
            // BtnVote
            // 
            this.BtnVote.BackColor = System.Drawing.Color.Transparent;
            this.BtnVote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVote.Location = new System.Drawing.Point(12, 432);
            this.BtnVote.Name = "BtnVote";
            this.BtnVote.Size = new System.Drawing.Size(117, 137);
            this.BtnVote.TabIndex = 0;
            this.BtnVote.Text = "Vote";
            this.BtnVote.UseVisualStyleBackColor = false;
            this.BtnVote.Click += new System.EventHandler(this.BtnVote_Click);
            // 
            // BtnAction
            // 
            this.BtnAction.BackColor = System.Drawing.Color.Transparent;
            this.BtnAction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAction.BackgroundImage")));
            this.BtnAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAction.Location = new System.Drawing.Point(135, 432);
            this.BtnAction.Name = "BtnAction";
            this.BtnAction.Size = new System.Drawing.Size(113, 137);
            this.BtnAction.TabIndex = 1;
            this.BtnAction.Text = "Action";
            this.BtnAction.UseVisualStyleBackColor = false;
            this.BtnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // GBStatus
            // 
            this.GBStatus.BackColor = System.Drawing.Color.Transparent;
            this.GBStatus.Controls.Add(this.LBTime);
            this.GBStatus.Controls.Add(this.LBDay);
            this.GBStatus.Controls.Add(this.LBPeriod);
            this.GBStatus.Controls.Add(this.label2);
            this.GBStatus.Controls.Add(this.label1);
            this.GBStatus.ForeColor = System.Drawing.Color.White;
            this.GBStatus.Location = new System.Drawing.Point(589, 432);
            this.GBStatus.Name = "GBStatus";
            this.GBStatus.Size = new System.Drawing.Size(117, 133);
            this.GBStatus.TabIndex = 8;
            this.GBStatus.TabStop = false;
            this.GBStatus.Text = "Status";
            // 
            // LBTime
            // 
            this.LBTime.AutoSize = true;
            this.LBTime.ForeColor = System.Drawing.Color.Transparent;
            this.LBTime.Location = new System.Drawing.Point(40, 52);
            this.LBTime.Name = "LBTime";
            this.LBTime.Size = new System.Drawing.Size(13, 13);
            this.LBTime.TabIndex = 12;
            this.LBTime.Text = "0";
            // 
            // LBDay
            // 
            this.LBDay.AutoSize = true;
            this.LBDay.Location = new System.Drawing.Point(40, 35);
            this.LBDay.Name = "LBDay";
            this.LBDay.Size = new System.Drawing.Size(13, 13);
            this.LBDay.TabIndex = 11;
            this.LBDay.Text = "0";
            // 
            // LBPeriod
            // 
            this.LBPeriod.AutoSize = true;
            this.LBPeriod.Location = new System.Drawing.Point(7, 19);
            this.LBPeriod.Name = "LBPeriod";
            this.LBPeriod.Size = new System.Drawing.Size(44, 13);
            this.LBPeriod.TabIndex = 10;
            this.LBPeriod.Text = "Night of";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Day #";
            // 
            // BtnPlayer3
            // 
            this.BtnPlayer3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPlayer3.BackgroundImage")));
            this.BtnPlayer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayer3.ForeColor = System.Drawing.Color.Black;
            this.BtnPlayer3.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer3.Image")));
            this.BtnPlayer3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer3.Location = new System.Drawing.Point(317, 9);
            this.BtnPlayer3.Name = "BtnPlayer3";
            this.BtnPlayer3.Size = new System.Drawing.Size(100, 100);
            this.BtnPlayer3.TabIndex = 4;
            this.BtnPlayer3.Tag = "3";
            this.BtnPlayer3.Text = "Player";
            this.BtnPlayer3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer3.UseVisualStyleBackColor = true;
            // 
            // BtnPlayer0
            // 
            this.BtnPlayer0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPlayer0.BackgroundImage")));
            this.BtnPlayer0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPlayer0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayer0.ForeColor = System.Drawing.Color.Black;
            this.BtnPlayer0.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer0.Image")));
            this.BtnPlayer0.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer0.Location = new System.Drawing.Point(2, 9);
            this.BtnPlayer0.Name = "BtnPlayer0";
            this.BtnPlayer0.Size = new System.Drawing.Size(100, 100);
            this.BtnPlayer0.TabIndex = 1;
            this.BtnPlayer0.Tag = "0";
            this.BtnPlayer0.Text = "Player";
            this.BtnPlayer0.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer0.UseVisualStyleBackColor = true;
            // 
            // BtnPlayer1
            // 
            this.BtnPlayer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPlayer1.BackgroundImage")));
            this.BtnPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayer1.ForeColor = System.Drawing.Color.Black;
            this.BtnPlayer1.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer1.Image")));
            this.BtnPlayer1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer1.Location = new System.Drawing.Point(107, 9);
            this.BtnPlayer1.Name = "BtnPlayer1";
            this.BtnPlayer1.Size = new System.Drawing.Size(100, 100);
            this.BtnPlayer1.TabIndex = 2;
            this.BtnPlayer1.Tag = "1";
            this.BtnPlayer1.Text = "Player";
            this.BtnPlayer1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer1.UseVisualStyleBackColor = true;
            // 
            // BtnPlayer2
            // 
            this.BtnPlayer2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPlayer2.BackgroundImage")));
            this.BtnPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayer2.ForeColor = System.Drawing.Color.Black;
            this.BtnPlayer2.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer2.Image")));
            this.BtnPlayer2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer2.Location = new System.Drawing.Point(212, 9);
            this.BtnPlayer2.Name = "BtnPlayer2";
            this.BtnPlayer2.Size = new System.Drawing.Size(100, 100);
            this.BtnPlayer2.TabIndex = 3;
            this.BtnPlayer2.Tag = "2";
            this.BtnPlayer2.Text = "Player";
            this.BtnPlayer2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer2.UseVisualStyleBackColor = true;
            // 
            // BtnPlayer4
            // 
            this.BtnPlayer4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPlayer4.BackgroundImage")));
            this.BtnPlayer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayer4.ForeColor = System.Drawing.Color.Black;
            this.BtnPlayer4.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer4.Image")));
            this.BtnPlayer4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer4.Location = new System.Drawing.Point(2, 114);
            this.BtnPlayer4.Name = "BtnPlayer4";
            this.BtnPlayer4.Size = new System.Drawing.Size(100, 100);
            this.BtnPlayer4.TabIndex = 5;
            this.BtnPlayer4.Tag = "4";
            this.BtnPlayer4.Text = "Player";
            this.BtnPlayer4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer4.UseVisualStyleBackColor = true;
            // 
            // BtnPlayer5
            // 
            this.BtnPlayer5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPlayer5.BackgroundImage")));
            this.BtnPlayer5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayer5.ForeColor = System.Drawing.Color.Black;
            this.BtnPlayer5.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer5.Image")));
            this.BtnPlayer5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer5.Location = new System.Drawing.Point(107, 114);
            this.BtnPlayer5.Name = "BtnPlayer5";
            this.BtnPlayer5.Size = new System.Drawing.Size(100, 100);
            this.BtnPlayer5.TabIndex = 6;
            this.BtnPlayer5.Tag = "5";
            this.BtnPlayer5.Text = "Player";
            this.BtnPlayer5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer5.UseVisualStyleBackColor = true;
            // 
            // BtnPlayer6
            // 
            this.BtnPlayer6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPlayer6.BackgroundImage")));
            this.BtnPlayer6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayer6.ForeColor = System.Drawing.Color.Black;
            this.BtnPlayer6.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer6.Image")));
            this.BtnPlayer6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer6.Location = new System.Drawing.Point(212, 114);
            this.BtnPlayer6.Name = "BtnPlayer6";
            this.BtnPlayer6.Size = new System.Drawing.Size(100, 100);
            this.BtnPlayer6.TabIndex = 7;
            this.BtnPlayer6.Tag = "6";
            this.BtnPlayer6.Text = "Player";
            this.BtnPlayer6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer6.UseVisualStyleBackColor = true;
            // 
            // BtnPlayer7
            // 
            this.BtnPlayer7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPlayer7.BackgroundImage")));
            this.BtnPlayer7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayer7.ForeColor = System.Drawing.Color.Black;
            this.BtnPlayer7.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer7.Image")));
            this.BtnPlayer7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer7.Location = new System.Drawing.Point(317, 114);
            this.BtnPlayer7.Name = "BtnPlayer7";
            this.BtnPlayer7.Size = new System.Drawing.Size(100, 100);
            this.BtnPlayer7.TabIndex = 8;
            this.BtnPlayer7.Tag = "7";
            this.BtnPlayer7.Text = "Player";
            this.BtnPlayer7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer7.UseVisualStyleBackColor = true;
            // 
            // BtnPlayer8
            // 
            this.BtnPlayer8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPlayer8.BackgroundImage")));
            this.BtnPlayer8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayer8.ForeColor = System.Drawing.Color.Black;
            this.BtnPlayer8.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer8.Image")));
            this.BtnPlayer8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer8.Location = new System.Drawing.Point(2, 219);
            this.BtnPlayer8.Name = "BtnPlayer8";
            this.BtnPlayer8.Size = new System.Drawing.Size(100, 100);
            this.BtnPlayer8.TabIndex = 9;
            this.BtnPlayer8.Tag = "8";
            this.BtnPlayer8.Text = "Player";
            this.BtnPlayer8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer8.UseVisualStyleBackColor = true;
            // 
            // BtnPlayer9
            // 
            this.BtnPlayer9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPlayer9.BackgroundImage")));
            this.BtnPlayer9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayer9.ForeColor = System.Drawing.Color.Black;
            this.BtnPlayer9.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer9.Image")));
            this.BtnPlayer9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer9.Location = new System.Drawing.Point(107, 219);
            this.BtnPlayer9.Name = "BtnPlayer9";
            this.BtnPlayer9.Size = new System.Drawing.Size(100, 100);
            this.BtnPlayer9.TabIndex = 10;
            this.BtnPlayer9.Tag = "9";
            this.BtnPlayer9.Text = "Player";
            this.BtnPlayer9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer9.UseVisualStyleBackColor = true;
            // 
            // BtnPlayer10
            // 
            this.BtnPlayer10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPlayer10.BackgroundImage")));
            this.BtnPlayer10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayer10.ForeColor = System.Drawing.Color.Black;
            this.BtnPlayer10.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer10.Image")));
            this.BtnPlayer10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer10.Location = new System.Drawing.Point(212, 219);
            this.BtnPlayer10.Name = "BtnPlayer10";
            this.BtnPlayer10.Size = new System.Drawing.Size(100, 100);
            this.BtnPlayer10.TabIndex = 11;
            this.BtnPlayer10.Tag = "10";
            this.BtnPlayer10.Text = "Player";
            this.BtnPlayer10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer10.UseVisualStyleBackColor = true;
            // 
            // BtnPlayer11
            // 
            this.BtnPlayer11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPlayer11.BackgroundImage")));
            this.BtnPlayer11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayer11.ForeColor = System.Drawing.Color.Black;
            this.BtnPlayer11.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer11.Image")));
            this.BtnPlayer11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer11.Location = new System.Drawing.Point(317, 219);
            this.BtnPlayer11.Name = "BtnPlayer11";
            this.BtnPlayer11.Size = new System.Drawing.Size(100, 100);
            this.BtnPlayer11.TabIndex = 12;
            this.BtnPlayer11.Tag = "11";
            this.BtnPlayer11.Text = "Player";
            this.BtnPlayer11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer11.UseVisualStyleBackColor = true;
            // 
            // BtnPlayer12
            // 
            this.BtnPlayer12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPlayer12.BackgroundImage")));
            this.BtnPlayer12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayer12.ForeColor = System.Drawing.Color.Black;
            this.BtnPlayer12.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer12.Image")));
            this.BtnPlayer12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer12.Location = new System.Drawing.Point(2, 324);
            this.BtnPlayer12.Name = "BtnPlayer12";
            this.BtnPlayer12.Size = new System.Drawing.Size(100, 100);
            this.BtnPlayer12.TabIndex = 13;
            this.BtnPlayer12.Tag = "12";
            this.BtnPlayer12.Text = "Player";
            this.BtnPlayer12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer12.UseVisualStyleBackColor = true;
            // 
            // BtnPlayer13
            // 
            this.BtnPlayer13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPlayer13.BackgroundImage")));
            this.BtnPlayer13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayer13.ForeColor = System.Drawing.Color.Black;
            this.BtnPlayer13.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer13.Image")));
            this.BtnPlayer13.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer13.Location = new System.Drawing.Point(107, 324);
            this.BtnPlayer13.Name = "BtnPlayer13";
            this.BtnPlayer13.Size = new System.Drawing.Size(100, 100);
            this.BtnPlayer13.TabIndex = 14;
            this.BtnPlayer13.Tag = "13";
            this.BtnPlayer13.Text = "Player";
            this.BtnPlayer13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer13.UseVisualStyleBackColor = true;
            // 
            // BtnPlayer14
            // 
            this.BtnPlayer14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPlayer14.BackgroundImage")));
            this.BtnPlayer14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayer14.ForeColor = System.Drawing.Color.Black;
            this.BtnPlayer14.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer14.Image")));
            this.BtnPlayer14.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer14.Location = new System.Drawing.Point(212, 324);
            this.BtnPlayer14.Name = "BtnPlayer14";
            this.BtnPlayer14.Size = new System.Drawing.Size(100, 100);
            this.BtnPlayer14.TabIndex = 15;
            this.BtnPlayer14.Tag = "14";
            this.BtnPlayer14.Text = "Player";
            this.BtnPlayer14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer14.UseVisualStyleBackColor = true;
            // 
            // BtnPlayer15
            // 
            this.BtnPlayer15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPlayer15.BackgroundImage")));
            this.BtnPlayer15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayer15.ForeColor = System.Drawing.Color.Black;
            this.BtnPlayer15.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer15.Image")));
            this.BtnPlayer15.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer15.Location = new System.Drawing.Point(317, 324);
            this.BtnPlayer15.Name = "BtnPlayer15";
            this.BtnPlayer15.Size = new System.Drawing.Size(100, 100);
            this.BtnPlayer15.TabIndex = 16;
            this.BtnPlayer15.Tag = "15";
            this.BtnPlayer15.Text = "Player";
            this.BtnPlayer15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer15.UseVisualStyleBackColor = true;
            // 
            // GBPlayers
            // 
            this.GBPlayers.BackColor = System.Drawing.Color.Transparent;
            this.GBPlayers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GBPlayers.Controls.Add(this.BtnPlayer15);
            this.GBPlayers.Controls.Add(this.BtnPlayer14);
            this.GBPlayers.Controls.Add(this.BtnPlayer13);
            this.GBPlayers.Controls.Add(this.BtnPlayer12);
            this.GBPlayers.Controls.Add(this.BtnPlayer3);
            this.GBPlayers.Controls.Add(this.BtnPlayer11);
            this.GBPlayers.Controls.Add(this.BtnPlayer2);
            this.GBPlayers.Controls.Add(this.BtnPlayer10);
            this.GBPlayers.Controls.Add(this.BtnPlayer1);
            this.GBPlayers.Controls.Add(this.BtnPlayer9);
            this.GBPlayers.Controls.Add(this.BtnPlayer0);
            this.GBPlayers.Controls.Add(this.BtnPlayer8);
            this.GBPlayers.Controls.Add(this.BtnPlayer7);
            this.GBPlayers.Controls.Add(this.BtnPlayer6);
            this.GBPlayers.Controls.Add(this.BtnPlayer5);
            this.GBPlayers.Controls.Add(this.BtnPlayer4);
            this.GBPlayers.ForeColor = System.Drawing.Color.Transparent;
            this.GBPlayers.Location = new System.Drawing.Point(3, -4);
            this.GBPlayers.Name = "GBPlayers";
            this.GBPlayers.Size = new System.Drawing.Size(419, 428);
            this.GBPlayers.TabIndex = 0;
            this.GBPlayers.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(425, 425);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 150);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(265, 500);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 79);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.SigOut_Click);
            // 
            // Btn_Join
            // 
            this.Btn_Join.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Join.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Join.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Join.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Join.Image")));
            this.Btn_Join.Location = new System.Drawing.Point(265, 425);
            this.Btn_Join.Name = "Btn_Join";
            this.Btn_Join.Size = new System.Drawing.Size(157, 69);
            this.Btn_Join.TabIndex = 13;
            this.Btn_Join.TabStop = false;
            this.Btn_Join.Click += new System.EventHandler(this.BtnJoin_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(425, 425);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(155, 152);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(728, 577);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BtnVote);
            this.Controls.Add(this.BtnAction);
            this.Controls.Add(this.GBAction);
            this.Controls.Add(this.Btn_Join);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TbChatInput);
            this.Controls.Add(this.TbChatBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GBStatus);
            this.Controls.Add(this.GBChat);
            this.Controls.Add(this.GBPlayers);
            this.Name = "MainForm";
            this.Text = "Werewolf Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.GBStatus.ResumeLayout(false);
            this.GBStatus.PerformLayout();
            this.GBPlayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Join)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GBChat;
        private System.Windows.Forms.TextBox TbChatInput;
        private System.Windows.Forms.TextBox TbChatBox;
        private System.Windows.Forms.GroupBox GBAction;
        private System.Windows.Forms.Button BtnVote;
        private System.Windows.Forms.GroupBox GBStatus;
        private System.Windows.Forms.Label LBTime;
        private System.Windows.Forms.Label LBDay;
        private System.Windows.Forms.Label LBPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAction;
        private System.Windows.Forms.Button BtnPlayer3;
        private System.Windows.Forms.Button BtnPlayer0;
        private System.Windows.Forms.Button BtnPlayer1;
        private System.Windows.Forms.Button BtnPlayer2;
        private System.Windows.Forms.Button BtnPlayer4;
        private System.Windows.Forms.Button BtnPlayer5;
        private System.Windows.Forms.Button BtnPlayer6;
        private System.Windows.Forms.Button BtnPlayer7;
        private System.Windows.Forms.Button BtnPlayer8;
        private System.Windows.Forms.Button BtnPlayer9;
        private System.Windows.Forms.Button BtnPlayer10;
        private System.Windows.Forms.Button BtnPlayer11;
        private System.Windows.Forms.Button BtnPlayer12;
        private System.Windows.Forms.Button BtnPlayer13;
        private System.Windows.Forms.Button BtnPlayer14;
        private System.Windows.Forms.Button BtnPlayer15;
        private System.Windows.Forms.GroupBox GBPlayers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Btn_Join;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

