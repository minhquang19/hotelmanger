using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class dichvu_BUS
    {
        private static dichvu_BUS instance;
        public static dichvu_BUS Instance
        {
            get { if (instance == null) instance = new dichvu_BUS(); return dichvu_BUS.instance; }
            private set { dichvu_BUS.instance = value; }
        }
        public DataTable loadkh(dichvu_DTO dv)
        {
            return dichvu_DAO.Instance.loadkh(dv);
        }
        public DataTable loadloaidichvu()
        {
            return dichvu_DAO.Instance.loadloaidv();
        }

        public DataTable loaddichvu(dichvu_DTO dv)
        {
            return dichvu_DAO.Instance.loaddv(dv);
        }
        public DataTable load_dgv(dichvu_DTO dv)
        {
            return dichvu_DAO.Instance.load_dgv(dv);
        }
        public bool themdichvu(dichvu_DTO dv)
        {
            return dichvu_DAO.Instance.themdichvu(dv);
        }
        public bool xoadichvu(dichvu_DTO dv)
        {
            return dichvu_DAO.Instance.xoadichvu(dv);
        }
        public bool suadichvu(dichvu_DTO dv)
        {
            return dichvu_DAO.Instance.suadichvu(dv);
        }




    }
}
