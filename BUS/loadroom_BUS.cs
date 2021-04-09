using System;
using System.Collections.Generic;
using System.Linq;
using DTO;
using DAO;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BUS
{
    public class loadroom_BUS
    {
        private static loadroom_BUS  instance;

        public static loadroom_BUS Instance {
            get { if (instance == null) instance = new loadroom_BUS(); return loadroom_BUS.instance; }
            private set { loadroom_BUS.instance = value; }
        }
        public DataTable loadroom()
        {
            return loadroom_DAO.Instance.loadphong();
        }
        public DataTable loadloaiphong()
        {
            return loadroom_DAO.Instance.loadloaiphong();
        }
        public DataTable loadcsvc()
        {
            return loadroom_DAO.Instance.loadcsvc();
        }
        public DataTable loadcomboloaiphong()
        {
            return loadroom_DAO.Instance.loadloaiphong();
        }
        public DataTable loadcombotinhtrang()
        {
            return loadroom_DAO.Instance.loadtinhtrang();
        }
        public bool addroom(loadroom_DTO room)
        {
            return loadroom_DAO.Instance.addphong(room);
        }
        public bool checktrung(string querycheck)
        {
            return loadroom_DAO.Instance.checktrung(querycheck);
        }
        public bool suaphong(loadroom_DTO room)
        {
            return loadroom_DAO.Instance.suaphong(room);
        }    
        public bool xoaphong(loadroom_DTO room)
        {
            return loadroom_DAO.Instance.xoaphong(room);
        }    
        public DataTable timphong(loadroom_DTO room)
        {
            return loadroom_DAO.Instance.timphong(room);
        }
        public DataTable load_dgvthuephong()
        {
            return loadroom_DAO.Instance.load_dgvthuephong();
        }
        public DataTable load_hoadon()
        {
            return loadroom_DAO.Instance.load_hoadon();
        }
        public DataTable load_hoadon1(room_DTO r)
        {
            return loadroom_DAO.Instance.load_hoadon1(r);
        }
    }
}
