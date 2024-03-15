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
            this.Method1 = new System.Windows.Forms.Button();
            this.Method2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            // Method1
            // 
            this.Method1.Location = new System.Drawing.Point(70, 96);
            this.Method1.Name = "Method1";
            this.Method1.Size = new System.Drawing.Size(242, 50);
            this.Method1.TabIndex = 2;
            this.Method1.Text = "Greedy Algorithm";
            this.Method1.UseVisualStyleBackColor = true;
            this.Method1.Click += new System.EventHandler(this.Method1_Click);
            // 
            // Method2
            // 
            this.Method2.Location = new System.Drawing.Point(70, 152);
            this.Method2.Name = "Method2";
            this.Method2.Size = new System.Drawing.Size(242, 51);
            this.Method2.TabIndex = 3;
            this.Method2.Text = "Backtracking Algorithm";
            this.Method2.UseVisualStyleBackColor = true;
            this.Method2.Click += new System.EventHandler(this.Method2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LAB2.Properties.Resources.photo_2024_03_09_18_59_52;
            this.pictureBox1.Location = new System.Drawing.Point(353, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(823, 659);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1043, 701);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Method1);
            this.Controls.Add(this.Method2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Method1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Method2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

