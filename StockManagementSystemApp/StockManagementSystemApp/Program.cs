using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystemApp.UI;

namespace StockManagementSystemApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SearchViewItemSummaryForm());
            Application.Run(new MenuForm());
            //Application.Run(new SplashScreenForm());
            //Application.Run(new CompanyForm());
            //Application.Run(new CategoryForm());
            //Application.Run(new ItemForm());
            //Application.Run(new SearchViewItemSummaryForm());
            Application.Run(new StockOutForm());
            
        }
    }
}
