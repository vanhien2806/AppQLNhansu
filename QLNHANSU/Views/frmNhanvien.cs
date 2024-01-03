using QLNHANSU.Models;
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

namespace QLNHANSU.Views
{
    public partial class frmNhanvien : Form
    {
        NhanvienController nvController;
        List<Nhanvien> dsnv;
        Nhanvien currentnv;
        public frmNhanvien()
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

            nvController = new NhanvienController();
            dsnv = new List<Nhanvien>();
            currentnv = new Nhanvien();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dsnv.Clear();
            dsnv = nvController.load();
            dataGridNV.Rows.Clear();

            foreach (Nhanvien nv in dsnv)
            {
                string[] row = { nv.getManv(), nv.getTennv(), nv.getGioitinh(), nv.getDiachi(), nv.getSdt(), nv.getEmail(), nv.getMapb() };
                dataGridNV.Rows.Add(row);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // thêm mới
            currentnv = new Nhanvien(txtManv.Text, txtTennv.Text, cbGt.Text, txtDiachi.Text, txtSdt.Text, txtEmail.Text, txtMapb.Text);
            nvController.insert(currentnv);
            //them cai kho moi vao datagridview
            string[] row = { currentnv.getManv(), currentnv.getTennv(), currentnv.getGioitinh(), currentnv.getDiachi(), currentnv.getSdt(), currentnv.getEmail(), currentnv.getMapb() };
            dataGridNV.Rows.Add(row);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dsnv.Clear();
            currentnv = new Nhanvien(txtManv.Text, txtTennv.Text, cbGt.Text, txtDiachi.Text, txtSdt.Text, txtEmail.Text, txtMapb.Text);
            nvController.update(currentnv);
            dataGridNV.Rows.Clear();
            dsnv = nvController.load();
            foreach (Nhanvien nv in dsnv)
            {
                string[] row = { nv.getManv(), nv.getTennv(), nv.getGioitinh(), nv.getDiachi(), nv.getSdt(), nv.getEmail(), nv.getMapb() };
                dataGridNV.Rows.Add(row);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string manv = txtManv.Text;
            nvController.delete(manv);
            foreach (DataGridViewRow row in dataGridNV.Rows)
            {

                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == manv)
                {
                    dataGridNV.Rows.Remove(row);
                    break;
                }
            }
        }
        private void dataGridNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridNV.Rows[e.RowIndex];
                txtManv.Text = selectedRow.Cells[0].Value.ToString();
                txtTennv.Text = selectedRow.Cells[1].Value.ToString();
                cbGt.Text = selectedRow.Cells[2].Value.ToString();
                txtDiachi.Text = selectedRow.Cells[3].Value.ToString();
                txtSdt.Text = selectedRow.Cells[4].Value.ToString();
                txtEmail.Text = selectedRow.Cells[5].Value.ToString();
                txtMapb.Text = selectedRow.Cells[6].Value.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            frmTrangchu formtrangchu = new frmTrangchu();
            formtrangchu.ShowDialog();
        }
    }
}
