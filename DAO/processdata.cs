using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAO
{
    class processdata
    {
        protected SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LBVNLAK;Initial Catalog=QL_KHACHSAN;Integrated Security=True");
        private static processdata instance;
        
        public static processdata Instance {
            get { if (instance == null) instance = new processdata(); return processdata.instance; }
            private set { processdata.instance = value; }
        }
        public processdata() { }
        public DataTable ExecuteQuery(string query)
        {
                DataTable data = new DataTable();
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
                return data;
        }
        public bool ExecuteNonQuery(string query)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                if (command.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            finally { conn.Close(); }
            return false;
            
        }
        public object ExecuteScalar(string query)
        {
            object data = 0;
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                data = command.ExecuteScalar();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { conn.Close(); }
            return data;
        }
        }
    }

