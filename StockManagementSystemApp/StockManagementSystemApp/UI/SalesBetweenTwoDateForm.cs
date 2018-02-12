using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using StockManagementSystemApp.Manager;
using StockManagementSystemApp.Model;
using StockManagementSystemApp.Model.View_Model;
using StockManagementSystemApp.Reporting;

namespace StockManagementSystemApp.UI
{
    public partial class SalesBetweenTwoDateForm : Form
    {
        public SalesBetweenTwoDateForm()
        {
            InitializeComponent();
        }

        SalesManager aSalesManager = new SalesManager();

        private void searchSalesButton_Click(object sender, EventArgs e)
        {
            SalesViewModel aSale = new SalesViewModel();

            aSale.FromDate = fromDateDateTimePicker.Value;
            aSale.ToDate = toDateDateTimePicker.Value;


            salesListView.Items.Clear();

            int count = 0;

            List<SalesViewModel> allSales = aSalesManager.GetSalesForDateManager(aSale);

            foreach (SalesViewModel sale in allSales)
            {
                count++;

                ListViewItem salesList = new ListViewItem(count.ToString());
                salesList.SubItems.Add(sale.ItemName);
                salesList.SubItems.Add(sale.SalesQuantity.ToString());
                salesList.SubItems.Add(sale.CreatedAt.ToLongDateString());

                salesListView.Items.Add(salesList);
            }
        }

    }
}
