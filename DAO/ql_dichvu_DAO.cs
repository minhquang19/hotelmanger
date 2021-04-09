using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ql_dichvu_DAO
    {
        private static ql_dichvu_DAO instance;

        public static ql_dichvu_DAO Instance
        {
            get { if (instance == null) instance = new ql_dichvu_DAO(); return ql_dichvu_DAO.instance; }
            private set { ql_dichvu_DAO.instance = value; }
        }
        public DataTable load_dgv()
        {
            string query = "SELECT t_dichvu.ID,t_loaidichvu.Ten,t_dichvu.Ten,t_dichvu.Dongia FROM t_dichvu,t_loaidichvu WHERE t_dichvu.Idloai = t_loaidichvu.ID";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
        public bool themdichvu(ql_dichvu_DTO qldv)
        {
            string query = "INSERT INTO t_dichvu VALUES(N'" + qldv.Tendv + "',N'" + qldv.Idloai + "',N'" + qldv.Gia + "')";
            if (processdata.Instance.ExecuteNonQuery(query))
                return true;
            else return false;
        }
        public bool xoadichvu(ql_dichvu_DTO qldv)
        {
            string query = "DELETE FROM t_dichvu WHERE ID = '"+qldv.Temp+"'";
            if (processdata.Instance.ExecuteNonQuery(query))
                return true;
            else return false;
        }
        public bool suadichvu(ql_dichvu_DTO qldv)
        {
            string query = "UPDATE t_dichvu SET Ten=N'"+qldv.Tendv+"',Idloai=N'"+qldv.Idloai+"',Dongia =N'"+qldv.Gia+"' WHERE ID ='"+qldv.Madv+"'";
            if (processdata.Instance.ExecuteNonQuery(query))
                return true;
            else return false;
        }
        public DataTable timdichvu(ql_dichvu_DTO qldv)
        {
            string query = "SELECT * FROM t_dichvu WHERE ID like N'%" +qldv.Temp+ "%' or Ten like N'%" + qldv.Temp + "%'  or Dongia like N'%" + qldv.Temp + "%' or Idloai like N'%" + qldv.Temp + "%'";
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
