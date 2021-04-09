using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class nhanphong_DTO
    {
        #region KHAI BAO
        private string makh;
        private string idphong;
        private string checkin;
        public string Makh { get => makh; set => makh = value; }
        public string Idphong { get => idphong; set => idphong = value; }
        public string Checkin { get => checkin; set => checkin = value; }
        public nhanphong_DTO(string makh)
        {
            this.Makh = makh;
        }
        #endregion
        public nhanphong_DTO(string makh,string idphong, string checkin)
        {
            this.Makh = makh;
            this.Idphong = idphong;
            this.Checkin = checkin;
        }

      
    }
}
