using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class dichvu_DAO
    {
        private static dichvu_DAO instance;
        public static dichvu_DAO Instance
        {
            get { if (instance == null) instance = new dichvu_DAO(); return dichvu_DAO.instance; }
            private set { dichvu_DAO.instance = value; }
        }
        public DataTable loadkh(dichvu_DTO dv)
        {
            string query = "SELECT * FROM t_thuephong WHERE Idphong = '" +dv.Temp + "'";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable loadloaidv()
        {
            string query = "SELECT * FROM t_loaidichvu ";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable loaddv(dichvu_DTO dv)
        {
            string query = "SELECT * FROM t_dichvu WHERE Idloai = N'"+dv.Temp+"'";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable load_dgv(dichvu_DTO dv)
        {
            string query = "SELECT t_sudungdichvu.ID,t_loaidichvu.Ten,t_dichvu.Ten,t_dichvu.Dongia,t_sudungdichvu.Soluong FROM t_loaidichvu,t_thuephong,t_dichvu,t_sudungdichvu WHERE t_thuephong.ID =t_sudungdichvu.Idthuephong  and t_loaidichvu.ID = t_dichvu.Idloai and t_dichvu.ID = t_sudungdichvu.Iddichvu and t_thuephong.ID ='"+ dv.Int_temp +"'";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
        public bool themdichvu(dichvu_DTO dv)
        {
            string query = "INSERT INTO t_sudungdichvu VALUES('" + dv.Idthuephong + "','" + dv.Iddichvu + "','" + dv.Soluong + "')";
            if (processdata.Instance.ExecuteNonQuery(query))
            return true;
            else return false;
        }
        public bool xoadichvu(dichvu_DTO dv)
        {
            string query = "DELETE FROM t_sudungdichvu WHERE ID= '" + dv.Int_temp + "'";
            if (processdata.Instance.ExecuteNonQuery(query))
            return true;
            else return false;
        }
        public bool suadichvu(dichvu_DTO dv)
        {
            string query = "UPDATE t_sudungdichvu SET Soluong=N'" +dv.Soluong + "',Iddichvu=N'" + dv.Iddichvu + "' WHERE ID = "+dv.Idthuephong+"";
            if (processdata.Instance.ExecuteNonQuery(query))
            return true;
            else return false;
        }
    }
}
