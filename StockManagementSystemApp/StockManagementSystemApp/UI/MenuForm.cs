using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystemApp.Reporting;
using StockManagementSystemApp.UI;

namespace StockManagementSystemApp
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void addCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyForm aCompanyForm= new CompanyForm();
            aCompanyForm.Show();
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm aCategoryForm= new CategoryForm();
            aCategoryForm.Show();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemForm aItemForm=new ItemForm();
            aItemForm.Show();
        }

        private void stockInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockInForm aStockInForm= new StockInForm();
            aStockInForm.Show();
        }

        private void stockOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockOutForm aStockOutForm=new StockOutForm();
            aStockOutForm.Show();
        }

        private void searchSummeryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchViewItemSummaryForm aSearchViewItemSummaryForm=new SearchViewItemSummaryForm();
            aSearchViewItemSummaryForm.Show();
        }

        private void searchByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesBetweenTwoDateForm aSalesBetweenTwoDateForm= new SalesBetweenTwoDateForm();
            aSalesBetweenTwoDateForm.Show();
        }

        private void tOOLSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stockItemReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockPrintForm aStockPrintForm= new StockPrintForm();
            aStockPrintForm.Show();
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesPrintForm aSalesPrintForm=new SalesPrintForm();
            aSalesPrintForm.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void windowsWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WinWord.exe");
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("TaskMgr.exe");
        }
    }
}
