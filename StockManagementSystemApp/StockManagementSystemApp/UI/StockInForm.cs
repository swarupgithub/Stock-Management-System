using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using StockManagementSystemApp.Manager;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.UI
{
    public partial class StockInForm : Form
    {
        public StockInForm()
        {
            InitializeComponent();
        }

        private CompanyManager aCompanyManager = new CompanyManager();
        private ItemManager aItemManager = new ItemManager();

        private void StockInForm_Load(object sender, EventArgs e)
        {
            Company defaultCompany = new Company();

            defaultCompany.CompanyName = "--Select Company--";
            defaultCompany.Id = -1;

            List<Company> companys = new List<Company>();
            companys.Add(defaultCompany);
            companys.AddRange(aCompanyManager.GetAllCompanysManager());
            companyStockInComboBox.DisplayMember = "CompanyName";
            companyStockInComboBox.ValueMember = "Id";
            companyStockInComboBox.DataSource = companys;
        }

        private void companyStockInComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item aItem = new Item();

            aItem.CompanyId = (int)companyStockInComboBox.SelectedValue;
            Item defaultItem = new Item();
            defaultItem.ItemName = "--Select Item--";
            defaultItem.Id = -1;

            List<Item> items = new List<Item>();
            items.Add(defaultItem);
            items.AddRange(aItemManager.GetItemForComapnyManager(aItem));
            itemStockInComboBox.DisplayMember = "ItemName";
            itemStockInComboBox.ValueMember = "Id";
            itemStockInComboBox.DataSource = items;
        }

        private void itemStockInComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item aItem = new Item();

            aItem.CompanyId = (int)companyStockInComboBox.SelectedValue;
            aItem.Id = (int)itemStockInComboBox.SelectedValue;

            List<Item> items = new List<Item>();
            items = aItemManager.GetItemForReorderQuantityManager(aItem);
            foreach (Item item in items)
            {
                reorderLevelStockInTextBox.Text = item.ItemReorderLevel.ToString();
                availableQuantityStockInTextBox.Text = item.ItemQuantity.ToString();
            }
        }

        private void saveStockInButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(companyStockInComboBox.SelectedValue) == -1)
            {
                MessageBox.Show("Please Select a Company");
                return;
            }

            if (Convert.ToInt32(itemStockInComboBox.SelectedValue) == -1)
            {
                MessageBox.Show("Please Select a Item");
                return;
            }

            if (string.IsNullOrEmpty(quantityStockInTextBox.Text) || Convert.ToInt32(quantityStockInTextBox.Text) < 0)
            {
                MessageBox.Show("Enter Valid Quantity Please");
                return;
            }


            Item aItem = new Item();

            aItem.Id = Convert.ToInt32(itemStockInComboBox.SelectedValue);

           // aItem.GetQuantityUpdate(Convert.ToInt32(availableQuantityStockInTextBox.Text), Convert.ToInt32(quantityStockInTextBox.Text));
            int sum = aItemManager.GetQuantityUpdate(Convert.ToInt32(availableQuantityStockInTextBox.Text), Convert.ToInt32(quantityStockInTextBox.Text));

            aItem.ItemQuantity = sum;

            string message = aItemManager.UpdateItemQuantityManager(aItem);

            MessageBox.Show(message);

            companyStockInComboBox.SelectedValue = -1;
            itemStockInComboBox.SelectedValue = -1;
            reorderLevelStockInTextBox.Clear();
            availableQuantityStockInTextBox.Clear();
            quantityStockInTextBox.Clear();
        }

        private void addCompanyStockInButton_Click(object sender, EventArgs e)
        {
            CompanyForm aCompanyForm= new CompanyForm();
            aCompanyForm.Show();
        }

        private void addItemStockInButton_Click(object sender, EventArgs e)
        {
            ItemForm aForm= new ItemForm();
            aForm.Show();
        }




    }
}
