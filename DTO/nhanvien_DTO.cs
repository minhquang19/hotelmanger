using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class nhanvien_DTO
    {
        #region KHAI BAO
        private string id;
        private string ten;
        private string ngaysinh;
        private string gioitinh;
        private string sdt;
        private string chucvu;
        private string bophan;
        private string temp;
        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Bophan { get => bophan; set => bophan = value; }
        public string Temp { get => temp; set => temp = value; }
        #endregion
        public nhanvien_DTO(string temp)
        {
            this.Temp = temp;
        }
        public nhanvien_DTO(string id,string ten,string ngaysinh,string gioitinh,string sdt,string chucvu,string bophan)
        {
            this.Id = id;
            this.Ten = ten;
            this.Ngaysinh = ngaysinh;
            this.Gioitinh = gioitinh;
            this.Sdt = sdt;
            this.Chucvu = chucvu;
            this.Bophan = bophan;
        }    
    }
}
