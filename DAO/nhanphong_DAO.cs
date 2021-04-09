using System;
using System.Collections.Generic;
using System.Linq;
using DTO;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class nhanphong_DAO
    {
        private static nhanphong_DAO instance;

        public static nhanphong_DAO Instance
        {
            get { if (instance == null) instance = new nhanphong_DAO(); return nhanphong_DAO.instance; }
            private set { nhanphong_DAO.instance = value; }
        }
        public bool themkh(nhanphong_DTO kh)
        {
            string query = "INSERT INTO t_thuephong(Idphong,Idkhachhang,Checkin) VALUES(N'" + kh.Idphong + "',N'" + kh.Makh + "',N'" + kh.Checkin + "')";
            if (processdata.Instance.ExecuteNonQuery(query))
            return true;
            else return false;
        }
        public DataTable loadcombo()
        {
            string query = "SELECT * FROM t_khachhang";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
        public bool suatinhtrang(nhanphong_DTO kh)
        {
            string query = " UPDATE t_phong SET Idtinhtrang= 2 WHERE t_phong.ID ='"+ kh.Idphong+"' ";
            if (processdata.Instance.ExecuteNonQuery(query))
                return true;
            else return false;
        }
        public DataTable getmakh(nhanphong_DTO kh)
        {
            string query = "SELECT * FROM t_khachhang WHERE ID=N'" +kh.Makh+ "'";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
    }
}
