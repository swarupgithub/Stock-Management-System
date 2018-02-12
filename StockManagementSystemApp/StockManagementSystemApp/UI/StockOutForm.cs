using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using StockManagementSystemApp.Manager;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.UI
{
    public partial class StockOutForm : Form
    {
        public StockOutForm()
        {
            InitializeComponent();
        }

        private CompanyManager aCompanyManager = new CompanyManager();
        private ItemManager aItemManager = new ItemManager();
        private  SalesManager aSalesManager = new SalesManager();
        private int serial = 0;
        private int serial2 = 0;


        private void StockOutForm_Load(object sender, EventArgs e)
        {
            Company defaultCompany = new Company();

            defaultCompany.CompanyName = "--Select Company--";
            defaultCompany.Id = -1;

            List<Company> companys = new List<Company>();

            companys.Add(defaultCompany);
            companys.AddRange(aCompanyManager.GetAllCompanysManager());

            companyStockOutComboBox.DisplayMember = "CompanyName";
            companyStockOutComboBox.ValueMember = "Id";
            companyStockOutComboBox.DataSource = companys;
        }



 
        private void stockOutListView_DoubleClick(object sender, EventArgs e)
        {
            Item aItem = stockOutListView.SelectedItems[0].Tag as Item;

            stockOutListView.Items[0].Remove();

            if (aItem != null)
            {
                hiddenItemIdForEdit.Text = aItem.Id.ToString();
                hiddenQuantityForEdit.Text = aItem.outQuantity.ToString();

                companyStockOutComboBox.SelectedValue = aItem.CompanyId;
                itemStockOutComboBox.SelectedValue = aItem.Id;
                availableQuantityStockOutTextBox.Text = aItem.ItemQuantity.ToString();
                reorderLevelStockOutTextBox.Text = aItem.ItemReorderLevel.ToString();
                quantityStockOutTextBox.Text = aItem.outQuantity.ToString();

                saveStockOutButton.Text = "Edit";

                saveStockOutButton.Enabled = true;
                deleteStockOutButton.Enabled = true;
            }
        }


        private void deleteStockOutButton_Click(object sender, EventArgs e)
        {
            Item aItem = new Item();

            aItem.Id = Convert.ToInt32(itemStockOutComboBox.SelectedValue);

            //aItem.GetQuantityUpdate(Convert.ToInt32(availableQuantityStockOutTextBox.Text), Convert.ToInt32(quantityStockOutTextBox.Text));


            string message = aItemManager.UpdateItemQuantityFromDeleteManager(aItem);

            MessageBox.Show(message);

            companyStockOutComboBox.SelectedValue = -1;
            itemStockOutComboBox.SelectedValue = -1;
            reorderLevelStockOutTextBox.Clear();
            availableQuantityStockOutTextBox.Clear();
            quantityStockOutTextBox.Clear();
        }


        private void sellStockOutButton_Click(object sender, EventArgs e)
        {
            string message = "";
            string QtyMessage = "";
            for (int i = 0; i < stockOutListView.Items.Count; i++)
            {
                Sales aSale = new Sales();

                aSale.ItemName = stockOutListView.Items[i].SubItems[1].Text;
                aSale.SalesQuantity = Convert.ToInt32(stockOutListView.Items[i].SubItems[2].Text);
                aSale.ItemId = Convert.ToInt32(stockOutListView.Items[i].SubItems[3].Text);
                
                

                message = aSalesManager.SaveIntoSalesManager(aSale);

                if (message == "Successfully Saled")
                {
                    Item aItem = new Item();
                    aItem.ItemQuantity = Convert.ToInt16(stockOutListView.Items[i].SubItems[4].Text) -
                                     Convert.ToInt16(stockOutListView.Items[i].SubItems[2].Text);
                    aItem.ItemName = stockOutListView.Items[i].SubItems[1].Text;
                    QtyMessage = aItemManager.QtyAfterSaleManager(aItem);

                }
            }

            MessageBox.Show(message);

            stockOutListView.Items.Clear();
            serial = 0;
        }



        private void companyStockOutComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            availableQuantityStockOutTextBox.Clear();
            reorderLevelStockOutTextBox.Clear();
            quantityStockOutTextBox.Text = String.Empty;

            saveStockOutButton.Text = "Save";
            deleteStockOutButton.Enabled = false;


            Item aItem = new Item();

            aItem.CompanyId = (int)companyStockOutComboBox.SelectedValue;

            Item defaultItem = new Item();

            defaultItem.ItemName = "--Select Item--";
            defaultItem.Id = -1;

            List<Item> items = new List<Item>();

            items.Add(defaultItem);
            items.AddRange(aItemManager.GetItemForComapnyManager(aItem));

            itemStockOutComboBox.DisplayMember = "ItemName";
            itemStockOutComboBox.ValueMember = "Id";
            itemStockOutComboBox.DataSource = items;
        }

        private void itemStockOutComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item aItem = new Item();

            aItem.CompanyId = (int)companyStockOutComboBox.SelectedValue;
            aItem.Id = (int)itemStockOutComboBox.SelectedValue;


            List<Item> items = new List<Item>();

            items = aItemManager.GetItemForReorderQuantityManager(aItem);

            foreach (Item item in items)
            {
                reorderLevelStockOutTextBox.Text = item.ItemReorderLevel.ToString();
                availableQuantityStockOutTextBox.Text = item.ItemQuantity.ToString();
            }
        }

        private void resetStockOutButton_Click(object sender, EventArgs e)
        {
            companyStockOutComboBox.SelectedValue = -1;
            itemStockOutComboBox.SelectedValue = -1;
            availableQuantityStockOutTextBox.Clear();
            reorderLevelStockOutTextBox.Clear();
            quantityStockOutTextBox.Text = String.Empty;
            hiddenQuantityForEdit.Text = String.Empty;

            saveStockOutButton.Text = "Save";
            deleteStockOutButton.Enabled = false;
        }

        

        private void addItemStockOutButton_Click(object sender, EventArgs e)
        {
            ItemForm aItemForm = new ItemForm();
            aItemForm.Show();
        }

        private void addCompanyStockOutButton_Click(object sender, EventArgs e)
        {
            CompanyForm aCompanyForm = new CompanyForm();
            aCompanyForm.Show();
        }

        private void saveStockOutButton_Click(object sender, EventArgs e)
        {
            
            try
            {

                if (companyStockOutComboBox.Text == "")
                {
                    MessageBox.Show("Enter Company Name!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    companyStockOutComboBox.Focus();
                    return;
                }

                if (itemStockOutComboBox.Text == "")
                {

                    MessageBox.Show("Enter Item!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    itemStockOutComboBox.Focus();
                    return;
                }
                if (quantityStockOutTextBox.Text == "")
                {

                    MessageBox.Show("Enter Quantity!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    quantityStockOutTextBox.Focus();
                    return;
                }

                int salequanty = Convert.ToInt32(quantityStockOutTextBox.Text);
                if (salequanty > Convert.ToInt32(availableQuantityStockOutTextBox.Text))
                {
                    MessageBox.Show("Number Of Quantity can not be ZERO or Less than Zero!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    quantityStockOutTextBox.Focus();
                    return;
                }


                serial += 1;
                ListViewItem item1 = new ListViewItem(serial.ToString());

                item1.SubItems.Add(itemStockOutComboBox.Text);
                item1.SubItems.Add(quantityStockOutTextBox.Text);
                item1.SubItems.Add(itemStockOutComboBox.SelectedValue.ToString());
                item1.SubItems.Add(availableQuantityStockOutTextBox.Text);
                stockOutListView.Items.Add(item1);

                companyStockOutComboBox.Text = "";
                itemStockOutComboBox.Text = "";
                quantityStockOutTextBox.Text = "";
                availableQuantityStockOutTextBox.Text = "";
                reorderLevelStockOutTextBox.Text = "";
                deleteStockOutButton.Enabled = true;
                for (int i = 0; i < stockOutListView.Items.Count; i++)
                {
                    stockOutListView.Items[i].SubItems[0].Text = (i + 1).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteStockOutButton_Click_1(object sender, EventArgs e)
        {
            while (stockOutListView.SelectedItems.Count > 0)
            {
                stockOutListView.Items.Remove(stockOutListView.SelectedItems[0]);
            }
            for (int i = 0; i < stockOutListView.Items.Count; i++)
            {
                stockOutListView.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }

        private void stockOutListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                while (stockOutListView.SelectedItems.Count > 0)
                {
                    stockOutListView.Items.Remove(stockOutListView.SelectedItems[0]);
                }
            }
            

            for (int i = 0; i < stockOutListView.Items.Count; i++)
            {
                stockOutListView.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
     
        }
 
    }
}
