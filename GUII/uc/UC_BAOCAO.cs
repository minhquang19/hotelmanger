using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace GUII.uc
{
    public partial class UC_BAOCAO : UserControl
    {
        public UC_BAOCAO()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_xembaocao_Click(object sender, EventArgs e)
        {
            string tu = dt_tu.Value.ToString("yyyy-MM-dd");
            string den = dt_den.Value.ToString("yyyy-MM-dd");
            string sql = "SELECT * FROM t_hoadonthu WHERE Ngaytra  >='" + tu + "' and  Ngaytra  <='" + den + "'";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-LBVNLAK;Initial Catalog=QL_KHACHSAN;Integrated Security=True";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            string ngay = tu; ;/*Convert.ToString(d.Day);*/
            ReportParameterCollection rp = new ReportParameterCollection();
            rp.Add(new ReportParameter("tu", ngay));
            this.reportViewer1.LocalReport.SetParameters(rp);
            string thang = den;
            ReportParameterCollection rp1 = new ReportParameterCollection();
            rp1.Add(new ReportParameter("den", thang));
            this.reportViewer1.LocalReport.SetParameters(rp1);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables[0]);

                reportViewer1.LocalReport.DataSources.Clear();

                reportViewer1.LocalReport.DataSources.Add(rds);

                reportViewer1.RefreshReport();
            }

        }
    }
}
