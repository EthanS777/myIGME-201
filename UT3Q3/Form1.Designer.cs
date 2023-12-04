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
            this.q2Text = new System.Windows.Forms.Label();
            this.q2Box = new System.Windows.Forms.CheckedListBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.q3Text = new System.Windows.Forms.Label();
            this.q3Radio1 = new System.Windows.Forms.RadioButton();
            this.q3Radio2 = new System.Windows.Forms.RadioButton();
            this.q3Radio3 = new System.Windows.Forms.RadioButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(204, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Fill in this Form:\r\nThanks!";
            // 
            // q1Text
            // 
            this.q1Text.AutoSize = true;
            this.q1Text.ForeColor = System.Drawing.Color.White;
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
            // q2Text
            // 
            this.q2Text.AutoSize = true;
            this.q2Text.ForeColor = System.Drawing.Color.White;
            this.q2Text.Location = new System.Drawing.Point(37, 247);
            this.q2Text.Name = "q2Text";
            this.q2Text.Size = new System.Drawing.Size(183, 16);
            this.q2Text.TabIndex = 3;
            this.q2Text.Text = "Question 2: What is your age?";
            // 
            // q2Box
            // 
            this.q2Box.BackColor = System.Drawing.Color.Yellow;
            this.q2Box.FormattingEnabled = true;
            this.q2Box.Items.AddRange(new object[] {
            "<13",
            "13-17",
            "18-25",
            "26-49",
            "50-64",
            "65+"});
            this.q2Box.Location = new System.Drawing.Point(261, 227);
            this.q2Box.Name = "q2Box";
            this.q2Box.Size = new System.Drawing.Size(95, 72);
            this.q2Box.TabIndex = 6;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Yellow;
            this.submitButton.ForeColor = System.Drawing.Color.Red;
            this.submitButton.Location = new System.Drawing.Point(673, 427);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(137, 52);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            // 
            // q3Text
            // 
            this.q3Text.AutoSize = true;
            this.q3Text.ForeColor = System.Drawing.Color.White;
            this.q3Text.Location = new System.Drawing.Point(12, 380);
            this.q3Text.Name = "q3Text";
            this.q3Text.Size = new System.Drawing.Size(271, 16);
            this.q3Text.TabIndex = 8;
            this.q3Text.Text = "Question 3: What is your employment status?";
            // 
            // q3Radio1
            // 
            this.q3Radio1.AutoSize = true;
            this.q3Radio1.BackColor = System.Drawing.Color.Yellow;
            this.q3Radio1.Location = new System.Drawing.Point(307, 353);
            this.q3Radio1.Name = "q3Radio1";
            this.q3Radio1.Size = new System.Drawing.Size(144, 20);
            this.q3Radio1.TabIndex = 9;
            this.q3Radio1.TabStop = true;
            this.q3Radio1.Text = "Currently employed";
            this.q3Radio1.UseVisualStyleBackColor = false;
            // 
            // q3Radio2
            // 
            this.q3Radio2.AutoSize = true;
            this.q3Radio2.BackColor = System.Drawing.Color.Yellow;
            this.q3Radio2.Location = new System.Drawing.Point(307, 390);
            this.q3Radio2.Name = "q3Radio2";
            this.q3Radio2.Size = new System.Drawing.Size(119, 20);
            this.q3Radio2.TabIndex = 10;
            this.q3Radio2.TabStop = true;
            this.q3Radio2.Text = "Taking a break";
            this.q3Radio2.UseVisualStyleBackColor = false;
            // 
            // q3Radio3
            // 
            this.q3Radio3.AutoSize = true;
            this.q3Radio3.BackColor = System.Drawing.Color.Yellow;
            this.q3Radio3.Location = new System.Drawing.Point(309, 427);
            this.q3Radio3.Name = "q3Radio3";
            this.q3Radio3.Size = new System.Drawing.Size(163, 20);
            this.q3Radio3.TabIndex = 11;
            this.q3Radio3.TabStop = true;
            this.q3Radio3.Text = "Never been employed";
            this.q3Radio3.UseVisualStyleBackColor = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(510, 6);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(555, 324);
            this.webBrowser1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1077, 548);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.q3Radio3);
            this.Controls.Add(this.q3Radio2);
            this.Controls.Add(this.q3Radio1);
            this.Controls.Add(this.q3Text);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.q2Box);
            this.Controls.Add(this.q2Text);
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
        private System.Windows.Forms.Label q2Text;
        private System.Windows.Forms.CheckedListBox q2Box;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label q3Text;
        private System.Windows.Forms.RadioButton q3Radio1;
        private System.Windows.Forms.RadioButton q3Radio2;
        private System.Windows.Forms.RadioButton q3Radio3;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

