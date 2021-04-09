using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class nhanvien_DAO
    {
        private static nhanvien_DAO instance;
        public static nhanvien_DAO Instance
        {
            get { if (instance == null) instance = new nhanvien_DAO(); return nhanvien_DAO.instance; }
            private set { nhanvien_DAO.instance = value; }
        }
        public DataTable load_dgv()
        {
            string query = "SELECT * FROM t_nhanvien";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
        public bool themnhanvien(nhanvien_DTO nv)
        {
            string query = "INSERT INTO t_nhanvien VALUES(N'" +nv.Id + "',N'" + nv.Ten + "',N'" + nv.Ngaysinh + "',N'" + nv.Gioitinh + "',N'" + nv.Sdt + "',N'" + nv.Chucvu + "',N'" + nv.Bophan + "')";
            if (processdata.Instance.ExecuteNonQuery(query))
                return true;
            else return false;
        }    
        public bool xoanhanvien(nhanvien_DTO nv)
        {
            string query = "DELETE FROM t_nhanvien WHERE ID = N'" + nv.Temp + "'";
            if (processdata.Instance.ExecuteNonQuery(query))
                return true;
            else return false;
        }    
        public bool suanhanvien(nhanvien_DTO nv)
        {
            string query = "UPDATE t_nhanvien SET Ten=N'" + nv.Ten + "', Ngaysinh =N'" + nv.Ngaysinh + "',Gioitinh =N'" + nv.Gioitinh + "',Sdt=N'" + nv.Sdt + "',Chucvu =N'" + nv.Chucvu + "',Bophan =N'" + nv.Chucvu + "' WHERE ID =N'"+nv.Id+"'";
            if (processdata.Instance.ExecuteNonQuery(query))
                return true;
            else return false;
        }    
        public DataTable timnhanvien(nhanvien_DTO nv)
        {
            string query = "SELECT * FROM t_nhanvien WHERE Ten like N'%" + nv.Temp + "%' or Ngaysinh like N'%" + nv.Temp + "%'or Gioitinh like N'%" + nv.Temp + "%' or Sdt like N'%" + nv.Temp + "%' or Chucvu like N'%" + nv.Temp+ "%' or Bophan like N'%" + nv.Temp + "%' or ID like N'%" + nv.Temp + "%'";
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
