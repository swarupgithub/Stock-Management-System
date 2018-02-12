namespace StockManagementSystemApp.UI
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
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
            this.hiddenIdCategory = new System.Windows.Forms.Label();
            this.categoryListView = new System.Windows.Forms.ListView();
            this.serialNumberCategoryColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.companyNameCategoryColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryNameCategoryTextBox = new System.Windows.Forms.TextBox();
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.resetCategoryButton = new System.Windows.Forms.Button();
            this.saveCategoryButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
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
            this.panel3.Size = new System.Drawing.Size(1299, 86);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(507, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADD CATEGORY";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.hiddenIdCategory);
            this.panel4.Controls.Add(this.categoryListView);
            this.panel4.Controls.Add(this.categoryNameCategoryTextBox);
            this.panel4.Controls.Add(this.deleteCategoryButton);
            this.panel4.Controls.Add(this.resetCategoryButton);
            this.panel4.Controls.Add(this.saveCategoryButton);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(261, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(762, 406);
            this.panel4.TabIndex = 35;
            // 
            // hiddenIdCategory
            // 
            this.hiddenIdCategory.AutoSize = true;
            this.hiddenIdCategory.Enabled = false;
            this.hiddenIdCategory.Location = new System.Drawing.Point(204, 109);
            this.hiddenIdCategory.Name = "hiddenIdCategory";
            this.hiddenIdCategory.Size = new System.Drawing.Size(94, 13);
            this.hiddenIdCategory.TabIndex = 41;
            this.hiddenIdCategory.Text = "hidden id category";
            this.hiddenIdCategory.Visible = false;
            // 
            // categoryListView
            // 
            this.categoryListView.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.categoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serialNumberCategoryColumnHeader,
            this.companyNameCategoryColumnHeader});
            this.categoryListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryListView.FullRowSelect = true;
            this.categoryListView.GridLines = true;
            this.categoryListView.Location = new System.Drawing.Point(60, 137);
            this.categoryListView.Name = "categoryListView";
            this.categoryListView.Size = new System.Drawing.Size(643, 246);
            this.categoryListView.TabIndex = 39;
            this.categoryListView.UseCompatibleStateImageBehavior = false;
            this.categoryListView.View = System.Windows.Forms.View.Details;
            this.categoryListView.DoubleClick += new System.EventHandler(this.categoryListView_DoubleClick);
            // 
            // serialNumberCategoryColumnHeader
            // 
            this.serialNumberCategoryColumnHeader.Text = "Serial Number";
            this.serialNumberCategoryColumnHeader.Width = 139;
            // 
            // companyNameCategoryColumnHeader
            // 
            this.companyNameCategoryColumnHeader.Text = "Category Name";
            this.companyNameCategoryColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.companyNameCategoryColumnHeader.Width = 500;
            // 
            // categoryNameCategoryTextBox
            // 
            this.categoryNameCategoryTextBox.Location = new System.Drawing.Point(269, 20);
            this.categoryNameCategoryTextBox.Multiline = true;
            this.categoryNameCategoryTextBox.Name = "categoryNameCategoryTextBox";
            this.categoryNameCategoryTextBox.Size = new System.Drawing.Size(307, 30);
            this.categoryNameCategoryTextBox.TabIndex = 35;
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.BackColor = System.Drawing.Color.Gainsboro;
            this.deleteCategoryButton.Enabled = false;
            this.deleteCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCategoryButton.Location = new System.Drawing.Point(466, 59);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(108, 45);
            this.deleteCategoryButton.TabIndex = 38;
            this.deleteCategoryButton.Text = "DELETE";
            this.deleteCategoryButton.UseVisualStyleBackColor = false;
            this.deleteCategoryButton.Click += new System.EventHandler(this.deleteCategoryButton_Click);
            // 
            // resetCategoryButton
            // 
            this.resetCategoryButton.BackColor = System.Drawing.Color.Gainsboro;
            this.resetCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetCategoryButton.Location = new System.Drawing.Point(190, 59);
            this.resetCategoryButton.Name = "resetCategoryButton";
            this.resetCategoryButton.Size = new System.Drawing.Size(108, 45);
            this.resetCategoryButton.TabIndex = 37;
            this.resetCategoryButton.Text = "RESET";
            this.resetCategoryButton.UseVisualStyleBackColor = false;
            this.resetCategoryButton.Click += new System.EventHandler(this.resetCategoryButton_Click);
            // 
            // saveCategoryButton
            // 
            this.saveCategoryButton.BackColor = System.Drawing.Color.Gainsboro;
            this.saveCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCategoryButton.Location = new System.Drawing.Point(321, 59);
            this.saveCategoryButton.Name = "saveCategoryButton";
            this.saveCategoryButton.Size = new System.Drawing.Size(112, 45);
            this.saveCategoryButton.TabIndex = 36;
            this.saveCategoryButton.Text = "SAVE";
            this.saveCategoryButton.UseVisualStyleBackColor = false;
            this.saveCategoryButton.Click += new System.EventHandler(this.saveCategoryButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(135, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 18);
            this.label7.TabIndex = 40;
            this.label7.Text = "Category Name";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1302, 590);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category Form";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
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
        private System.Windows.Forms.Label hiddenIdCategory;
        private System.Windows.Forms.ListView categoryListView;
        private System.Windows.Forms.ColumnHeader serialNumberCategoryColumnHeader;
        private System.Windows.Forms.ColumnHeader companyNameCategoryColumnHeader;
        private System.Windows.Forms.TextBox categoryNameCategoryTextBox;
        private System.Windows.Forms.Button deleteCategoryButton;
        private System.Windows.Forms.Button resetCategoryButton;
        private System.Windows.Forms.Button saveCategoryButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
    }
}