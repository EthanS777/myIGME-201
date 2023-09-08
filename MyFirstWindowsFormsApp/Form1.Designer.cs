namespace MyFirstWindowsFormsApp
{
    partial class HoudiniForm
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
            this.houdiniPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.houdiniPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // houdiniPictureBox
            // 
            this.houdiniPictureBox.Location = new System.Drawing.Point(39, 35);
            this.houdiniPictureBox.Name = "houdiniPictureBox";
            this.houdiniPictureBox.Size = new System.Drawing.Size(225, 285);
            this.houdiniPictureBox.TabIndex = 0;
            this.houdiniPictureBox.TabStop = false;
            this.houdiniPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HoudiniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 337);
            this.Controls.Add(this.houdiniPictureBox);
            this.Name = "HoudiniForm";
            this.Text = "Houdini";
            ((System.ComponentModel.ISupportInitialize)(this.houdiniPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox houdiniPictureBox;
    }
}

