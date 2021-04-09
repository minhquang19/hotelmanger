using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class hethong_DAO
    {
        private static hethong_DAO instance;
        public static hethong_DAO Instance
        {
            get { if (instance == null) instance = new hethong_DAO(); return hethong_DAO.instance; }
            private set { hethong_DAO.instance = value; }
        }
        public DataTable load_dgv()
        {
            string query = "SELECT t_users.ID,t_users.PASS,t_users.Idnhanvien,t_nhanvien.Ten,t_nhanvien.Chucvu FROM t_users,t_nhanvien WHERE t_users.Idnhanvien = t_nhanvien.ID ";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }    
    }
}
