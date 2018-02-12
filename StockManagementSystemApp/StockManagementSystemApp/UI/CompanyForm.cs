using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using StockManagementSystemApp.Manager;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.UI
{
    public partial class CompanyForm : Form
    {
        public CompanyForm()
        {
            InitializeComponent();
        }

        private CompanyManager aCompanyManager = new CompanyManager();

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            PopulateAllCompany();
        }

        private void PopulateAllCompany()
        {
            companyListView.Items.Clear();
            int count = 0;
            List<Company> companys = aCompanyManager.GetAllCompanysManager();
            foreach (Company company in companys)
            {
                count++;
                ListViewItem item = new ListViewItem(count.ToString());
                item.SubItems.Add(company.CompanyName);
                item.Tag = company;
                companyListView.Items.Add(item);
            }
        }



        private void saveCompanyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(companyNameCompanyTextBox.Text))                                 // checking is nametextbox is empty or not
            {
                MessageBox.Show("Write Company Name Please!");
                return;                                                                 // when we write return it go out from the method without executing further.
            }

            Company aCompany = new Company();

            aCompany.CompanyName = companyNameCompanyTextBox.Text.ToUpper();

            if (saveCompanyButton.Text == "Save")
            {
                string message = aCompanyManager.SaveCompanyManager(aCompany);

                MessageBox.Show(message);
            }
            else
            {
                aCompany.Id = Convert.ToInt32(hiddenIdCompany.Text);

                string message = aCompanyManager.UpdateCompanyManager(aCompany);

                MessageBox.Show(message);

                saveCompanyButton.Text = "Save";
                deleteCompanyButton.Enabled = false;
            }

            PopulateAllCompany();
        }

        private void companyListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Company aCompany = companyListView.SelectedItems[0].Tag as Company;

            if (aCompany != null)
            {
                hiddenIdCompany.Text = aCompany.Id.ToString();
                companyNameCompanyTextBox.Text = aCompany.CompanyName;
                saveCompanyButton.Text = "Edit";
                saveCompanyButton.Enabled = true;
                deleteCompanyButton.Enabled = true;
            }
        }

        private void resetCompanyButton_Click(object sender, EventArgs e)
        {
            companyNameCompanyTextBox.Clear();
            hiddenIdCompany.Text = String.Empty;
            saveCompanyButton.Text = "Save";
            deleteCompanyButton.Enabled = false;
        }

        private void deleteCompanyButton_Click(object sender, EventArgs e)
        {
            int deletedId = Convert.ToInt32(hiddenIdCompany.Text);

            string message = aCompanyManager.DeleteCompanyManager(deletedId);

            MessageBox.Show(message);


            companyNameCompanyTextBox.Clear();
            hiddenIdCompany.Text = String.Empty;

            PopulateAllCompany();

            saveCompanyButton.Text = "Save";
            deleteCompanyButton.Enabled = false;
        }


 



    }
}
