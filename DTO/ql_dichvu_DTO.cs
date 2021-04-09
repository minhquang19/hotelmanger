using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ql_dichvu_DTO
    {
        private string temp;
        private string madv;
        private string tendv;
        private string idloai;
        private string tenloai;
        private string gia;
        public string Temp { get => temp; set => temp = value; }
        public string Madv { get => madv; set => madv = value; }
        public string Tendv { get => tendv; set => tendv = value; }
        public string Idloai { get => idloai; set => idloai = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }
        public string Gia { get => gia; set => gia = value; }

        public ql_dichvu_DTO(string temp)
        {
            this.Temp = temp;
        }
        public ql_dichvu_DTO(string madv ,string tendv,string idloai,string gia)
        {
            this.Madv = madv;
            this.Tendv = tendv;
            this.Idloai = idloai;
            this.Gia = gia;
        }
    }
}
