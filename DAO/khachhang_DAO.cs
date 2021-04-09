using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DTO;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{

    public class khachhang_DAO
    {
        private static khachhang_DAO instance;
        public static khachhang_DAO Instance
        {
            get { if (instance == null) instance = new khachhang_DAO(); return khachhang_DAO.instance; }
            private set { khachhang_DAO.instance = value; }
        }
        public DataTable loadkhachhang()
        {
            string query = "SELECT * FROM t_khachhang";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
        public bool themkhachhang(khachhang_DTO kh)
        {
            string query = "INSERT INTO t_khachhang VALUES(N'" +kh.Makh +"',N'" +kh.Tenkh + "',N'" + kh.Ngaysinh + "',N'" + kh.Gioitinh + "',N'" + kh.Sdt + "',N'" + kh.Cmnd + "',N'" + kh.Quoctich + "',N'" + kh.Email + "')";
            if (processdata.Instance.ExecuteNonQuery(query))
            return true;
            else return false;
        }
        public bool suakhachhang(khachhang_DTO kh)
        {
            string query = "UPDATE t_khachhang SET ID=N'" + kh.Makh + "',Ten=N'" + kh.Tenkh + "',Ngaysinh=N'" + kh.Ngaysinh + "',Gioitinh=N'" +kh.Gioitinh+ "',Sdt=N'" + kh.Sdt + "',Cmnd=N'" + kh.Cmnd + "',Quoctich=N'" + kh.Quoctich + "',Email=N'" + kh.Email + "'where ID='" + kh.Temp + "'";
            if (processdata.Instance.ExecuteNonQuery(query))
             return true;
            else return false;
        }
        public bool xoakhachhang(khachhang_DTO kh)
        {
            string query = "DELETE FROM t_khachhang WHERE ID ='" + kh.Makh + "'";
            if (processdata.Instance.ExecuteNonQuery(query))
                return true;
            else return false;
        }
        public DataTable timkhachhang(khachhang_DTO kh)
        {
            string query = "SELECT * FROM t_khachhang WHERE ID like N'%" + kh.Key + "%' or Ten like N'%" + kh.Key + "%' or Sdt like N'%" + kh.Key + "%' or CMND like N'%" + kh.Key + "%'";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
        public bool checktrung(string querycheck)
        {
            if ((int)processdata.Instance.ExecuteScalar(querycheck) == 1)
                return true;
            else { return false; }
        }
    }
}
