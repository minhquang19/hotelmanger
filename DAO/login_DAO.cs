using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class login_DAO
    {
        public login_DAO() { }
        public bool checkLogin(login_DTO login)
        {
            string query = "SELECT * FROM t_users WHERE ID='" + login.User + "' and PASS='" + login.Pass + "'";
            DataTable result = new DataTable();
            result = processdata.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        }
    }

