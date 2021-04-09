using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class khachhang_BUS
    {
        private static khachhang_BUS instance;

        public static khachhang_BUS Instance
        {
            get { if (instance == null) instance = new khachhang_BUS(); return khachhang_BUS.instance; }
            private set { khachhang_BUS.instance = value; }
        }
        public DataTable loadkhachhang()
        {
            return khachhang_DAO.Instance.loadkhachhang();
        }    
        public bool themkhachhang(khachhang_DTO kh)
        {
            return khachhang_DAO.Instance.themkhachhang(kh);
        }    
        public bool xoakhachhang(khachhang_DTO kh)
        {
            return khachhang_DAO.Instance.xoakhachhang(kh);
        }    
        public bool suakhachhang(khachhang_DTO kh)
        {
            return khachhang_DAO.Instance.suakhachhang(kh);
        }
        public DataTable timkhachhang(khachhang_DTO kh)
        {
            return khachhang_DAO.Instance.timkhachhang(kh);
        }
        public bool checktrung(string querycheck)
        {
            return loadroom_DAO.Instance.checktrung(querycheck);
        }

    }
}
