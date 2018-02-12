using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using StockManagementSystemApp.Manager;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.UI
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private CategoryManager aCategoryManager = new CategoryManager();



        private void CategoryForm_Load(object sender, EventArgs e)
        {
            PopulateAllCategory();
        }

        private void PopulateAllCategory()
        {
            categoryListView.Items.Clear();

            int count = 0;

            List<Category> categories = aCategoryManager.GetAllCategoriesManager();

            foreach (Category category in categories)
            {
                count++;

                ListViewItem item = new ListViewItem(count.ToString());
                item.SubItems.Add(category.CategoryName);

                item.Tag = category;

                categoryListView.Items.Add(item);
            }
        }

        private void saveCategoryButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(categoryNameCategoryTextBox.Text))                                 // checking is nametextbox is empty or not
            {
                MessageBox.Show("First Enter Category Name Please");
                return;                                                                 // when we write return it go out from the method without executing further.
            }

            Category aCategory = new Category();
            aCategory.CategoryName = categoryNameCategoryTextBox.Text.ToUpper();

            if (saveCategoryButton.Text == "SAVE")
            {
                string message = aCategoryManager.SaveCategoryManager(aCategory);
                MessageBox.Show(message);
            }
            else
            {
                aCategory.Id = Convert.ToInt32(hiddenIdCategory.Text);
                string message = aCategoryManager.UpdateCategoryManager(aCategory);
                MessageBox.Show(message);
                saveCategoryButton.Text = "SAVE";
                deleteCategoryButton.Enabled = false;
            }

            PopulateAllCategory();
        }

        private void categoryListView_DoubleClick(object sender, EventArgs e)
        {
            Category aCategory = categoryListView.SelectedItems[0].Tag as Category;

            if (aCategory != null)
            {
                hiddenIdCategory.Text = aCategory.Id.ToString();
                categoryNameCategoryTextBox.Text = aCategory.CategoryName;

                saveCategoryButton.Text = "EDIT";

                saveCategoryButton.Enabled = true;
                deleteCategoryButton.Enabled = true;

            }
        }

        private void resetCategoryButton_Click(object sender, EventArgs e)
        {
            categoryNameCategoryTextBox.Clear();

            hiddenIdCategory.Text = String.Empty;

            saveCategoryButton.Text = "SAVE";
            deleteCategoryButton.Enabled = false;
        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            int deletedId = Convert.ToInt32(hiddenIdCategory.Text);

            string message = aCategoryManager.DeleteCategoryManager(deletedId);

            MessageBox.Show(message);


            categoryNameCategoryTextBox.Clear();
            hiddenIdCategory.Text = String.Empty;

            PopulateAllCategory();

            saveCategoryButton.Text = "SAVE";
            deleteCategoryButton.Enabled = false;
        }


   


    }
}
