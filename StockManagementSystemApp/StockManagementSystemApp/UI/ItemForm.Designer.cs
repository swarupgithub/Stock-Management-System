namespace StockManagementSystemApp.UI
{
    partial class ItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemForm));
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
            this.clearlistButton = new System.Windows.Forms.Button();
            this.hiddenIdItem = new System.Windows.Forms.Label();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.resetItemButton = new System.Windows.Forms.Button();
            this.itemListView = new System.Windows.Forms.ListView();
            this.serialNumberItemColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemItemColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.companyItemColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CategoryItemColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reorderLevelColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reorderLevelItemTextBox = new System.Windows.Forms.TextBox();
            this.itemNameItemTextBox = new System.Windows.Forms.TextBox();
            this.addCategoryItemButton = new System.Windows.Forms.Button();
            this.saveItemButton = new System.Windows.Forms.Button();
            this.addCompanyItemButton = new System.Windows.Forms.Button();
            this.categoryItemComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.companyItemComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.panel3.Size = new System.Drawing.Size(1294, 86);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(514, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "ITEM INFORMATION";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.clearlistButton);
            this.panel4.Controls.Add(this.hiddenIdItem);
            this.panel4.Controls.Add(this.deleteItemButton);
            this.panel4.Controls.Add(this.resetItemButton);
            this.panel4.Controls.Add(this.itemListView);
            this.panel4.Controls.Add(this.reorderLevelItemTextBox);
            this.panel4.Controls.Add(this.itemNameItemTextBox);
            this.panel4.Controls.Add(this.addCategoryItemButton);
            this.panel4.Controls.Add(this.saveItemButton);
            this.panel4.Controls.Add(this.addCompanyItemButton);
            this.panel4.Controls.Add(this.categoryItemComboBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.companyItemComboBox);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(242, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 454);
            this.panel4.TabIndex = 37;
            // 
            // clearlistButton
            // 
            this.clearlistButton.BackColor = System.Drawing.Color.Gainsboro;
            this.clearlistButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearlistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearlistButton.Location = new System.Drawing.Point(515, 99);
            this.clearlistButton.Name = "clearlistButton";
            this.clearlistButton.Size = new System.Drawing.Size(187, 38);
            this.clearlistButton.TabIndex = 52;
            this.clearlistButton.Text = "Clear List";
            this.clearlistButton.UseVisualStyleBackColor = false;
            this.clearlistButton.Click += new System.EventHandler(this.clearlistButton_Click);
            // 
            // hiddenIdItem
            // 
            this.hiddenIdItem.AutoSize = true;
            this.hiddenIdItem.Location = new System.Drawing.Point(554, 155);
            this.hiddenIdItem.Name = "hiddenIdItem";
            this.hiddenIdItem.Size = new System.Drawing.Size(72, 13);
            this.hiddenIdItem.TabIndex = 51;
            this.hiddenIdItem.Text = "hidden id item";
            this.hiddenIdItem.Visible = false;
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.BackColor = System.Drawing.Color.Gainsboro;
            this.deleteItemButton.Enabled = false;
            this.deleteItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItemButton.Location = new System.Drawing.Point(396, 144);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(90, 40);
            this.deleteItemButton.TabIndex = 43;
            this.deleteItemButton.Text = "Delete";
            this.deleteItemButton.UseVisualStyleBackColor = false;
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            // 
            // resetItemButton
            // 
            this.resetItemButton.BackColor = System.Drawing.Color.Gainsboro;
            this.resetItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetItemButton.Location = new System.Drawing.Point(299, 145);
            this.resetItemButton.Name = "resetItemButton";
            this.resetItemButton.Size = new System.Drawing.Size(91, 39);
            this.resetItemButton.TabIndex = 42;
            this.resetItemButton.Text = "Reset";
            this.resetItemButton.UseVisualStyleBackColor = false;
            this.resetItemButton.Click += new System.EventHandler(this.resetItemButton_Click);
            // 
            // itemListView
            // 
            this.itemListView.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.itemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serialNumberItemColumnHeader,
            this.itemItemColumnHeader,
            this.companyItemColumnHeader,
            this.CategoryItemColumnHeader,
            this.reorderLevelColumnHeader});
            this.itemListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemListView.FullRowSelect = true;
            this.itemListView.GridLines = true;
            this.itemListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.itemListView.Location = new System.Drawing.Point(37, 193);
            this.itemListView.Name = "itemListView";
            this.itemListView.Size = new System.Drawing.Size(726, 247);
            this.itemListView.TabIndex = 46;
            this.itemListView.UseCompatibleStateImageBehavior = false;
            this.itemListView.View = System.Windows.Forms.View.Details;
            this.itemListView.DoubleClick += new System.EventHandler(this.itemListView_DoubleClick);
            // 
            // serialNumberItemColumnHeader
            // 
            this.serialNumberItemColumnHeader.Text = "Serial Number";
            this.serialNumberItemColumnHeader.Width = 121;
            // 
            // itemItemColumnHeader
            // 
            this.itemItemColumnHeader.Text = "Item Name";
            this.itemItemColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemItemColumnHeader.Width = 152;
            // 
            // companyItemColumnHeader
            // 
            this.companyItemColumnHeader.Text = "Company";
            this.companyItemColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.companyItemColumnHeader.Width = 157;
            // 
            // CategoryItemColumnHeader
            // 
            this.CategoryItemColumnHeader.Text = "Category";
            this.CategoryItemColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CategoryItemColumnHeader.Width = 168;
            // 
            // reorderLevelColumnHeader
            // 
            this.reorderLevelColumnHeader.Text = "Reorder Level";
            this.reorderLevelColumnHeader.Width = 127;
            // 
            // reorderLevelItemTextBox
            // 
            this.reorderLevelItemTextBox.Location = new System.Drawing.Point(202, 110);
            this.reorderLevelItemTextBox.Multiline = true;
            this.reorderLevelItemTextBox.Name = "reorderLevelItemTextBox";
            this.reorderLevelItemTextBox.Size = new System.Drawing.Size(284, 30);
            this.reorderLevelItemTextBox.TabIndex = 40;
            // 
            // itemNameItemTextBox
            // 
            this.itemNameItemTextBox.Location = new System.Drawing.Point(202, 74);
            this.itemNameItemTextBox.Multiline = true;
            this.itemNameItemTextBox.Name = "itemNameItemTextBox";
            this.itemNameItemTextBox.Size = new System.Drawing.Size(284, 30);
            this.itemNameItemTextBox.TabIndex = 39;
            // 
            // addCategoryItemButton
            // 
            this.addCategoryItemButton.BackColor = System.Drawing.Color.Gainsboro;
            this.addCategoryItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addCategoryItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryItemButton.Location = new System.Drawing.Point(515, 60);
            this.addCategoryItemButton.Name = "addCategoryItemButton";
            this.addCategoryItemButton.Size = new System.Drawing.Size(187, 32);
            this.addCategoryItemButton.TabIndex = 44;
            this.addCategoryItemButton.Text = "Add Category";
            this.addCategoryItemButton.UseVisualStyleBackColor = false;
            this.addCategoryItemButton.Click += new System.EventHandler(this.addCategoryItemButton_Click);
            // 
            // saveItemButton
            // 
            this.saveItemButton.BackColor = System.Drawing.Color.Gainsboro;
            this.saveItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveItemButton.Location = new System.Drawing.Point(202, 146);
            this.saveItemButton.Name = "saveItemButton";
            this.saveItemButton.Size = new System.Drawing.Size(91, 38);
            this.saveItemButton.TabIndex = 41;
            this.saveItemButton.Text = "Save";
            this.saveItemButton.UseVisualStyleBackColor = false;
            this.saveItemButton.Click += new System.EventHandler(this.saveItemButton_Click);
            // 
            // addCompanyItemButton
            // 
            this.addCompanyItemButton.BackColor = System.Drawing.Color.Gainsboro;
            this.addCompanyItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addCompanyItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCompanyItemButton.Location = new System.Drawing.Point(514, 18);
            this.addCompanyItemButton.Name = "addCompanyItemButton";
            this.addCompanyItemButton.Size = new System.Drawing.Size(187, 36);
            this.addCompanyItemButton.TabIndex = 45;
            this.addCompanyItemButton.Text = "Add Company";
            this.addCompanyItemButton.UseVisualStyleBackColor = false;
            this.addCompanyItemButton.Click += new System.EventHandler(this.addCompanyItemButton_Click);
            // 
            // categoryItemComboBox
            // 
            this.categoryItemComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.categoryItemComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.categoryItemComboBox.FormattingEnabled = true;
            this.categoryItemComboBox.Location = new System.Drawing.Point(202, 47);
            this.categoryItemComboBox.Name = "categoryItemComboBox";
            this.categoryItemComboBox.Size = new System.Drawing.Size(284, 21);
            this.categoryItemComboBox.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 47;
            this.label4.Text = "Category";
            // 
            // companyItemComboBox
            // 
            this.companyItemComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.companyItemComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.companyItemComboBox.FormattingEnabled = true;
            this.companyItemComboBox.Location = new System.Drawing.Point(202, 20);
            this.companyItemComboBox.Name = "companyItemComboBox";
            this.companyItemComboBox.Size = new System.Drawing.Size(284, 21);
            this.companyItemComboBox.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 48;
            this.label6.Text = "Reorder Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 49;
            this.label5.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "Company";
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1294, 588);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Form";
            this.Load += new System.EventHandler(this.ItemForm_Load);
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
        private System.Windows.Forms.Label hiddenIdItem;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button resetItemButton;
        private System.Windows.Forms.ListView itemListView;
        private System.Windows.Forms.ColumnHeader serialNumberItemColumnHeader;
        private System.Windows.Forms.ColumnHeader itemItemColumnHeader;
        private System.Windows.Forms.ColumnHeader companyItemColumnHeader;
        private System.Windows.Forms.ColumnHeader CategoryItemColumnHeader;
        private System.Windows.Forms.ColumnHeader reorderLevelColumnHeader;
        private System.Windows.Forms.TextBox reorderLevelItemTextBox;
        private System.Windows.Forms.TextBox itemNameItemTextBox;
        private System.Windows.Forms.Button addCategoryItemButton;
        private System.Windows.Forms.Button saveItemButton;
        private System.Windows.Forms.Button addCompanyItemButton;
        private System.Windows.Forms.ComboBox categoryItemComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox companyItemComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearlistButton;
    }
}