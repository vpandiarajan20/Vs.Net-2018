﻿namespace S_i_m_o_n
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
            this.FirstButton = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.l1 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(99, 108);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(75, 23);
            this.FirstButton.TabIndex = 0;
            this.FirstButton.Text = "button1";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(93, 74);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(94, 20);
            this.b1.TabIndex = 1;
            this.b1.Text = "button1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(30, 176);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(35, 13);
            this.l1.TabIndex = 2;
            this.l1.Text = "label1";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(142, 185);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(94, 20);
            this.tb1.TabIndex = 3;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(36, 45);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(80, 17);
            this.cb1.TabIndex = 4;
            this.cb1.Text = "checkBox1";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.FirstButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.CheckBox cb1;
    }
}

