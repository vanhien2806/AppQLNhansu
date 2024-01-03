using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHANSU.Views
{
    public partial class frmTrangchu : Form
    {
        public frmTrangchu()
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            frmLogin formLogin = new frmLogin();
            formLogin.ShowDialog();
        }

        private void Menu_Item_Nhansu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhanvien formNhanvien = new frmNhanvien();
            formNhanvien.ShowDialog();
        }

        private void Menu_Item_Nguoidung_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNguoidung formNguoidung = new frmNguoidung();
            formNguoidung.ShowDialog();
        }
    }
}
