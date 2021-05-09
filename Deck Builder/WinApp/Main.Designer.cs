
namespace WinApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.DoSearch = new System.Windows.Forms.Button();
            this.CardLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(12, 12);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(660, 23);
            this.SearchBox.TabIndex = 0;
            // 
            // DoSearch
            // 
            this.DoSearch.Location = new System.Drawing.Point(678, 12);
            this.DoSearch.Name = "DoSearch";
            this.DoSearch.Size = new System.Drawing.Size(110, 23);
            this.DoSearch.TabIndex = 1;
            this.DoSearch.Text = "Search";
            this.DoSearch.UseVisualStyleBackColor = true;
            this.DoSearch.Click += new System.EventHandler(this.DoSearch_Click);
            // 
            // CardLayout
            // 
            this.CardLayout.AutoScroll = true;
            this.CardLayout.Location = new System.Drawing.Point(12, 41);
            this.CardLayout.Name = "CardLayout";
            this.CardLayout.Size = new System.Drawing.Size(776, 397);
            this.CardLayout.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CardLayout);
            this.Controls.Add(this.DoSearch);
            this.Controls.Add(this.SearchBox);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button DoSearch;
        private System.Windows.Forms.FlowLayoutPanel CardLayout;
    }
}

