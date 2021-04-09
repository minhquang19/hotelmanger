using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Threading.Tasks;
using System.Data;

namespace BUS
{
    public class nhanphong_BUS
    {
        private static nhanphong_BUS instance;

        public static nhanphong_BUS Instance
        {
            get { if (instance == null) instance = new nhanphong_BUS(); return nhanphong_BUS.instance; }
            private set { nhanphong_BUS.instance = value; }
        }
        public bool themphong(nhanphong_DTO kh)
        {
            return nhanphong_DAO.Instance.themkh(kh);
        }
        public bool suatinhtrang(nhanphong_DTO kh)
        {
            return nhanphong_DAO.Instance.suatinhtrang(kh);
        }
        public DataTable loadcombo()
        {
            return nhanphong_DAO.Instance.loadcombo();
        }
        public DataTable getmakh(nhanphong_DTO temp)
        {
            return nhanphong_DAO.Instance.getmakh(temp);
        }
    }
}
