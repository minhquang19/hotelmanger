using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DTO;
using System.Threading.Tasks;

namespace DAO
{
    public class loadroom_DAO
    {
        private static loadroom_DAO instance;

        public static loadroom_DAO Instance
        {
            get { if (instance == null) instance = new loadroom_DAO(); return loadroom_DAO.instance; }
            private set { loadroom_DAO.instance = value; }
        }
        public DataTable loadphong()
        {
            string query = "SELECT t_phong.ID,t_phong.Tenphong,t_loaiphong.Tenloaiphong,t_tinhtrang.Tentinhtrang FROM  t_phong,t_loaiphong,t_tinhtrang WHERE t_phong.Idloai = t_loaiphong.IDLP and t_phong.Idtinhtrang = t_tinhtrang.ID";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable loadloaiphong()
        {
            string query = "SELECT * FROM t_loaiphong";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable loadcsvc()
        {
            string query = "SELECT * FROM t_cosovatchat";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable loadtinhtrang()
        {
            string query = "SELECT * FROM t_tinhtrang";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        } 
        public bool addphong(loadroom_DTO room)
        {
            string query = "INSERT INTO t_phong VALUES(N'" + room.Id + "',N'" + room.Name + "'," + room.Type + "," + room.Status + ")";
            if (processdata.Instance.ExecuteNonQuery(query))
            return true;
            else return false;
        }
        public bool checktrung(string querycheck)
        {
            if((int)processdata.Instance.ExecuteScalar(querycheck) ==1 )
            return true;
            else { return false; }
        }
        public bool suaphong(loadroom_DTO room)
        {

            string query = "UPDATE t_phong SET ID=N'" + room.Id + "',Tenphong=N'" + room.Name + "',Idloai=N'" +room.Type + "',Idtinhtrang=N'" + room.Status + "'where ID='" + room.Temp + "'";
            if (processdata.Instance.ExecuteNonQuery(query))
            return true;
            else return false;
        }
        public bool xoaphong(loadroom_DTO room)
        {
            string query = "DELETE FROM t_phong WHERE ID ='" + room.Id + "'";
            if (processdata.Instance.ExecuteNonQuery(query))
            return true;
            else return false;
        }
        public DataTable timphong(loadroom_DTO room)
        {
            string query = "SELECT * FROM t_phong WHERE ID like N'" + room.Key + "' or Tenphong like N'" + room.Key + "' ";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable load_dgvthuephong()
        {
            string query = "SELECT t_phong.Tenphong,t_khachhang.ID,t_khachhang.Ten,t_thuephong.Checkin FROM t_phong,t_khachhang,t_thuephong WHERE t_phong.ID = t_thuephong.Idphong and t_khachhang.ID = t_thuephong.Idkhachhang";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable load_hoadon()
        {
            string query = "SELECT * FROM t_hoadonthu";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable load_hoadon1(room_DTO r)
        {
            string query = "SELECT * FROM t_hoadonthu WHERE Idphong = '"+r.Temp+"'";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
    }
}
