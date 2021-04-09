using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class user_DTO
    {
        private string id;
        private string pass;
        private string temp;
        public user_DTO(string temp)
        {
            this.Temp = temp;
        }
        public user_DTO(string id,string pass)
        {
            this.Id = id;
            this.Pass = pass;
        }
        public string Temp { get => temp; set => temp = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Id { get => id; set => id = value; }
    }
}
