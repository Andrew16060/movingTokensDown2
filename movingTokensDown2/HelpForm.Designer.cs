namespace movingTokensDown2
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHelpInformation = new System.Windows.Forms.Label();
            this.pbMoveHelpImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInfoHelp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoveHelpImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(537, 709);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(280, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHelpInformation
            // 
            this.lblHelpInformation.AutoSize = true;
            this.lblHelpInformation.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpInformation.ForeColor = System.Drawing.Color.White;
            this.lblHelpInformation.Location = new System.Drawing.Point(8, 196);
            this.lblHelpInformation.Name = "lblHelpInformation";
            this.lblHelpInformation.Size = new System.Drawing.Size(634, 84);
            this.lblHelpInformation.TabIndex = 5;
            this.lblHelpInformation.Text = "HOW TO PLAY:\r\n\r\nUse \'A\' and \'D\' to move left and right respectively.\r\nThe green ";
            // 
            // pbMoveHelpImage
            // 
            this.pbMoveHelpImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMoveHelpImage.Image = ((System.Drawing.Image)(resources.GetObject("pbMoveHelpImage.Image")));
            this.pbMoveHelpImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbMoveHelpImage.InitialImage")));
            this.pbMoveHelpImage.Location = new System.Drawing.Point(12, 321);
            this.pbMoveHelpImage.Name = "pbMoveHelpImage";
            this.pbMoveHelpImage.Size = new System.Drawing.Size(404, 211);
            this.pbMoveHelpImage.TabIndex = 6;
            this.pbMoveHelpImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 538);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 211);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblInfoHelp
            // 
            this.lblInfoHelp.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoHelp.ForeColor = System.Drawing.Color.White;
            this.lblInfoHelp.Location = new System.Drawing.Point(12, 18);
            this.lblInfoHelp.Name = "lblInfoHelp";
            this.lblInfoHelp.Size = new System.Drawing.Size(805, 168);
            this.lblInfoHelp.TabIndex = 8;
            this.lblInfoHelp.Text = resources.GetString("lblInfoHelp.Text");
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(829, 761);
            this.ControlBox = false;
            this.Controls.Add(this.lblInfoHelp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbMoveHelpImage);
            this.Controls.Add(this.lblHelpInformation);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbMoveHelpImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHelpInformation;
        private System.Windows.Forms.PictureBox pbMoveHelpImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInfoHelp;
    }
}