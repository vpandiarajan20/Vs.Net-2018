namespace SIMON1
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
            this.bGreen = new System.Windows.Forms.Button();
            this.bRed = new System.Windows.Forms.Button();
            this.bYellow = new System.Windows.Forms.Button();
            this.bBlue = new System.Windows.Forms.Button();
            this.bstart = new System.Windows.Forms.Button();
            this.LDisplayScore = new System.Windows.Forms.Label();
            this.lScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bGreen
            // 
            this.bGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bGreen.Location = new System.Drawing.Point(41, 43);
            this.bGreen.Name = "bGreen";
            this.bGreen.Size = new System.Drawing.Size(107, 44);
            this.bGreen.TabIndex = 0;
            this.bGreen.UseVisualStyleBackColor = false;
            this.bGreen.Click += new System.EventHandler(this.bgreen_Click);
            // 
            // bRed
            // 
            this.bRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bRed.Location = new System.Drawing.Point(244, 43);
            this.bRed.Name = "bRed";
            this.bRed.Size = new System.Drawing.Size(85, 44);
            this.bRed.TabIndex = 1;
            this.bRed.UseVisualStyleBackColor = false;
            this.bRed.Click += new System.EventHandler(this.bred_Click);
            // 
            // bYellow
            // 
            this.bYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bYellow.Location = new System.Drawing.Point(41, 152);
            this.bYellow.Name = "bYellow";
            this.bYellow.Size = new System.Drawing.Size(107, 51);
            this.bYellow.TabIndex = 2;
            this.bYellow.UseVisualStyleBackColor = false;
            this.bYellow.Click += new System.EventHandler(this.byellow_Click);
            // 
            // bBlue
            // 
            this.bBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bBlue.Location = new System.Drawing.Point(244, 152);
            this.bBlue.Name = "bBlue";
            this.bBlue.Size = new System.Drawing.Size(85, 51);
            this.bBlue.TabIndex = 3;
            this.bBlue.UseVisualStyleBackColor = false;
            this.bBlue.Click += new System.EventHandler(this.bblue_Click);
            // 
            // bstart
            // 
            this.bstart.Location = new System.Drawing.Point(100, 221);
            this.bstart.Name = "bstart";
            this.bstart.Size = new System.Drawing.Size(79, 29);
            this.bstart.TabIndex = 4;
            this.bstart.Text = "button1";
            this.bstart.UseVisualStyleBackColor = true;
            this.bstart.Click += new System.EventHandler(this.bstart_Click);
            // 
            // LDisplayScore
            // 
            this.LDisplayScore.AutoSize = true;
            this.LDisplayScore.Location = new System.Drawing.Point(110, 18);
            this.LDisplayScore.Name = "LDisplayScore";
            this.LDisplayScore.Size = new System.Drawing.Size(38, 13);
            this.LDisplayScore.TabIndex = 5;
            this.LDisplayScore.Text = "Score:";
            // 
            // lScore
            // 
            this.lScore.AutoSize = true;
            this.lScore.Location = new System.Drawing.Point(241, 18);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(13, 13);
            this.lScore.TabIndex = 6;
            this.lScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 262);
            this.Controls.Add(this.lScore);
            this.Controls.Add(this.LDisplayScore);
            this.Controls.Add(this.bstart);
            this.Controls.Add(this.bBlue);
            this.Controls.Add(this.bYellow);
            this.Controls.Add(this.bRed);
            this.Controls.Add(this.bGreen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bGreen;
        private System.Windows.Forms.Button bRed;
        private System.Windows.Forms.Button bYellow;
        private System.Windows.Forms.Button bBlue;
        private System.Windows.Forms.Button bstart;
        private System.Windows.Forms.Label LDisplayScore;
        private System.Windows.Forms.Label lScore;
    }
}

