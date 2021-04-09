using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class hethong_BUS
    {
        private static hethong_BUS instance;

        public static hethong_BUS Instance
        {
            get { if (instance == null) instance = new hethong_BUS(); return hethong_BUS.instance; }
            private set { hethong_BUS.instance = value; }
        }
        public DataTable load_dgv()
        {
            return hethong_DAO.Instance.load_dgv();
        }
    }
}
