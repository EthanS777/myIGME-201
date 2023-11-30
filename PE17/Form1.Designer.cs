namespace PE17
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
            this.enterText = new System.Windows.Forms.Label();
            this.lowNumText = new System.Windows.Forms.Label();
            this.highNumText = new System.Windows.Forms.Label();
            this.lowTextBox = new System.Windows.Forms.TextBox();
            this.highTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterText
            // 
            this.enterText.AutoSize = true;
            this.enterText.Location = new System.Drawing.Point(79, 28);
            this.enterText.Name = "enterText";
            this.enterText.Size = new System.Drawing.Size(200, 16);
            this.enterText.TabIndex = 0;
            this.enterText.Text = "Enter Range of Values to Guess ";
            // 
            // lowNumText
            // 
            this.lowNumText.AutoSize = true;
            this.lowNumText.Location = new System.Drawing.Point(25, 69);
            this.lowNumText.Name = "lowNumText";
            this.lowNumText.Size = new System.Drawing.Size(85, 16);
            this.lowNumText.TabIndex = 1;
            this.lowNumText.Text = "Low Number:";
            // 
            // highNumText
            // 
            this.highNumText.AutoSize = true;
            this.highNumText.Location = new System.Drawing.Point(21, 118);
            this.highNumText.Name = "highNumText";
            this.highNumText.Size = new System.Drawing.Size(89, 16);
            this.highNumText.TabIndex = 2;
            this.highNumText.Text = "High Number:";
            // 
            // lowTextBox
            // 
            this.lowTextBox.Location = new System.Drawing.Point(137, 66);
            this.lowTextBox.Name = "lowTextBox";
            this.lowTextBox.Size = new System.Drawing.Size(100, 22);
            this.lowTextBox.TabIndex = 3;
            // 
            // highTextBox
            // 
            this.highTextBox.Location = new System.Drawing.Point(137, 118);
            this.highTextBox.Name = "highTextBox";
            this.highTextBox.Size = new System.Drawing.Size(100, 22);
            this.highTextBox.TabIndex = 4;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(102, 161);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 196);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.highTextBox);
            this.Controls.Add(this.lowTextBox);
            this.Controls.Add(this.highNumText);
            this.Controls.Add(this.lowNumText);
            this.Controls.Add(this.enterText);
            this.Name = "Form1";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterText;
        private System.Windows.Forms.Label lowNumText;
        private System.Windows.Forms.Label highNumText;
        private System.Windows.Forms.TextBox lowTextBox;
        private System.Windows.Forms.TextBox highTextBox;
        private System.Windows.Forms.Button startButton;
    }
}

