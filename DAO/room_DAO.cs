using System;
using System.Collections.Generic;
using System.Linq;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class room_DAO
    {
        private static room_DAO instance;

        public static room_DAO Instance
        {
            get { if (instance == null) instance = new room_DAO(); return room_DAO.instance; }
            private set { room_DAO.instance = value; }
        }
        private room_DAO() { }

        public List<room_DTO> loadroomlist()
        {
            string query = "SELECT * FROM t_phong,t_loaiphong,t_tinhtrang where t_phong.Idloai = t_loaiphong.IDLP and t_tinhtrang.ID = t_phong.Idtinhtrang";
            List<room_DTO> roomlist = new List<room_DTO>();
            DataTable data = processdata.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                room_DTO room = new room_DTO(item);
                roomlist.Add(room);
            }
            return roomlist;
        }
        

        
    }
}
