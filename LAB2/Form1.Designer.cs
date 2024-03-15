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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 76);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Form1_Load);
            // 
            // Method1
            // 
            this.Method1.BackColor = System.Drawing.Color.Honeydew;
            this.Method1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Method1.Location = new System.Drawing.Point(0, 137);
            this.Method1.Name = "Method1";
            this.Method1.Size = new System.Drawing.Size(200, 64);
            this.Method1.TabIndex = 2;
            this.Method1.Text = "Greedy Algorithm";
            this.Method1.UseVisualStyleBackColor = false;
            this.Method1.Click += new System.EventHandler(this.Method1_Click);
            // 
            // Method2
            // 
            this.Method2.BackColor = System.Drawing.Color.Honeydew;
            this.Method2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Method2.Location = new System.Drawing.Point(0, 74);
            this.Method2.Name = "Method2";
            this.Method2.Size = new System.Drawing.Size(200, 64);
            this.Method2.TabIndex = 3;
            this.Method2.Text = "Backtracking Algorithm";
            this.Method2.UseVisualStyleBackColor = false;
            this.Method2.Click += new System.EventHandler(this.Method2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Method1);
            this.panel1.Controls.Add(this.Method2);
            this.panel1.Location = new System.Drawing.Point(31, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 204);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 75);
            this.button1.TabIndex = 6;
            this.button1.Text = "Algorithms";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LAB2.Properties.Resources.photo_2024_03_15_20_43_59;
            this.pictureBox1.Location = new System.Drawing.Point(280, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(708, 395);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
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
        private System.Windows.Forms.Button Method1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Method2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

