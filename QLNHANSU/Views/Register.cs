using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNHANSU.Controllers;
using QLNHANSU.Models;

namespace QLNHANSU.Views
{
    public partial class frmRegister : Form
    {
        public frmRegister()
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;
            string confirm = txtConfirm.Text;

            RegisterController controller = new RegisterController();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirm))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
            else if (password != confirm)
            {
                MessageBox.Show("Mật khẩu không trùng khớp. Vui lòng nhập lại.");
            }
            else
            {
                // Thực hiện đăng ký khi thông tin hợp lệ
                bool success = controller.RegisterUser(username, password);

                if (success)
                {
                    MessageBox.Show("Đăng ký thành công!");
                    this.Close();
                    this.Hide();
                    frmLogin formLogin = new frmLogin();
                    formLogin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng ký không thành công. Vui lòng thử lại.");
                }
            }
        }
    }
}
