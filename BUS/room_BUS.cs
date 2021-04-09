using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_KS;

namespace BUS
{
    public class room_BUS
    {
        private static room_BUS instance;
        public static room_BUS Instance
        {
            get { if (instance == null) instance = new room_BUS(); return room_BUS.instance; }
            private set { room_BUS.instance = value; }
        }
        public room_BUS() { }
        public List<room_DTO> loadroomlist()
        {   
            return room_DAO.Instance.loadroomlist();
        }

    }

}
