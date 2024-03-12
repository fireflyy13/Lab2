using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LAB2
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
            this.label1 = new System.Windows.Forms.Label();
            this.Method2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Algorithms = new System.Windows.Forms.Button();
            this.Method1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // Method2
            // 
            this.Method2.BackColor = System.Drawing.Color.Honeydew;
            this.Method2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Method2.Location = new System.Drawing.Point(0, 81);
            this.Method2.Name = "Method2";
            this.Method2.Size = new System.Drawing.Size(261, 60);
            this.Method2.TabIndex = 3;
            this.Method2.Text = "Backtracking Algorithm";
            this.Method2.UseVisualStyleBackColor = false;
            this.Method2.Click += new System.EventHandler(this.Method2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.Algorithms);
            this.panel1.Controls.Add(this.Method2);
            this.panel1.Controls.Add(this.Method1);
            this.panel1.Location = new System.Drawing.Point(36, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 197);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Algorithms
            // 
            this.Algorithms.BackColor = System.Drawing.Color.CadetBlue;
            this.Algorithms.Dock = System.Windows.Forms.DockStyle.Top;
            this.Algorithms.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Algorithms.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Algorithms.Location = new System.Drawing.Point(0, 0);
            this.Algorithms.Name = "Algorithms";
            this.Algorithms.Size = new System.Drawing.Size(261, 85);
            this.Algorithms.TabIndex = 6;
            this.Algorithms.Text = "Algorithms";
            this.Algorithms.UseVisualStyleBackColor = false;
            this.Algorithms.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Method1
            // 
            this.Method1.BackColor = System.Drawing.Color.Honeydew;
            this.Method1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Method1.Location = new System.Drawing.Point(0, 138);
            this.Method1.Name = "Method1";
            this.Method1.Size = new System.Drawing.Size(261, 60);
            this.Method1.TabIndex = 2;
            this.Method1.Text = "Greedy Algorithm";
            this.Method1.UseVisualStyleBackColor = false;
            this.Method1.Click += new System.EventHandler(this.Method1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LAB2.Properties.Resources.Untitled_Diagram__2_;
            this.pictureBox1.Location = new System.Drawing.Point(336, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 580);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1043, 701);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Method2;
        private Panel panel1;
        private Button Algorithms;
        private Button Method1;
        private PictureBox pictureBox1;
    }
}

