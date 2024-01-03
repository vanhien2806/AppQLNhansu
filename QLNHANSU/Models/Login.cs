using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNHANSU.Models
{
    internal class Login
    {
        public int Id;
        public string Username;
        public string Password;

        public int getId()
        {
            return Id;
        }
        public string getUsername()
        {
            return Username;
        }
        public string getPassword()
        {
            return Password;
        }
        public void setId(int id)
        {
            this.Id = id;
        }
        public void setUsername(string uername)
        {
            this.Username = uername;
        }
        public void setPassword(string password)
        {
            this.Password = password;
        }


        public Login() { }
        public Login(string username, string password) { }

    }
}
