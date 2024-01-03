using QLNHANSU.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNHANSU.Controllers
{
    internal class RegisterController
    {
        public bool RegisterUser(string username, string password)
        {
            string query = "INSERT INTO USERS (Username, Password) VALUES (@Username, @Password)";

            using (SqlConnection conn = DataHelper.getConnection())
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    

                    conn.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
