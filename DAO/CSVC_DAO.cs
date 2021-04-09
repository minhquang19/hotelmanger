using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CSVC_DAO
    {
        private static CSVC_DAO instance;
        public static CSVC_DAO Instance
        {
            get { if (instance == null) instance = new CSVC_DAO(); return CSVC_DAO.instance; }
            private set { CSVC_DAO.instance = value; }
        }
        public DataTable load_dgv(CSVC_DTO csvc)
        {
            string query = "SELECT t_phongvattu.ID,t_cosovatchat.Donvi,t_cosovatchat.Ten,t_phongvattu.Soluong FROM t_phongvattu,t_loaiphong,t_cosovatchat WHERE t_cosovatchat.ID = t_phongvattu.Idcosovatchat and t_loaiphong.IDLP = t_phongvattu.Idloaiphong and t_loaiphong.IDLP = N'" + csvc.Temp + "'";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
        public bool them_vattu(CSVC_DTO csvc)
        {
            string query = "INSERT INTO t_phongvattu VALUES(N'" + csvc.Idloaiphong + "',N'" + csvc.Idcsvc + "',N'" + csvc.Soluong + "')";
            if (processdata.Instance.ExecuteNonQuery(query))
                return true;
            else return false;
        }
        public bool xoa_vattu(CSVC_DTO csvc)
        {
            string query = "DELETE FROM t_phongvattu WHERE ID ='" + csvc.Temp + "'";
            if (processdata.Instance.ExecuteNonQuery(query))
                return true;
            else return false;
        }
        public bool sua_vattu(CSVC_DTO csvc)
        {
            string query = "UPDATE t_phongvattu SET Idloaiphong =N'" + csvc.Idloaiphong + "',Idcosovatchat =N'" + csvc.Idcsvc + "',Soluong =N'" + csvc.Soluong + "' WHERE ID ='"+csvc.Id+"'";
            if (processdata.Instance.ExecuteNonQuery(query))
                return true;
            else return false;
        }
        public bool them_csvc(CSVC_DTO csvc)
        {
            string query = "INSERT INTO t_cosovatchat VALUES(N'" + csvc.Id + "',N'" + csvc.Name + "')";
            if (processdata.Instance.ExecuteNonQuery(query))
                return true;
            else return false;
        }
        public bool xoa_csvc(CSVC_DTO csvc)
        {
            string query = "DELETE FROM t_cosovatchat WHERE ID ='" + csvc.Temp + "'";
            if (processdata.Instance.ExecuteNonQuery(query))
                return true;
            else return false;
        }
        public bool sua_csvc(CSVC_DTO csvc)
        {
            string query = "UPDATE t_cosovatchat SET ID =N'" + csvc.Idloaiphong + "',Ten =N'" + csvc.Idcsvc + "', Donvi=N'" + csvc.Soluong + "'";
            if (processdata.Instance.ExecuteNonQuery(query))
                return true;
            else return false;
        }

    }
}
