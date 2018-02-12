using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.Gateway
{
    class UserGateway
    {
        private string conString = ConfigurationManager.ConnectionStrings["stockManagementSystemConnection"].ConnectionString;

        private SqlConnection connection;
        private string query;
        private SqlCommand command;
        private SqlDataReader reader;

        public UserGateway()
        {
            connection = new SqlConnection(conString);
        }

        public bool IsUserGateway(User aUser)
        {
            query = "Select user_name,password From userlogin Where user_name=@d1 And password=@d2";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@d1", aUser.UserName);
            command.Parameters.AddWithValue("@d2", aUser.UserPassword);
            connection.Open();

            reader = command.ExecuteReader();
            bool isUser = reader.HasRows;
            reader.Close();

            connection.Close();
            return isUser;
        }
    }
}
