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
    public class nhanvien_BUS
    {
        private static nhanvien_BUS instance;
        public static nhanvien_BUS Instance
        {
            get { if (instance == null) instance = new nhanvien_BUS(); return nhanvien_BUS.instance; }
            private set { nhanvien_BUS.instance = value; }
        }
        public DataTable load_dgv()
        {
            return nhanvien_DAO.Instance.load_dgv();
        }    

        public DataTable timnhanvien(nhanvien_DTO nv)
        {
            return nhanvien_DAO.Instance.timnhanvien(nv);
        }    
        public bool xoanhanvien(nhanvien_DTO nv)
        {
            return nhanvien_DAO.Instance.xoanhanvien(nv);
        }
        public bool themnhanvien(nhanvien_DTO nv)
        {
            return nhanvien_DAO.Instance.themnhanvien(nv);
        }
        public bool checktrung(string querycheck)
        {
            return nhanvien_DAO.Instance.checktrung(querycheck);
        }
        public bool suanhanvien(nhanvien_DTO nv)
        {
            return nhanvien_DAO.Instance.suanhanvien(nv);
        }
    }
}
