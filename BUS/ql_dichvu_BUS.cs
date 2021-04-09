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
    public class ql_dichvu_BUS
    {
        private static ql_dichvu_BUS instance;
        public static ql_dichvu_BUS Instance
        {
            get { if (instance == null) instance = new ql_dichvu_BUS(); return ql_dichvu_BUS.instance; }
            private set { ql_dichvu_BUS.instance = value; }
        }
        public DataTable load_dgv()
        {
            return ql_dichvu_DAO.Instance.load_dgv();
        }
        public bool themdv(ql_dichvu_DTO qldv)
        {
            return ql_dichvu_DAO.Instance.themdichvu(qldv);
        }    
        public bool xoadv(ql_dichvu_DTO qldv)
        {
            return ql_dichvu_DAO.Instance.xoadichvu(qldv);
        }    
        public DataTable timdv(ql_dichvu_DTO qldv)
        {
            return ql_dichvu_DAO.Instance.timdichvu(qldv);
        }
        public bool checktrung(string querycheck)
        {
            return ql_dichvu_DAO.Instance.checktrung(querycheck);
        }
        public bool suadichvu(ql_dichvu_DTO qldv)
        {
            return ql_dichvu_DAO.Instance.suadichvu(qldv);
        }    
    }
}
