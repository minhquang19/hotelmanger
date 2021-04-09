using System;
using System.Collections.Generic;
using System.Data;
using DTO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public  class traphong_DAO
    {
        private static traphong_DAO instance;
        public static traphong_DAO Instance
        {
            get { if (instance == null) instance = new traphong_DAO(); return traphong_DAO.instance; }
            private set { traphong_DAO.instance = value; }
        }
        public DataTable load_thuephong(traphong_DTO tp)
        {
            string query = "SELECT * FROM t_thuephong WHERE Idphong = '" + tp.Temp + "'";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable load_kh(traphong_DTO tp)
        {
            string query = "SELECT * FROM t_khachhang WHERE ID = N'" + tp.Temp + "'";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable load_phithue(traphong_DTO phithue)
        {
            string query = "SELECT t_thuephong.ID,t_loaiphong.Gia,t_phong.ID,datediff(day,t_thuephong.Checkin,GETDATE()) AS 'Songay',(datediff(day,t_thuephong.Checkin,GETDATE())* t_loaiphong.Gia) AS 'Thuephong' FROM t_thuephong,t_loaiphong,t_phong WHERE t_thuephong.Idphong = t_phong.ID and t_phong.Idloai = t_loaiphong.IDLP and t_thuephong.ID = '" + phithue.Int_temp + "'";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable load_phidv(traphong_DTO dichvu)
        {
            string query = "SELECT t_loaidichvu.Ten,t_dichvu.Ten,t_dichvu.Dongia,t_sudungdichvu.Soluong,(t_sudungdichvu.Soluong * t_dichvu.Dongia) as 'Thanhtien' FROM t_sudungdichvu, t_dichvu, t_thuephong, t_loaidichvu WHERE t_sudungdichvu.Iddichvu = t_dichvu.ID and t_sudungdichvu.Idthuephong = t_thuephong.ID and t_loaidichvu.ID = t_dichvu.Idloai and t_thuephong.ID = " + dichvu.Int_temp + "";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable load_dgv(traphong_DTO dichvu)
        {
            string query = "SELECT t_loaidichvu.Ten,t_dichvu.Ten,t_dichvu.Dongia,t_sudungdichvu.Soluong,(t_sudungdichvu.Soluong * t_dichvu.Dongia) as 'Thanhtien' FROM t_sudungdichvu, t_dichvu, t_thuephong, t_loaidichvu WHERE t_sudungdichvu.Iddichvu = t_dichvu.ID and t_sudungdichvu.Idthuephong = t_thuephong.ID and t_loaidichvu.ID = t_dichvu.Idloai and t_thuephong.ID = "+dichvu.Int_temp+"";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result;
        }
        public bool traphong_sua(traphong_DTO dichvu)
        {
            string query = " UPDATE t_phong SET Idtinhtrang= 4 WHERE t_phong.ID ='" + dichvu.Temp + "' ";
            if (processdata.Instance.ExecuteNonQuery(query))
                return true;
            else return false;
        }
        public bool thembill(traphong_DTO bill)
        {
            string query = "INSERT INTO t_hoadonthu VALUES(N'" + bill.Idnhanvien + "',N'" + bill.Idkhachang + "',N'" + bill.Idphong + "',N'" + bill.Tongtien + "',N'" + bill.Ghichu + "',N'" + bill.Tienthuephong + "',N'" + bill.Tiendichvu + "',N'" + bill.Khuyenmai + "',N'" + bill.Date + "')";
            if (processdata.Instance.ExecuteNonQuery(query))
                return true;
            else return false;
        }
        public bool thanhtoan(traphong_DTO bill)
        {
            string query = "UPDATE t_hoadonthu SET Mota = 'Đã thanh toán' WHERE Idphong = '" + bill.Temp + "'";
            if (processdata.Instance.ExecuteNonQuery(query))
                return true;
            else return false;
        }
        public bool xoathuephong(traphong_DTO bill)
        {
            string query = "DELETE FROM t_thuephong WHERE ID = '"+ bill.Int_temp+ "'";
            if (processdata.Instance.ExecuteNonQuery(query))
                return true;
            else return false;
        }
        public bool donphong(traphong_DTO bill)
        {
            string query = " UPDATE t_phong SET Idtinhtrang= 1 WHERE t_phong.ID ='" +bill.Temp+ "' ";
            if (processdata.Instance.ExecuteNonQuery(query))
                return true;
            else return false;
        }

    }
}
