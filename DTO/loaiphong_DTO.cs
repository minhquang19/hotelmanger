using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class loaiphong_DTO
    {
        private string temp;
        private string id;
        private string ten;
        private string gia;
        private string songuoi;
        public string Temp { get => temp; set => temp = value; }
        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Gia { get => gia; set => gia = value; }
        public string Songuoi { get => songuoi; set => songuoi = value; }

        public loaiphong_DTO(string temp)
        {
            this.Temp = temp; 
        }
        public loaiphong_DTO(string ten,string gia,string songuoi)
        {
            this.Ten = ten;
            this.Gia = gia;
            this.Songuoi = songuoi;
        }
        public loaiphong_DTO(string ten, string gia, string songuoi,string id)
        {
            this.Ten = ten;
            this.Gia = gia;
            this.Songuoi = songuoi;
            this.Id = id;
        }
    }
}
