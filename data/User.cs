using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_G24.data
{
    public class User
    {
        public string email { get; set; }
        public string nameAccount { get; set; }
        public string password { get; set; }
        public string maxacnhan { get; set; }
        public User() { }

        public User(string email, string nameAccount, string password, string maXacnhan)
        {
            this.email = email;
            this.nameAccount = nameAccount;
            this.password = password;
            this.maxacnhan = maXacnhan;
        }
    }
}