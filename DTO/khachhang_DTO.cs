using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class khachhang_DTO
    {
        #region KHAI BAO
        private string makh;
        private string tenkh;
        private string ngaysinh;
        private string gioitinh;
        private string sdt;
        private string email;
        private string cmnd;
        private string quoctich;
        private string temp;
        private string key;
        public string Makh { get => makh; set => makh = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Quoctich { get => quoctich; set => quoctich = value; }
        public string Temp { get => temp; set => temp = value; }
        public string Key { get => key; set => key = value; }
        #endregion
        #region KHOI TAO
        public khachhang_DTO(string makh, string tenkh, string ngaysinh,string gioitinh, string sdt, string cmnd, string quoctich,string email,string temp)
        {
            this.Makh = makh;
            this.Tenkh = tenkh;
            this.Ngaysinh = ngaysinh;
            this.Gioitinh = gioitinh; 
            this.Sdt = sdt;
            this.Cmnd = cmnd;
            this.Quoctich = quoctich;
            this.Email = email;
            this.Temp = temp;
        }  
        public khachhang_DTO(string key)
        {
            this.Key = key;
        }
        #endregion
    }
}
