using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class login_DTO
    {
        private string user;
        private string pass;
        public login_DTO() { }
        public login_DTO(string username,string password) 
        {
            this.User = username;
            this.Pass = password;
        }
        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
    }
}
