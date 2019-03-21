using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApp
{
    public class Login
    {   
        public string LoginName { get; set; }
        public string Passsword { get; set; }
        public string ImageUrl { get; set; }
        public bool RememberPsw { get; set; }
        public bool AutoLogin { get; set; }
    }
    public class User
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string IDCard { get; set; }
        public string Email { get; set; }
    }
}
