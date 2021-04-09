using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class hethong_DTO
    {
        private string temp;
        public string Temp { get => temp; set => temp = value; }
        public hethong_DTO (string temp)
        {
            this.Temp = temp;
        }
    }
}
