using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using QLNHANSU.Controllers;

namespace QLNHANSU.Views
{
    public partial class frmNguoidung : Form
    {
        public frmNguoidung()
        {
            InitializeComponent();
            // Đường dẫn đến tệp hình ảnh
            string imagePath = "D:\\tự học\\QLNHANSU\\QLNHANSU\\Publics\\font.png";
            string imagePath2 = "D:\\tự học\\QLNHANSU\\QLNHANSU\\Publics\\nguoidung.png";

            // Đặt hình ảnh cho PictureBox
            pictureBox1.Image = Image.FromFile(imagePath);
            pictureBox2.Image = Image.FromFile(imagePath2);

            // Đặt kích thước PictureBox bằng kích thước của form
            pictureBox1.Size = this.Size;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;


            // Đẩy PictureBox về phía sau form
            pictureBox1.SendToBack();
            UserController controller = new UserController();
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            frmTrangchu formtranchu = new frmTrangchu();
            formtranchu.ShowDialog();
        }


    }
}
