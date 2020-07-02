namespace movingTokensDown2
{
    partial class StartPage
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
            this.lblWelcomeText = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcomeText
            // 
            this.lblWelcomeText.Font = new System.Drawing.Font("Corbel", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeText.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWelcomeText.Location = new System.Drawing.Point(-2, 46);
            this.lblWelcomeText.Name = "lblWelcomeText";
            this.lblWelcomeText.Size = new System.Drawing.Size(391, 231);
            this.lblWelcomeText.TabIndex = 0;
            this.lblWelcomeText.Text = "SOCIAL DISTANCING";
            this.lblWelcomeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(41, 313);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(280, 40);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(41, 405);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(280, 40);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "HELP";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(41, 451);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(280, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHighScores
            // 
            this.btnHighScores.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighScores.Location = new System.Drawing.Point(41, 359);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(280, 40);
            this.btnHighScores.TabIndex = 4;
            this.btnHighScores.Text = "HIGH SCORES";
            this.btnHighScores.UseVisualStyleBackColor = true;
            this.btnHighScores.Click += new System.EventHandler(this.btnHighScores_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(389, 761);
            this.ControlBox = false;
            this.Controls.Add(this.btnHighScores);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblWelcomeText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartPage";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeText;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHighScores;
    }
}