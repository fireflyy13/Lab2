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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            this.label1 = new System.Windows.Forms.Label();
            this.Method1 = new System.Windows.Forms.Button();
            this.Method2 = new System.Windows.Forms.Button();
            this.SuspendLayout();

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

            this.Method2.Location = new System.Drawing.Point(70, 152);
            this.Method2.Name = "Method2";
            this.Method2.Size = new System.Drawing.Size(242, 51);
            this.Method2.TabIndex = 3;
            this.Method2.Text = "Chromatic Number Method";
            this.Method2.UseVisualStyleBackColor = true;
            this.Method2.Click += new System.EventHandler(this.Method2_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      
            this.Controls.Add(this.Method1);
            this.Controls.Add(this.Method2);        
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button Method1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Method2;
    }
}

