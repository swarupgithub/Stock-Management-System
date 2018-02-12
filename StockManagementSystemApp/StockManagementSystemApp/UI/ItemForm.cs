using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using StockManagementSystemApp.Manager;
using StockManagementSystemApp.Model;
using StockManagementSystemApp.Model.View_Model;

namespace StockManagementSystemApp.UI
{
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }

        private CategoryManager aCategoryManager = new CategoryManager();
        private CompanyManager aCompanyManager = new CompanyManager();
        private ItemManager aItemManager = new ItemManager();


        private void ItemForm_Load(object sender, EventArgs e)
        {
            Company defaultCompany = new Company();

            defaultCompany.CompanyName = "--Select Company--";
            defaultCompany.Id = -1;

            List<Company> companys = new List<Company>();

            companys.Add(defaultCompany);                                         
            companys.AddRange(aCompanyManager.GetAllCompanysManager());

            companyItemComboBox.DisplayMember = "CompanyName";                        
            companyItemComboBox.ValueMember = "Id";                            
            companyItemComboBox.DataSource = companys;


            Category defaultCategory = new Category();

            defaultCategory.CategoryName = "--Select Category--";
            defaultCategory.Id = -1;

            List<Category> categories = new List<Category>();

            categories.Add(defaultCategory);
            categories.AddRange(aCategoryManager.GetAllCategoriesManager());

            categoryItemComboBox.DisplayMember = "CategoryName";
            categoryItemComboBox.ValueMember = "Id";
            categoryItemComboBox.DataSource = categories;  


            PopulateItems();
        }

        private void PopulateItems()
        {
            itemListView.Items.Clear();

            int count = 0;

            List<ItemViewModel> items = aItemManager.GetAllItemManager();

            foreach (ItemViewModel item in items)
            {
                count++;

                ListViewItem itemList = new ListViewItem(count.ToString());
                itemList.SubItems.Add(item.ItemName);
                itemList.SubItems.Add(item.CompanyName);
                itemList.SubItems.Add(item.CategoryName);
                itemList.SubItems.Add(item.ItemReorderLevel.ToString());

                itemList.Tag = item;

                itemListView.Items.Add(itemList);
            }
        }

        private void clearlistButton_Click(object sender, EventArgs e)
        {
            itemListView.Items.Clear();
        }

        private void saveItemButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(companyItemComboBox.SelectedValue) == -1)
            {
                MessageBox.Show("Please Select a Company");
                return;
            }

            if (Convert.ToInt32(categoryItemComboBox.SelectedValue) == -1)
            {
                MessageBox.Show("Please Select a Category");
                return;
            }

            if (string.IsNullOrEmpty(itemNameItemTextBox.Text))
            {
                MessageBox.Show("Write Your Item Name Please");
                return;
            }


            Item aItem = new Item();

            aItem.CompanyId = Convert.ToInt32(companyItemComboBox.SelectedValue);
            aItem.CategoryId = Convert.ToInt32(categoryItemComboBox.SelectedValue);
            aItem.ItemName = itemNameItemTextBox.Text.ToUpper();

            if (reorderLevelItemTextBox.Text != string.Empty)
            {
                aItem.ItemReorderLevel = Convert.ToInt32(reorderLevelItemTextBox.Text);
            }
            else
            {
                aItem.ItemReorderLevel = 0;
            }

            if (saveItemButton.Text == "Save")
            {
                string message = aItemManager.SaveItemManager(aItem);

                MessageBox.Show(message);
            }
            else
            {
                aItem.Id = Convert.ToInt32(hiddenIdItem.Text);

                string message = aItemManager.UpdateItemManager(aItem);

                MessageBox.Show(message);

                saveItemButton.Text = "Save";
                deleteItemButton.Enabled = false;
            }

            PopulateItems();

            companyItemComboBox.SelectedValue = -1;
            categoryItemComboBox.SelectedValue = -1;
            itemNameItemTextBox.Clear();
            reorderLevelItemTextBox.Clear();
            hiddenIdItem.Text = String.Empty;
        }

        private void resetItemButton_Click(object sender, EventArgs e)
        {
            companyItemComboBox.SelectedValue = -1;
            categoryItemComboBox.SelectedValue = -1;
            itemNameItemTextBox.Clear();
            reorderLevelItemTextBox.Clear();
            hiddenIdItem.Text = String.Empty;

            saveItemButton.Text = "Save";
            deleteItemButton.Enabled = false;
        }

        private void addCompanyItemButton_Click(object sender, EventArgs e)
        {
            CompanyForm aCompanyForm = new CompanyForm();
            aCompanyForm.Show();
        }

        private void addCategoryItemButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoryForm aCategoryForm = new CategoryForm();
            aCategoryForm.Show();
        }

        private void itemListView_DoubleClick(object sender, EventArgs e)
        {
            ItemViewModel aItem = itemListView.SelectedItems[0].Tag as ItemViewModel;

            if (aItem != null)
            {
                hiddenIdItem.Text = aItem.Id.ToString();
                companyItemComboBox.SelectedValue = aItem.CompanyId;
                categoryItemComboBox.SelectedValue = aItem.CategoryId;
                itemNameItemTextBox.Text = aItem.ItemName;
                reorderLevelItemTextBox.Text = aItem.ItemReorderLevel.ToString();

                saveItemButton.Text = "Edit";

                saveItemButton.Enabled = true;
                deleteItemButton.Enabled = true;

            }
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            int deletedId = Convert.ToInt32(hiddenIdItem.Text);

            string message = aItemManager.DeleteItemManager(deletedId);

            MessageBox.Show(message);

            companyItemComboBox.SelectedValue = -1;
            categoryItemComboBox.SelectedValue = -1;
            itemNameItemTextBox.Clear();
            reorderLevelItemTextBox.Clear();
            hiddenIdItem.Text = String.Empty;

            PopulateItems();

            saveItemButton.Text = "Save";
            deleteItemButton.Enabled = false;
        }

    }
}
