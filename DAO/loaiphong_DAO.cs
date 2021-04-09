using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class loaiphong_DAO
    {
        private static loaiphong_DAO instance;
        public static loaiphong_DAO Instance
        {
            get { if (instance == null) instance = new loaiphong_DAO(); return loaiphong_DAO.instance; }
            private set { loaiphong_DAO.instance = value; }
        }
        public DataTable load_dgv()
        {
            string query = "SELECT * FROM t_loaiphong";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
        public bool themloaiphong(loaiphong_DTO lp)
        {
            string query = "INSERT INTO t_loaiphong VALUES(N'" + lp.Ten + "',N'" + lp.Gia + "',N'" + lp.Songuoi + "')";
            if (processdata.Instance.ExecuteNonQuery(query))
                return true;
            else return false;
        }
        public bool xoaloaiphong(loaiphong_DTO lp)
        {
            string query = "DELETE FROM t_loaiphong WHERE IDLP= '" + lp.Temp + "'";
            if (processdata.Instance.ExecuteNonQuery(query))
                return true;
            else return false;
        }
        public bool sualoaiphong(loaiphong_DTO lp)
        {
            string query = "UPDATE t_loaiphong SET Tenloaiphong = N'" + lp.Ten + "',Gia =N'" + lp.Gia + "',Songuoi_MAX =N'" + lp.Songuoi + "' WHERE IDLP = '"+lp.Id+"'";
            if (processdata.Instance.ExecuteNonQuery(query))
                return true;
            else return false;
        }

    }
}
