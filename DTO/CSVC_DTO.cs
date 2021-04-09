using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CSVC_DTO
    {
        private string temp;
        private string id;
        private string name;
        private string idloaiphong;
        private string idcsvc;
        private string soluong;

        public string Temp { get => temp; set => temp = value; }
        public string Id { get => id; set => id = value; }
        public string Idloaiphong { get => idloaiphong; set => idloaiphong = value; }
        public string Idcsvc { get => idcsvc; set => idcsvc = value; }
        public string Soluong { get => soluong; set => soluong = value; }
        public string Name { get => name; set => name = value; }

        public CSVC_DTO(string temp)
        {
            this.Temp = temp;
        }
        public CSVC_DTO(string idloaiphong,string idcsvc,string soluong)
        {
            this.Idloaiphong = idloaiphong;
            this.Idcsvc = idcsvc;
            this.Soluong = soluong;
        }
        public CSVC_DTO(string idloaiphong, string idcsvc, string soluong,string id)
        {
            this.Idloaiphong = idloaiphong;
            this.Idcsvc = idcsvc;
            this.Soluong = soluong;
            this.Id = id;
        }
        public CSVC_DTO( string id,string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
