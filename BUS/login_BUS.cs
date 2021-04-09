using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Threading.Tasks;

namespace BUS
{
    public class login_BUS
    {
        login_DAO lg_dao = new login_DAO();
        public bool checkLogin(login_DTO login)
        {
            return lg_dao.checkLogin(login);
        }
    }
}
