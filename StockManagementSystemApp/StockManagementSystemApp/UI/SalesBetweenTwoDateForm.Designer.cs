namespace StockManagementSystemApp.UI
{
    partial class SalesBetweenTwoDateForm
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
            this.salesButton = new System.Windows.Forms.Button();
            this.viewSummaryButton = new System.Windows.Forms.Button();
            this.stockOutButton = new System.Windows.Forms.Button();
            this.stockInButton = new System.Windows.Forms.Button();
            this.itemButton = new System.Windows.Forms.Button();
            this.companyButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.salesListView = new System.Windows.Forms.ListView();
            this.serialNumberSalesColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemSalesColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saleQuantityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateSalesColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchSalesButton = new System.Windows.Forms.Button();
            this.toDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-253, -112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 45);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Management System Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.salesButton);
            this.panel1.Controls.Add(this.viewSummaryButton);
            this.panel1.Controls.Add(this.stockOutButton);
            this.panel1.Controls.Add(this.stockInButton);
            this.panel1.Controls.Add(this.itemButton);
            this.panel1.Controls.Add(this.companyButton);
            this.panel1.Controls.Add(this.categoryButton);
            this.panel1.Location = new System.Drawing.Point(-253, -68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 441);
            this.panel1.TabIndex = 2;
            // 
            // salesButton
            // 
            this.salesButton.BackColor = System.Drawing.Color.Gray;
            this.salesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesButton.ForeColor = System.Drawing.Color.White;
            this.salesButton.Location = new System.Drawing.Point(0, 229);
            this.salesButton.Name = "salesButton";
            this.salesButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.salesButton.Size = new System.Drawing.Size(146, 40);
            this.salesButton.TabIndex = 0;
            this.salesButton.Text = "Sales";
            this.salesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesButton.UseVisualStyleBackColor = false;
            // 
            // viewSummaryButton
            // 
            this.viewSummaryButton.BackColor = System.Drawing.Color.Gray;
            this.viewSummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewSummaryButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSummaryButton.ForeColor = System.Drawing.Color.White;
            this.viewSummaryButton.Location = new System.Drawing.Point(0, 191);
            this.viewSummaryButton.Name = "viewSummaryButton";
            this.viewSummaryButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.viewSummaryButton.Size = new System.Drawing.Size(146, 40);
            this.viewSummaryButton.TabIndex = 0;
            this.viewSummaryButton.Text = "View Summary";
            this.viewSummaryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewSummaryButton.UseVisualStyleBackColor = false;
            // 
            // stockOutButton
            // 
            this.stockOutButton.BackColor = System.Drawing.Color.Gray;
            this.stockOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockOutButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockOutButton.ForeColor = System.Drawing.Color.White;
            this.stockOutButton.Location = new System.Drawing.Point(0, 153);
            this.stockOutButton.Name = "stockOutButton";
            this.stockOutButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.stockOutButton.Size = new System.Drawing.Size(146, 40);
            this.stockOutButton.TabIndex = 0;
            this.stockOutButton.Text = "Stock Out";
            this.stockOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockOutButton.UseVisualStyleBackColor = false;
            // 
            // stockInButton
            // 
            this.stockInButton.BackColor = System.Drawing.Color.Gray;
            this.stockInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockInButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockInButton.ForeColor = System.Drawing.Color.White;
            this.stockInButton.Location = new System.Drawing.Point(0, 114);
            this.stockInButton.Name = "stockInButton";
            this.stockInButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.stockInButton.Size = new System.Drawing.Size(146, 40);
            this.stockInButton.TabIndex = 0;
            this.stockInButton.Text = "Stock In";
            this.stockInButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockInButton.UseVisualStyleBackColor = false;
            // 
            // itemButton
            // 
            this.itemButton.BackColor = System.Drawing.Color.Gray;
            this.itemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemButton.ForeColor = System.Drawing.Color.White;
            this.itemButton.Location = new System.Drawing.Point(0, 76);
            this.itemButton.Name = "itemButton";
            this.itemButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.itemButton.Size = new System.Drawing.Size(146, 40);
            this.itemButton.TabIndex = 0;
            this.itemButton.Text = "Item";
            this.itemButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemButton.UseVisualStyleBackColor = false;
            // 
            // companyButton
            // 
            this.companyButton.BackColor = System.Drawing.Color.Gray;
            this.companyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.companyButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyButton.ForeColor = System.Drawing.Color.White;
            this.companyButton.Location = new System.Drawing.Point(0, 38);
            this.companyButton.Name = "companyButton";
            this.companyButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.companyButton.Size = new System.Drawing.Size(146, 40);
            this.companyButton.TabIndex = 0;
            this.companyButton.Text = "Company";
            this.companyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.companyButton.UseVisualStyleBackColor = false;
            // 
            // categoryButton
            // 
            this.categoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryButton.BackColor = System.Drawing.Color.Gray;
            this.categoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryButton.ForeColor = System.Drawing.Color.White;
            this.categoryButton.Location = new System.Drawing.Point(0, 1);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.categoryButton.Size = new System.Drawing.Size(146, 40);
            this.categoryButton.TabIndex = 0;
            this.categoryButton.Text = "Category";
            this.categoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryButton.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1302, 79);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(479, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "SEARCH BY DATE";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.salesListView);
            this.panel4.Controls.Add(this.searchSalesButton);
            this.panel4.Controls.Add(this.toDateDateTimePicker);
            this.panel4.Controls.Add(this.fromDateDateTimePicker);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(218, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(865, 475);
            this.panel4.TabIndex = 8;
            // 
            // salesListView
            // 
            this.salesListView.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.salesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serialNumberSalesColumnHeader,
            this.itemSalesColumnHeader,
            this.saleQuantityColumnHeader,
            this.dateSalesColumnHeader});
            this.salesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesListView.FullRowSelect = true;
            this.salesListView.GridLines = true;
            this.salesListView.Location = new System.Drawing.Point(63, 108);
            this.salesListView.Name = "salesListView";
            this.salesListView.Size = new System.Drawing.Size(739, 333);
            this.salesListView.TabIndex = 11;
            this.salesListView.UseCompatibleStateImageBehavior = false;
            this.salesListView.View = System.Windows.Forms.View.Details;
            // 
            // serialNumberSalesColumnHeader
            // 
            this.serialNumberSalesColumnHeader.Text = "Serial Number";
            this.serialNumberSalesColumnHeader.Width = 123;
            // 
            // itemSalesColumnHeader
            // 
            this.itemSalesColumnHeader.Text = "Item";
            this.itemSalesColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemSalesColumnHeader.Width = 187;
            // 
            // saleQuantityColumnHeader
            // 
            this.saleQuantityColumnHeader.Text = "Sale Quantity";
            this.saleQuantityColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saleQuantityColumnHeader.Width = 143;
            // 
            // dateSalesColumnHeader
            // 
            this.dateSalesColumnHeader.Text = "Date";
            this.dateSalesColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateSalesColumnHeader.Width = 171;
            // 
            // searchSalesButton
            // 
            this.searchSalesButton.BackColor = System.Drawing.Color.Gainsboro;
            this.searchSalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchSalesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSalesButton.Location = new System.Drawing.Point(502, 46);
            this.searchSalesButton.Name = "searchSalesButton";
            this.searchSalesButton.Size = new System.Drawing.Size(97, 39);
            this.searchSalesButton.TabIndex = 10;
            this.searchSalesButton.Text = "Search";
            this.searchSalesButton.UseVisualStyleBackColor = false;
            this.searchSalesButton.Click += new System.EventHandler(this.searchSalesButton_Click);
            // 
            // toDateDateTimePicker
            // 
            this.toDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.toDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDateDateTimePicker.Location = new System.Drawing.Point(232, 65);
            this.toDateDateTimePicker.Name = "toDateDateTimePicker";
            this.toDateDateTimePicker.Size = new System.Drawing.Size(251, 20);
            this.toDateDateTimePicker.TabIndex = 9;
            // 
            // fromDateDateTimePicker
            // 
            this.fromDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.fromDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDateDateTimePicker.Location = new System.Drawing.Point(232, 33);
            this.fromDateDateTimePicker.Name = "fromDateDateTimePicker";
            this.fromDateDateTimePicker.Size = new System.Drawing.Size(251, 20);
            this.fromDateDateTimePicker.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "To Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "From Date";
            // 
            // SalesBetweenTwoDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StockManagementSystemApp.Properties.Resources.f93447e3c71d18de6f7c5176fdf02a2c1;
            this.ClientSize = new System.Drawing.Size(1302, 597);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SalesBetweenTwoDateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Between Two Date";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button viewSummaryButton;
        private System.Windows.Forms.Button stockOutButton;
        private System.Windows.Forms.Button stockInButton;
        private System.Windows.Forms.Button itemButton;
        private System.Windows.Forms.Button companyButton;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView salesListView;
        private System.Windows.Forms.ColumnHeader serialNumberSalesColumnHeader;
        private System.Windows.Forms.ColumnHeader itemSalesColumnHeader;
        private System.Windows.Forms.ColumnHeader saleQuantityColumnHeader;
        private System.Windows.Forms.ColumnHeader dateSalesColumnHeader;
        private System.Windows.Forms.Button searchSalesButton;
        private System.Windows.Forms.DateTimePicker toDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker fromDateDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}