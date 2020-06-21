namespace movingTokensDown2
{
    partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.moveToken = new System.Windows.Forms.Timer(this.components);
            this.lblTest = new System.Windows.Forms.Label();
            this.timePlayed = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 385);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(210, 40);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // moveToken
            // 
            this.moveToken.Interval = 25;
            this.moveToken.Tick += new System.EventHandler(this.moveToken_Tick);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(194, 369);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(28, 13);
            this.lblTest.TabIndex = 1;
            this.lblTest.Text = "Test";
            // 
            // timePlayed
            // 
            this.timePlayed.Interval = 1000;
            this.timePlayed.Tick += new System.EventHandler(this.timePlayed_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 437);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnStart);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "TIME: 0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer moveToken;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Timer timePlayed;
    }
}

