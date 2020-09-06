namespace MateuszBartkowiakHomework2
{
    partial class End
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(End));
            this.pictureBoxReturn = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // return_pb
            // 
            this.pictureBoxReturn.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxReturn.BackgroundImage = global::MateuszBartkowiakHomework2.Properties.Resources.returnMenu;
            this.pictureBoxReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxReturn.Location = new System.Drawing.Point(801, 414);
            this.pictureBoxReturn.Name = "return_pb";
            this.pictureBoxReturn.Size = new System.Drawing.Size(106, 85);
            this.pictureBoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxReturn.TabIndex = 1;
            this.pictureBoxReturn.TabStop = false;
            this.pictureBoxReturn.Click += new System.EventHandler(this.PictureBoxReturn_Click);
            // 
            // end_pb
            // 
            this.pictureBoxEnd.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxEnd.Location = new System.Drawing.Point(148, 12);
            this.pictureBoxEnd.Name = "end_pb";
            this.pictureBoxEnd.Size = new System.Drawing.Size(627, 487);
            this.pictureBoxEnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEnd.TabIndex = 2;
            this.pictureBoxEnd.TabStop = false;
            // 
            // End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MateuszBartkowiakHomework2.Properties.Resources.endBg;
            this.ClientSize = new System.Drawing.Size(919, 511);
            this.Controls.Add(this.pictureBoxEnd);
            this.Controls.Add(this.pictureBoxReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "End";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "End";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxReturn;
        private System.Windows.Forms.PictureBox pictureBoxEnd;
    }
}