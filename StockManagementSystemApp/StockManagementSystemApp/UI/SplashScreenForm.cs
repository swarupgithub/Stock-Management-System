using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystemApp.UI
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LogInForm aLoginUi = new LogInForm();
            progressBar1.Visible = true;

            this.progressBar1.Value = this.progressBar1.Value + 2;
            if (this.progressBar1.Value == 10)
            {
                label1.Text = "Reading modules..";
            }
            else if (this.progressBar1.Value == 20)
            {
                label1.Text = "Turning on modules.";
            }
            else if (this.progressBar1.Value == 40)
            {
                label1.Text = "Starting modules..";
            }
            else if (this.progressBar1.Value == 60)
            {
                label1.Text = "Loading modules..";
            }
            else if (this.progressBar1.Value == 80)
            {
                label1.Text = "Done Loading modules..";
            }
            else if (this.progressBar1.Value == 100)
            {
                aLoginUi.Show();
                timer1.Enabled = false;
                this.Hide();
            }
        }
    }
}
