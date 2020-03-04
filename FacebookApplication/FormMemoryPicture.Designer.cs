namespace FacebookApplication
{
    public partial class FormMemoryPicture
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
            this.PictureBoxMemory = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMemory)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMemory
            // 
            this.PictureBoxMemory.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxMemory.Name = "pictureBoxMemory";
            this.PictureBoxMemory.Size = new System.Drawing.Size(260, 237);
            this.PictureBoxMemory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxMemory.TabIndex = 0;
            this.PictureBoxMemory.TabStop = false;
            // 
            // MemoryPictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.PictureBoxMemory);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MemoryPictureForm";
            this.Text = "Your memory";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMemory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox PictureBoxMemory;
    }
}