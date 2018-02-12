namespace StockManagementSystemApp.UI
{
    partial class SearchViewItemSummaryForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchViewSummaryButton = new System.Windows.Forms.Button();
            this.categoryViewSummaryComboBox = new System.Windows.Forms.ComboBox();
            this.companyViewSummaryComboBox = new System.Windows.Forms.ComboBox();
            this.viewSummaryListView = new System.Windows.Forms.ListView();
            this.serialNumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.companyColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.availableQuantityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reorderLevelColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1295, 73);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(507, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "SEARCH SUMMARY";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.searchViewSummaryButton);
            this.panel1.Controls.Add(this.categoryViewSummaryComboBox);
            this.panel1.Controls.Add(this.companyViewSummaryComboBox);
            this.panel1.Controls.Add(this.viewSummaryListView);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(251, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 476);
            this.panel1.TabIndex = 5;
            // 
            // searchViewSummaryButton
            // 
            this.searchViewSummaryButton.BackColor = System.Drawing.Color.Gainsboro;
            this.searchViewSummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchViewSummaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchViewSummaryButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchViewSummaryButton.Location = new System.Drawing.Point(444, 68);
            this.searchViewSummaryButton.Name = "searchViewSummaryButton";
            this.searchViewSummaryButton.Size = new System.Drawing.Size(104, 36);
            this.searchViewSummaryButton.TabIndex = 7;
            this.searchViewSummaryButton.Text = "Search";
            this.searchViewSummaryButton.UseVisualStyleBackColor = false;
            this.searchViewSummaryButton.Click += new System.EventHandler(this.searchViewSummaryButton_Click);
            // 
            // categoryViewSummaryComboBox
            // 
            this.categoryViewSummaryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.categoryViewSummaryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.categoryViewSummaryComboBox.FormattingEnabled = true;
            this.categoryViewSummaryComboBox.Location = new System.Drawing.Point(194, 81);
            this.categoryViewSummaryComboBox.Name = "categoryViewSummaryComboBox";
            this.categoryViewSummaryComboBox.Size = new System.Drawing.Size(234, 21);
            this.categoryViewSummaryComboBox.TabIndex = 6;
            // 
            // companyViewSummaryComboBox
            // 
            this.companyViewSummaryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.companyViewSummaryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.companyViewSummaryComboBox.FormattingEnabled = true;
            this.companyViewSummaryComboBox.Location = new System.Drawing.Point(194, 40);
            this.companyViewSummaryComboBox.Name = "companyViewSummaryComboBox";
            this.companyViewSummaryComboBox.Size = new System.Drawing.Size(234, 21);
            this.companyViewSummaryComboBox.TabIndex = 5;
            // 
            // viewSummaryListView
            // 
            this.viewSummaryListView.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.viewSummaryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serialNumberColumnHeader,
            this.itemNameColumnHeader,
            this.companyColumnHeader,
            this.categoryColumnHeader,
            this.availableQuantityColumnHeader,
            this.reorderLevelColumnHeader});
            this.viewSummaryListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSummaryListView.FullRowSelect = true;
            this.viewSummaryListView.GridLines = true;
            this.viewSummaryListView.Location = new System.Drawing.Point(19, 121);
            this.viewSummaryListView.Name = "viewSummaryListView";
            this.viewSummaryListView.Size = new System.Drawing.Size(741, 333);
            this.viewSummaryListView.TabIndex = 10;
            this.viewSummaryListView.UseCompatibleStateImageBehavior = false;
            this.viewSummaryListView.View = System.Windows.Forms.View.Details;
            // 
            // serialNumberColumnHeader
            // 
            this.serialNumberColumnHeader.Text = "Serial Number";
            this.serialNumberColumnHeader.Width = 115;
            // 
            // itemNameColumnHeader
            // 
            this.itemNameColumnHeader.Text = "Item Name";
            this.itemNameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemNameColumnHeader.Width = 107;
            // 
            // companyColumnHeader
            // 
            this.companyColumnHeader.Text = "Company";
            this.companyColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.companyColumnHeader.Width = 130;
            // 
            // categoryColumnHeader
            // 
            this.categoryColumnHeader.Text = "Category";
            this.categoryColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.categoryColumnHeader.Width = 121;
            // 
            // availableQuantityColumnHeader
            // 
            this.availableQuantityColumnHeader.Text = "Available Quantity";
            this.availableQuantityColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.availableQuantityColumnHeader.Width = 140;
            // 
            // reorderLevelColumnHeader
            // 
            this.reorderLevelColumnHeader.Text = "Reorder Level";
            this.reorderLevelColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reorderLevelColumnHeader.Width = 126;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(102, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(102, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Company";
            // 
            // SearchViewItemSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StockManagementSystemApp.Properties.Resources.f93447e3c71d18de6f7c5176fdf02a2c;
            this.ClientSize = new System.Drawing.Size(1296, 589);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "SearchViewItemSummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search & View Item Summary";
            this.Load += new System.EventHandler(this.SearchViewItemSummaryForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchViewSummaryButton;
        private System.Windows.Forms.ComboBox categoryViewSummaryComboBox;
        private System.Windows.Forms.ComboBox companyViewSummaryComboBox;
        private System.Windows.Forms.ListView viewSummaryListView;
        private System.Windows.Forms.ColumnHeader serialNumberColumnHeader;
        private System.Windows.Forms.ColumnHeader itemNameColumnHeader;
        private System.Windows.Forms.ColumnHeader companyColumnHeader;
        private System.Windows.Forms.ColumnHeader categoryColumnHeader;
        private System.Windows.Forms.ColumnHeader availableQuantityColumnHeader;
        private System.Windows.Forms.ColumnHeader reorderLevelColumnHeader;
        private System.Windows.Forms.Label label3;

    }
}

