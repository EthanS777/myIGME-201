namespace PE17
{
    partial class GameForm
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
            this.guessBox = new System.Windows.Forms.TextBox();
            this.guessText = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.outputText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guessBox
            // 
            this.guessBox.Location = new System.Drawing.Point(264, 72);
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(100, 22);
            this.guessBox.TabIndex = 0;
            // 
            // guessText
            // 
            this.guessText.AutoSize = true;
            this.guessText.Location = new System.Drawing.Point(198, 75);
            this.guessText.Name = "guessText";
            this.guessText.Size = new System.Drawing.Size(49, 16);
            this.guessText.TabIndex = 1;
            this.guessText.Text = "Guess:";
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(231, 123);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(103, 23);
            this.guessButton.TabIndex = 2;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Location = new System.Drawing.Point(0, 228);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(616, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(54, 228);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(459, 22);
            this.progressBar.TabIndex = 4;
            // 
            // timerTime
            // 
            this.timerTime.Interval = 500;
            // 
            // outputText
            // 
            this.outputText.AutoSize = true;
            this.outputText.Location = new System.Drawing.Point(198, 182);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(110, 16);
            this.outputText.TabIndex = 5;
            this.outputText.Text = "Output Feedback";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 250);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.guessText);
            this.Controls.Add(this.guessBox);
            this.Name = "GameForm";
            this.Text = "Game Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox guessBox;
        private System.Windows.Forms.Label guessText;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label outputText;
    }
}