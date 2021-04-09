using System;
using System.Collections.Generic;
using System.Linq;
using DTO;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class user_DAO
    {
        private static user_DAO instance;
        public static user_DAO Instance
        {
            get { if (instance == null) instance = new user_DAO(); return user_DAO.instance; }
            private set { user_DAO.instance = value; }
        }
        public DataTable load_user(user_DTO u)
        {
            string query = "SELECT t_users.Idnhanvien,t_users.PASS,t_nhanvien.Ten,t_nhanvien.Chucvu FROM t_users,t_nhanvien WHERE t_users.Idnhanvien = t_nhanvien.ID and t_users.ID =N'" + u.Temp + "'";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
        public bool update_pass(user_DTO u )
        {
            string query = "UPDATE t_users SET PASS = '" + u.Pass + "' WHERE ID=N'"+ u.Id +"' ";
            if (processdata.Instance.ExecuteNonQuery(query))
                return true;
            else return false;
        }
    }
}
