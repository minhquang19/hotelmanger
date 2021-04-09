using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class traphong_DTO
    {
        private string temp;
        private string idnhanvien;
        private string idkhachang;
        private string tienthuephong;
        private string tiendichvu;
        private string khuyenmai;
        private string idphong;
        private string tongtien;
        private string ghichu;
        private int int_temp;
        private string date;
        public string Temp { get => temp; set => temp = value; }
        public int Int_temp { get => int_temp; set => int_temp = value; }
        public string Idnhanvien { get => idnhanvien; set => idnhanvien = value; }
        public string Idkhachang { get => idkhachang; set => idkhachang = value; }
        public string Idphong { get => idphong; set => idphong = value; }
        public string Tongtien { get => tongtien; set => tongtien = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public string Tienthuephong { get => tienthuephong; set => tienthuephong = value; }
        public string Tiendichvu { get => tiendichvu; set => tiendichvu = value; }
        public string Khuyenmai { get => khuyenmai; set => khuyenmai = value; }
        public string Date { get => date; set => date = value; }

        public traphong_DTO(string temp)
        {
            this.Temp = temp;
        }
        public traphong_DTO(string  idnhanvien,string idkhachhang,string idphong,string tongtien,string ghichu,string tienthuephong,string tiendichvu,string khuyenmai,string date)
        {
            this.Idnhanvien = idnhanvien;
            this.Idkhachang = idkhachhang;
            this.Idphong = idphong;
            this.Tongtien = tongtien;
            this.Ghichu = ghichu;
            this.Tienthuephong = tienthuephong;
            this.Tiendichvu = tiendichvu;
            this.Khuyenmai = khuyenmai;
            this.Date = date;
        }
        public traphong_DTO(int temp)
        {
            this.Int_temp = temp;
        }
    }
}
