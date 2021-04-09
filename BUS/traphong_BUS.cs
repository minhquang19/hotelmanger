using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class traphong_BUS
    {
        private static traphong_BUS instance;
        public static traphong_BUS Instance
        {
            get { if (instance == null) instance = new traphong_BUS(); return traphong_BUS.instance; }
            private set { traphong_BUS.instance = value; }
        }
        public DataTable load_thuephong(traphong_DTO tp)
        {
            return traphong_DAO.Instance.load_thuephong(tp);
        }
        public DataTable load_kh(traphong_DTO tp)
        {
            return traphong_DAO.Instance.load_kh(tp);
        }
        public DataTable load_phithue(traphong_DTO phithue)
        {
            return traphong_DAO.Instance.load_phithue(phithue);
        }
        public DataTable load_phidv(traphong_DTO phithue)
        {
            return traphong_DAO.Instance.load_phidv(phithue);
        }
        public DataTable load_dgv(traphong_DTO phithue)
        {
            return traphong_DAO.Instance.load_dgv(phithue);
        }
        public bool traphong_sua(traphong_DTO phithue)
        {
            return traphong_DAO.Instance.traphong_sua(phithue);
        }
        public bool thembill(traphong_DTO bill)
        {
            return traphong_DAO.Instance.thembill(bill);
        }
        public bool thanhtoan(traphong_DTO bill)
        {
            return traphong_DAO.Instance.thanhtoan(bill);
        }
        public bool xoathuephong(traphong_DTO bill)
        {
            return traphong_DAO.Instance.xoathuephong(bill);
        }
        public bool donphong(traphong_DTO bill)
        {
            return traphong_DAO.Instance.donphong(bill);
        }
    }
}
