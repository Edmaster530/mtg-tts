
namespace WinApp.Controls
{
    partial class Card
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BaseImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BaseImage)).BeginInit();
            this.SuspendLayout();
            // 
            // BaseImage
            // 
            this.BaseImage.ImageLocation = "";
            this.BaseImage.Location = new System.Drawing.Point(0, 0);
            this.BaseImage.Margin = new System.Windows.Forms.Padding(0);
            this.BaseImage.Name = "BaseImage";
            this.BaseImage.Size = new System.Drawing.Size(223, 311);
            this.BaseImage.TabIndex = 0;
            this.BaseImage.TabStop = false;
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BaseImage);
            this.MaximumSize = new System.Drawing.Size(223, 311);
            this.MinimumSize = new System.Drawing.Size(223, 311);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(223, 311);
            ((System.ComponentModel.ISupportInitialize)(this.BaseImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BaseImage;
    }
}
