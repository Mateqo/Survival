namespace MateuszBartkowiakHomework2
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pictureBoxAmmunition = new System.Windows.Forms.PictureBox();
            this.labelAmmo = new System.Windows.Forms.Label();
            this.labelHealth = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.labelAmunnition = new System.Windows.Forms.Label();
            this.pictureBoxReload = new System.Windows.Forms.PictureBox();
            this.labelReload = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.progressBarBossHealth = new System.Windows.Forms.ProgressBar();
            this.labelBossHealth = new System.Windows.Forms.Label();
            this.pictureBoxSound = new System.Windows.Forms.PictureBox();
            this.progressBarHealth = new System.Windows.Forms.ProgressBar();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxStart = new System.Windows.Forms.PictureBox();
            this.labelBossInfo = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelLvl = new System.Windows.Forms.Label();
            this.buttonNextLvl = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelCompleted = new System.Windows.Forms.Label();
            this.timerCheckSave = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAmmunition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAmmunition
            // 
            this.pictureBoxAmmunition.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAmmunition.BackgroundImage = global::MateuszBartkowiakHomework2.Properties.Resources.ammunition;
            this.pictureBoxAmmunition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAmmunition.Location = new System.Drawing.Point(326, 42);
            this.pictureBoxAmmunition.Name = "pictureBoxAmmunition";
            this.pictureBoxAmmunition.Size = new System.Drawing.Size(44, 38);
            this.pictureBoxAmmunition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAmmunition.TabIndex = 3;
            this.pictureBoxAmmunition.TabStop = false;
            // 
            // labelAmmo
            // 
            this.labelAmmo.AutoSize = true;
            this.labelAmmo.BackColor = System.Drawing.Color.Transparent;
            this.labelAmmo.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmmo.Location = new System.Drawing.Point(279, 50);
            this.labelAmmo.Name = "labelAmmo";
            this.labelAmmo.Size = new System.Drawing.Size(41, 30);
            this.labelAmmo.TabIndex = 4;
            this.labelAmmo.Text = "10";
            // 
            // labelHealth
            // 
            this.labelHealth.AutoSize = true;
            this.labelHealth.BackColor = System.Drawing.Color.Transparent;
            this.labelHealth.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHealth.Location = new System.Drawing.Point(12, 9);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(171, 30);
            this.labelHealth.TabIndex = 6;
            this.labelHealth.Text = "Health: 100%";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.BackColor = System.Drawing.Color.Transparent;
            this.labelText.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(275, 9);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(176, 30);
            this.labelText.TabIndex = 7;
            this.labelText.Text = "Ammunition:";
            // 
            // labelAmunnition
            // 
            this.labelAmunnition.AutoSize = true;
            this.labelAmunnition.BackColor = System.Drawing.Color.Transparent;
            this.labelAmunnition.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmunnition.Location = new System.Drawing.Point(388, 50);
            this.labelAmunnition.Name = "labelAmunnition";
            this.labelAmunnition.Size = new System.Drawing.Size(48, 30);
            this.labelAmunnition.TabIndex = 8;
            this.labelAmunnition.Text = "5/5";
            // 
            // pictureBoxReload
            // 
            this.pictureBoxReload.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxReload.Location = new System.Drawing.Point(484, 78);
            this.pictureBoxReload.Name = "pictureBoxReload";
            this.pictureBoxReload.Size = new System.Drawing.Size(75, 50);
            this.pictureBoxReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxReload.TabIndex = 9;
            this.pictureBoxReload.TabStop = false;
            this.pictureBoxReload.Visible = false;
            // 
            // labelReload
            // 
            this.labelReload.AutoSize = true;
            this.labelReload.BackColor = System.Drawing.Color.Transparent;
            this.labelReload.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReload.ForeColor = System.Drawing.Color.Crimson;
            this.labelReload.Location = new System.Drawing.Point(279, 88);
            this.labelReload.Name = "labelReload";
            this.labelReload.Size = new System.Drawing.Size(199, 30);
            this.labelReload.TabIndex = 10;
            this.labelReload.Text = "Reload Press R";
            this.labelReload.Visible = false;
            // 
            // timerGame
            // 
            this.timerGame.Tick += new System.EventHandler(this.TimerGame_Tick);
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxInfo.BackgroundImage = global::MateuszBartkowiakHomework2.Properties.Resources.info;
            this.pictureBoxInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxInfo.Location = new System.Drawing.Point(1051, 15);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(66, 57);
            this.pictureBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInfo.TabIndex = 13;
            this.pictureBoxInfo.TabStop = false;
            this.pictureBoxInfo.Click += new System.EventHandler(this.PictureBoxInfo_Click);
            // 
            // pictureBoxBossHealth
            // 
            this.progressBarBossHealth.BackColor = System.Drawing.Color.Silver;
            this.progressBarBossHealth.ForeColor = System.Drawing.Color.DarkRed;
            this.progressBarBossHealth.Location = new System.Drawing.Point(17, 116);
            this.progressBarBossHealth.Name = "pictureBoxBossHealth";
            this.progressBarBossHealth.Size = new System.Drawing.Size(189, 27);
            this.progressBarBossHealth.TabIndex = 15;
            this.progressBarBossHealth.Value = 100;
            this.progressBarBossHealth.Visible = false;
            // 
            // labelBossHealth
            // 
            this.labelBossHealth.AutoSize = true;
            this.labelBossHealth.BackColor = System.Drawing.Color.Transparent;
            this.labelBossHealth.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBossHealth.Location = new System.Drawing.Point(19, 83);
            this.labelBossHealth.Name = "labelBossHealth";
            this.labelBossHealth.Size = new System.Drawing.Size(141, 30);
            this.labelBossHealth.TabIndex = 16;
            this.labelBossHealth.Text = "Boss: 100%";
            this.labelBossHealth.Visible = false;
            // 
            // pictureBoxSound
            // 
            this.pictureBoxSound.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSound.Location = new System.Drawing.Point(979, 15);
            this.pictureBoxSound.Name = "pictureBoxSound";
            this.pictureBoxSound.Size = new System.Drawing.Size(66, 57);
            this.pictureBoxSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSound.TabIndex = 18;
            this.pictureBoxSound.TabStop = false;
            this.pictureBoxSound.Click += new System.EventHandler(this.PictureBoxSound_Click);
            // 
            // pictureBoxHealth
            // 
            this.progressBarHealth.BackColor = System.Drawing.Color.Silver;
            this.progressBarHealth.ForeColor = System.Drawing.Color.DarkRed;
            this.progressBarHealth.Location = new System.Drawing.Point(17, 50);
            this.progressBarHealth.Name = "pictureBoxHealth";
            this.progressBarHealth.Size = new System.Drawing.Size(189, 27);
            this.progressBarHealth.TabIndex = 5;
            this.progressBarHealth.Value = 100;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxExit.BackgroundImage = global::MateuszBartkowiakHomework2.Properties.Resources.exit;
            this.pictureBoxExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Location = new System.Drawing.Point(1129, 15);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(59, 57);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 20;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.PictureBoxExit_Click);
            // 
            // pictureBoxStart
            // 
            this.pictureBoxStart.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStart.BackgroundImage = global::MateuszBartkowiakHomework2.Properties.Resources.start;
            this.pictureBoxStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxStart.Location = new System.Drawing.Point(979, 88);
            this.pictureBoxStart.Name = "pictureBoxStart";
            this.pictureBoxStart.Size = new System.Drawing.Size(209, 96);
            this.pictureBoxStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStart.TabIndex = 21;
            this.pictureBoxStart.TabStop = false;
            this.pictureBoxStart.Click += new System.EventHandler(this.PictureBoxStart_Click);
            // 
            // labelBossInfo
            // 
            this.labelBossInfo.AutoSize = true;
            this.labelBossInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelBossInfo.Font = new System.Drawing.Font("Ravie", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBossInfo.Location = new System.Drawing.Point(620, 80);
            this.labelBossInfo.Name = "labelBossInfo";
            this.labelBossInfo.Size = new System.Drawing.Size(0, 63);
            this.labelBossInfo.TabIndex = 22;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(612, 55);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(184, 40);
            this.labelScore.TabIndex = 24;
            this.labelScore.Text = "Score: 0";
            // 
            // labelLvl
            // 
            this.labelLvl.AutoSize = true;
            this.labelLvl.BackColor = System.Drawing.Color.Transparent;
            this.labelLvl.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLvl.Location = new System.Drawing.Point(647, 15);
            this.labelLvl.Name = "labelLvl";
            this.labelLvl.Size = new System.Drawing.Size(122, 40);
            this.labelLvl.TabIndex = 25;
            this.labelLvl.Text = "Lvl: 1";
            // 
            // buttonNextLvl
            // 
            this.buttonNextLvl.AutoSize = true;
            this.buttonNextLvl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonNextLvl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNextLvl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNextLvl.ForeColor = System.Drawing.Color.Black;
            this.buttonNextLvl.Location = new System.Drawing.Point(353, 352);
            this.buttonNextLvl.Name = "buttonNextLvl";
            this.buttonNextLvl.Size = new System.Drawing.Size(313, 97);
            this.buttonNextLvl.TabIndex = 26;
            this.buttonNextLvl.Text = "Next level";
            this.buttonNextLvl.UseVisualStyleBackColor = false;
            this.buttonNextLvl.Visible = false;
            this.buttonNextLvl.Click += new System.EventHandler(this.ButtonNextLvl_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = true;
            this.buttonSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Location = new System.Drawing.Point(686, 352);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(210, 97);
            this.buttonSave.TabIndex = 27;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // labelCompleted
            // 
            this.labelCompleted.AutoSize = true;
            this.labelCompleted.BackColor = System.Drawing.Color.Transparent;
            this.labelCompleted.Font = new System.Drawing.Font("Ravie", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompleted.Location = new System.Drawing.Point(269, 272);
            this.labelCompleted.Name = "labelCompleted";
            this.labelCompleted.Size = new System.Drawing.Size(720, 63);
            this.labelCompleted.TabIndex = 28;
            this.labelCompleted.Text = "You completed level 1";
            this.labelCompleted.Visible = false;
            // 
            // timerCheckSave
            // 
            this.timerCheckSave.Enabled = true;
            this.timerCheckSave.Tick += new System.EventHandler(this.TimerCheckSave_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MateuszBartkowiakHomework2.Properties.Resources.gameBg;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.labelCompleted);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNextLvl);
            this.Controls.Add(this.labelLvl);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelBossInfo);
            this.Controls.Add(this.pictureBoxStart);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.progressBarBossHealth);
            this.Controls.Add(this.progressBarHealth);
            this.Controls.Add(this.labelBossHealth);
            this.Controls.Add(this.pictureBoxSound);
            this.Controls.Add(this.pictureBoxInfo);
            this.Controls.Add(this.labelReload);
            this.Controls.Add(this.pictureBoxReload);
            this.Controls.Add(this.labelAmunnition);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelHealth);
            this.Controls.Add(this.labelAmmo);
            this.Controls.Add(this.pictureBoxAmmunition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Survival";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAmmunition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxAmmunition;
        private System.Windows.Forms.Label labelAmmo;
        private System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelAmunnition;
        private System.Windows.Forms.PictureBox pictureBoxReload;
        private System.Windows.Forms.Label labelReload;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.PictureBox pictureBoxInfo;
        private System.Windows.Forms.ProgressBar progressBarBossHealth;
        private System.Windows.Forms.Label labelBossHealth;
        private System.Windows.Forms.PictureBox pictureBoxSound;
        private System.Windows.Forms.ProgressBar progressBarHealth;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.PictureBox pictureBoxStart;
        private System.Windows.Forms.Label labelBossInfo;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelLvl;
        private System.Windows.Forms.Button buttonNextLvl;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelCompleted;
        private System.Windows.Forms.Timer timerCheckSave;
    }
}

