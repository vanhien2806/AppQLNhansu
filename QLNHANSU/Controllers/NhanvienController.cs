using QLNHANSU.Models;
using QLNHANSU.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHANSU.Controllers
{
    internal class NhanvienController
    {
        List<Nhanvien> nvList;
        public NhanvienController()
        {
            nvList = new List<Nhanvien>();
        }
        public List<Nhanvien> load()
        {
            SqlConnection conn = DataHelper.getConnection();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NHANVIEN", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String manv = reader["MANV"].ToString();
                    String tennv = reader["TENNV"].ToString();
                    String gioitinh = reader["GIOITINH"].ToString();
                    String diachi = reader["DIACHI"].ToString();
                    String sdt = reader["SDT"].ToString();
                    String email = reader["EMAIL"].ToString();
                    String mapb = reader["MAPB"].ToString();

                    Nhanvien nv = new Nhanvien(manv, tennv, gioitinh, diachi, sdt, email,mapb);
                    nvList.Add(nv);

                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return nvList;
        }
        public Nhanvien get(string manv)
        {
            return nvList.FirstOrDefault(h => h.getManv() == manv);
        }
        public bool insert(Nhanvien nv)
        {
            SqlConnection conn = DataHelper.getConnection();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO NHANVIEN (MANV, TENNV, GIOITINH, DIACHI, SDT, EMAIL, MAPB) VALUES (@Ma_Nhan_Vien, @Ten_Nhan_Vien,@Gioi_Tinh,@Dia_Chi,@So_Dien_Thoai,@Email,@Mapb)", conn);
                cmd.Parameters.AddWithValue("@Ma_Nhan_Vien", nv.getManv());
                cmd.Parameters.AddWithValue("@Ten_Nhan_Vien", nv.getTennv());
                cmd.Parameters.AddWithValue("@Gioi_Tinh", nv.getGioitinh());
                cmd.Parameters.AddWithValue("@Dia_Chi", nv.getDiachi());
                cmd.Parameters.AddWithValue("@So_Dien_Thoai", nv.getSdt());
                cmd.Parameters.AddWithValue("@Email", nv.getEmail());
                cmd.Parameters.AddWithValue("@Mapb", nv.getMapb());

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Thêm thành công
                    return true;
                }
                else
                {
                    // Thêm không thành công
                    return false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool update(Nhanvien nv)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE NHANVIEN SET TENNV = @Ten_Nhan_Vien, GIOITINH= @Gioi_Tinh, DIACHI = @Dia_Chi, SDT = @So_Dien_Thoai, EMAIL = @Email, MAPB = @Mapb WHERE MANV= @Ma_Nhan_Vien", conn);
                cmd.Parameters.AddWithValue("@Ma_Nhan_Vien", nv.getManv());
                cmd.Parameters.AddWithValue("@Ten_Nhan_Vien", nv.getTennv());
                cmd.Parameters.AddWithValue("@Gioi_Tinh", nv.getGioitinh());
                cmd.Parameters.AddWithValue("@Dia_Chi", nv.getDiachi());
                cmd.Parameters.AddWithValue("@So_Dien_Thoai", nv.getSdt());
                cmd.Parameters.AddWithValue("@Email", nv.getEmail());
                cmd.Parameters.AddWithValue("@Mapb", nv.getMapb());

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {

                    return true;
                }
                else
                {

                    return false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool delete(string manv)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM NHANVIEN WHERE MANV =@Ma_Nhan_Vien", conn);
                cmd.Parameters.AddWithValue("@Ma_Nhan_Vien", manv);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


    }

}
