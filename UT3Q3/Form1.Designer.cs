namespace UT3Q3
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
            this.q1Text = new System.Windows.Forms.Label();
            this.q1Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(334, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Fill in this Form:\r\nThanks!";
            // 
            // q1Text
            // 
            this.q1Text.AutoSize = true;
            this.q1Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.q1Text.Location = new System.Drawing.Point(37, 112);
            this.q1Text.Name = "q1Text";
            this.q1Text.Size = new System.Drawing.Size(193, 16);
            this.q1Text.TabIndex = 1;
            this.q1Text.Text = "Question 1: What is your name?";
            // 
            // q1Box
            // 
            this.q1Box.BackColor = System.Drawing.Color.DimGray;
            this.q1Box.ForeColor = System.Drawing.Color.Yellow;
            this.q1Box.Location = new System.Drawing.Point(261, 109);
            this.q1Box.Name = "q1Box";
            this.q1Box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.q1Box.Size = new System.Drawing.Size(100, 22);
            this.q1Box.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.q1Box);
            this.Controls.Add(this.q1Text);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label q1Text;
        private System.Windows.Forms.TextBox q1Box;
    }
}

