using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNHANSU.Models
{
    internal class Register
    {
        public string User;
        public string Password;
        public string Confirm;
        public string getUser()
        {
            return User;
        }
        public string getPassword()
        {
            return Password;
        }
        public string getConfirm()
        {
            return Confirm;
        }
        public void setUser(string user)
        {
            this.User = user;
        }
        public void setPassword(string password)
        {
            this.Password = password;
        }
        public void setConfirm(string confirm)
        {
            this.Confirm = confirm;
        }
        public Register() { }
        public Register(string user, string password, string confirm)
        {
            this.User = user;
            this.Password = password;
            this.Confirm = confirm;
        }
    }
}
