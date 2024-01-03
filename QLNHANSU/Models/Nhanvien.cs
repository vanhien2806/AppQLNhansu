using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNHANSU.Models
{
    internal class Nhanvien
    {
        public string Manv;
        public string Tennv;
        public string Gioitinh;
        public string Diachi;
        public string Sdt;
        public string Email;
        public string Mapb;
        
        public string getManv()
        {
            return Manv;
        }
        public string getTennv()
        {
            return Tennv;
        }
        public string getGioitinh()
        {
            return Gioitinh;
        }
        public string getDiachi()
        {
            return Diachi;
        }
        public string getSdt()
        {
            return Sdt;
        }
        public string getEmail()
        {
            return Email;
        }
        public string getMapb()
        {
            return Mapb;
        }
        public void setManv(string  manv)
        {
            this.Manv = manv;
        }
        public void setTennv(string tennv)
        {
            this.Tennv = tennv;
        }
        public void setGioitinh(string gioitinh)
        {
            this.Gioitinh = gioitinh;
        }
        public void setDiachi(string diachi)
        {
            this.Diachi = diachi;   
        }
        public void setSdt(string sdt)
        {
            this.Sdt = sdt;
        }
        public void setEmail(string email)
        {
            this.Email = email;
        }
        public void setMapb(string mapb)
        {
            this.Mapb = mapb;
        }
        public Nhanvien() { }
        public Nhanvien(string manv, string tennv, string gioitinh, string diachi, string sdt, string email, string mapb)
        {
            Manv = manv;
            Tennv = tennv;
            Gioitinh = gioitinh;
            Diachi = diachi;
            Sdt = sdt;
            Email = email;
            Mapb = mapb;
        }
    }
}
