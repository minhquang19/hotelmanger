using System;
using System.Collections.Generic;
using System.Data;
using DTO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class user_BUS
    {
        private static user_BUS instance;
        public static user_BUS Instance
        {
            get { if (instance == null) instance = new user_BUS(); return user_BUS.instance; }
            private set { user_BUS.instance = value; }
        }
        public DataTable load_user(user_DTO u)
        {
            return user_DAO.Instance.load_user(u);
        }
        public bool update_pass(user_DTO u)
        {
            return user_DAO.Instance.update_pass(u);
        }

    }
}
