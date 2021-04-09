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
    public class loaiphong_BUS
    {
        private static loaiphong_BUS instance;

        public static loaiphong_BUS Instance
        {
            get { if (instance == null) instance = new loaiphong_BUS(); return loaiphong_BUS.instance; }
            private set { loaiphong_BUS.instance = value; }
        }
        public DataTable load_dgv()
        {
            return loaiphong_DAO.Instance.load_dgv();
        }
        public bool themloaiphong(loaiphong_DTO lp)
        {
            return loaiphong_DAO.Instance.themloaiphong(lp);
        }
        public bool xoaloaiphong(loaiphong_DTO lp)
        {
            return loaiphong_DAO.Instance.xoaloaiphong(lp);
        }
        public bool sualoaiphong(loaiphong_DTO lp)
        {
            return loaiphong_DAO.Instance.sualoaiphong(lp);
        }
    }
}
