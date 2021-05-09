
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
            this.DeckLabel = new System.Windows.Forms.Label();
            this.DoExport = new System.Windows.Forms.Button();
            this.DeckList = new System.Windows.Forms.ListView();
            this.CardName = new System.Windows.Forms.ColumnHeader();
            this.CardCost = new System.Windows.Forms.ColumnHeader();
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
            // DeckLabel
            // 
            this.DeckLabel.AutoSize = true;
            this.DeckLabel.Location = new System.Drawing.Point(794, 15);
            this.DeckLabel.Name = "DeckLabel";
            this.DeckLabel.Size = new System.Drawing.Size(33, 15);
            this.DeckLabel.TabIndex = 4;
            this.DeckLabel.Text = "Deck";
            // 
            // DoExport
            // 
            this.DoExport.Location = new System.Drawing.Point(905, 11);
            this.DoExport.Name = "DoExport";
            this.DoExport.Size = new System.Drawing.Size(110, 23);
            this.DoExport.TabIndex = 5;
            this.DoExport.Text = "Export";
            this.DoExport.UseVisualStyleBackColor = true;
            this.DoExport.Click += new System.EventHandler(this.DoExport_Click);
            // 
            // DeckList
            // 
            this.DeckList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CardName,
            this.CardCost});
            this.DeckList.HideSelection = false;
            this.DeckList.Location = new System.Drawing.Point(794, 41);
            this.DeckList.Name = "DeckList";
            this.DeckList.Size = new System.Drawing.Size(221, 397);
            this.DeckList.TabIndex = 6;
            this.DeckList.UseCompatibleStateImageBehavior = false;
            this.DeckList.View = System.Windows.Forms.View.Details;
            // 
            // CardName
            // 
            this.CardName.Text = "Name";
            this.CardName.Width = 120;
            // 
            // CardCost
            // 
            this.CardCost.Text = "Mana Cost";
            this.CardCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CardCost.Width = 90;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 450);
            this.Controls.Add(this.DeckList);
            this.Controls.Add(this.DoExport);
            this.Controls.Add(this.DeckLabel);
            this.Controls.Add(this.CardLayout);
            this.Controls.Add(this.DoSearch);
            this.Controls.Add(this.SearchBox);
            this.Name = "Main";
            this.Text = "MTG to TTS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button DoSearch;
        private System.Windows.Forms.FlowLayoutPanel CardLayout;
        private System.Windows.Forms.Label DeckLabel;
        private System.Windows.Forms.Button DoExport;
        private System.Windows.Forms.ListView DeckList;
        private System.Windows.Forms.ColumnHeader CardName;
        private System.Windows.Forms.ColumnHeader CardCost;
    }
}

