using QLNHANSU.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNHANSU.Views;

namespace QLNHANSU
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            // Đường dẫn đến tệp hình ảnh
            string imagePath = "D:\\tự học\\QLNHANSU\\QLNHANSU\\Publics\\font.png";

            // Đặt hình ảnh cho PictureBox
            pictureBox1.Image = Image.FromFile(imagePath);


            // Đặt kích thước PictureBox bằng kích thước của form
            pictureBox1.Size = this.Size;


            // Đẩy PictureBox về phía sau form
            pictureBox1.SendToBack();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;

            string query = "SELECT COUNT(*) FROM USERS WHERE USERNAME = @Username AND PASSWORD = @Password";

            using (SqlConnection connection = DataHelper.getConnection()) 
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    int userCount = (int)command.ExecuteScalar();

                    if (userCount > 0)
                    {
                        // Đăng nhập thành công
                        MessageBox.Show("Đăng nhập thành công!");
                        // Thực hiện các hành động sau khi đăng nhập thành công
                        this.Hide();
                        frmTrangchu formtrangchu = new frmTrangchu();
                        formtrangchu.ShowDialog();
                    }
                    else
                    {
                        // Đăng nhập không thành công
                        MessageBox.Show("Thông tin đăng nhập không chính xác!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister formRegister = new frmRegister();
            formRegister.ShowDialog();  
        }
    }
    
}
