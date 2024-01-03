using QLNHANSU.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNHANSU.Controllers
{
    internal class LoginController
    {
        public static bool AuthenticateUser(string username, string password)
        {

            string query = "SELECT COUNT(*) FROM USERS WHERE USERNAME = @USERNAME AND PASSWORD = @PASSWORD";
            using (SqlConnection conn = DataHelper.getConnection())
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@USERNAME", username);
                    command.Parameters.AddWithValue("@PASSWORD", password);
                    conn.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
