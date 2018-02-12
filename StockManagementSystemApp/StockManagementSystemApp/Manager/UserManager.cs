using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystemApp.Gateway;
using StockManagementSystemApp.Model;
using StockManagementSystemApp.UI;

namespace StockManagementSystemApp.Manager
{
    class UserManager
    {

        UserGateway aUserGateway= new UserGateway();
        private bool CheckUser;
        public string FindUser(User aUser)
        {
            CheckUser = aUserGateway.IsUserGateway(aUser);
            if (CheckUser == true)
            {
                return "Grant";
            }
            else
            {
                return "False";
            }
        }
       

    }
}
