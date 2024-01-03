using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNHANSU.Utils;

namespace QLNHANSU.Controllers
{
    internal class UserController
    {
        public bool GetUserInfomation(string username, string password)
        {
            string query = "SELECT USERNAME FROM USERS WHERE USERNAME = @USERNAME AND PASSWORD = @PASSWORD";
            using (SqlConnection conn = DataHelper.getConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@USERNAME", username);
                    cmd.Parameters.AddWithValue("@PASSWORD", password);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string users = reader["USERNAME"].ToString();
                            string passw = reader["PASSWORD"].ToString();
                            Console.WriteLine("Username: " + users);
                            return true; // Trả về true nếu có dữ liệu phù hợp với username và password
                        }
                    }
                }
            }

            return false; // Trả về false nếu không có dữ liệu phù hợp
        }
    }
}
