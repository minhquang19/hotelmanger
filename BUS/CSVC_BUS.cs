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
    public class CSVC_BUS
    {

        private static CSVC_BUS instance;
        public static CSVC_BUS Instance
        {
            get { if (instance == null) instance = new CSVC_BUS(); return CSVC_BUS.instance; }
            private set { CSVC_BUS.instance = value; }
        }
        public DataTable load_dgv(CSVC_DTO csvc)
        {
            return CSVC_DAO.Instance.load_dgv(csvc);
        }    
        public bool themvattu(CSVC_DTO csvc)
        {
            return CSVC_DAO.Instance.them_vattu(csvc);
        }
        public bool xoavattu(CSVC_DTO csvc)
        {
            return CSVC_DAO.Instance.xoa_vattu(csvc);
        }
        public bool suavattu(CSVC_DTO csvc)
        {
            return CSVC_DAO.Instance.sua_vattu(csvc);
        }
        public bool themcsvc(CSVC_DTO csvc)
        {
            return CSVC_DAO.Instance.them_csvc(csvc);
        }
        public bool xoacsvc(CSVC_DTO csvc)
        {
            return CSVC_DAO.Instance.xoa_csvc(csvc);
        }
        public bool suacsvc(CSVC_DTO csvc)
        {
            return CSVC_DAO.Instance.sua_csvc(csvc);
        }

    }
}
