﻿namespace StockManagementSystemApp.UI
{
    partial class CompanyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyForm));
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.hiddenIdCompany = new System.Windows.Forms.Label();
            this.companyListView = new System.Windows.Forms.ListView();
            this.serialNumberCompanyColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.companyNameCompanyColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.companyNameCompanyTextBox = new System.Windows.Forms.TextBox();
            this.deleteCompanyButton = new System.Windows.Forms.Button();
            this.resetCompanyButton = new System.Windows.Forms.Button();
            this.saveCompanyButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.panel3.Size = new System.Drawing.Size(1295, 86);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(495, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "ADD COMPANY";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(0, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1295, 504);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.hiddenIdCompany);
            this.panel5.Controls.Add(this.companyListView);
            this.panel5.Controls.Add(this.companyNameCompanyTextBox);
            this.panel5.Controls.Add(this.deleteCompanyButton);
            this.panel5.Controls.Add(this.resetCompanyButton);
            this.panel5.Controls.Add(this.saveCompanyButton);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(296, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(671, 439);
            this.panel5.TabIndex = 0;
            // 
            // hiddenIdCompany
            // 
            this.hiddenIdCompany.AutoSize = true;
            this.hiddenIdCompany.Enabled = false;
            this.hiddenIdCompany.Location = new System.Drawing.Point(549, 42);
            this.hiddenIdCompany.Name = "hiddenIdCompany";
            this.hiddenIdCompany.Size = new System.Drawing.Size(96, 13);
            this.hiddenIdCompany.TabIndex = 49;
            this.hiddenIdCompany.Text = "hidden id company";
            this.hiddenIdCompany.Visible = false;
            // 
            // companyListView
            // 
            this.companyListView.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.companyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serialNumberCompanyColumnHeader,
            this.companyNameCompanyColumnHeader});
            this.companyListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyListView.FullRowSelect = true;
            this.companyListView.GridLines = true;
            this.companyListView.Location = new System.Drawing.Point(22, 104);
            this.companyListView.Name = "companyListView";
            this.companyListView.Size = new System.Drawing.Size(626, 313);
            this.companyListView.TabIndex = 47;
            this.companyListView.UseCompatibleStateImageBehavior = false;
            this.companyListView.View = System.Windows.Forms.View.Details;
            this.companyListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.companyListView_MouseDoubleClick);
            // 
            // serialNumberCompanyColumnHeader
            // 
            this.serialNumberCompanyColumnHeader.Text = "Serial Number";
            this.serialNumberCompanyColumnHeader.Width = 127;
            // 
            // companyNameCompanyColumnHeader
            // 
            this.companyNameCompanyColumnHeader.Text = "Company Name";
            this.companyNameCompanyColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.companyNameCompanyColumnHeader.Width = 543;
            // 
            // companyNameCompanyTextBox
            // 
            this.companyNameCompanyTextBox.Location = new System.Drawing.Point(215, 24);
            this.companyNameCompanyTextBox.Multiline = true;
            this.companyNameCompanyTextBox.Name = "companyNameCompanyTextBox";
            this.companyNameCompanyTextBox.Size = new System.Drawing.Size(307, 30);
            this.companyNameCompanyTextBox.TabIndex = 43;
            // 
            // deleteCompanyButton
            // 
            this.deleteCompanyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteCompanyButton.Enabled = false;
            this.deleteCompanyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteCompanyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCompanyButton.Location = new System.Drawing.Point(440, 66);
            this.deleteCompanyButton.Name = "deleteCompanyButton";
            this.deleteCompanyButton.Size = new System.Drawing.Size(82, 29);
            this.deleteCompanyButton.TabIndex = 46;
            this.deleteCompanyButton.Text = "Delete";
            this.deleteCompanyButton.UseVisualStyleBackColor = false;
            this.deleteCompanyButton.Click += new System.EventHandler(this.deleteCompanyButton_Click);
            // 
            // resetCompanyButton
            // 
            this.resetCompanyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.resetCompanyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetCompanyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetCompanyButton.Location = new System.Drawing.Point(331, 66);
            this.resetCompanyButton.Name = "resetCompanyButton";
            this.resetCompanyButton.Size = new System.Drawing.Size(91, 29);
            this.resetCompanyButton.TabIndex = 45;
            this.resetCompanyButton.Text = "Reset";
            this.resetCompanyButton.UseVisualStyleBackColor = false;
            this.resetCompanyButton.Click += new System.EventHandler(this.resetCompanyButton_Click);
            // 
            // saveCompanyButton
            // 
            this.saveCompanyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saveCompanyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveCompanyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCompanyButton.Location = new System.Drawing.Point(215, 66);
            this.saveCompanyButton.Name = "saveCompanyButton";
            this.saveCompanyButton.Size = new System.Drawing.Size(95, 29);
            this.saveCompanyButton.TabIndex = 44;
            this.saveCompanyButton.Text = "Save";
            this.saveCompanyButton.UseVisualStyleBackColor = false;
            this.saveCompanyButton.Click += new System.EventHandler(this.saveCompanyButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Company Name";
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1295, 587);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Form";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label hiddenIdCompany;
        private System.Windows.Forms.ListView companyListView;
        private System.Windows.Forms.ColumnHeader serialNumberCompanyColumnHeader;
        private System.Windows.Forms.ColumnHeader companyNameCompanyColumnHeader;
        private System.Windows.Forms.TextBox companyNameCompanyTextBox;
        private System.Windows.Forms.Button deleteCompanyButton;
        private System.Windows.Forms.Button resetCompanyButton;
        private System.Windows.Forms.Button saveCompanyButton;
        private System.Windows.Forms.Label label7;
    }
}