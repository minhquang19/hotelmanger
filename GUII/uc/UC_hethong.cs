using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QL_KS
{
    public partial class UC_hethong : UserControl
    {
        public UC_hethong()
        {
            InitializeComponent();
            load_dgv();
        }
        public void load_dgv()
        {
            dgv_hethong.DataSource = hethong_BUS.Instance.load_dgv();
        }

        private void dgv_hethong_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgv_hethong.RowCount; i++)
            {
                dgv_hethong.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void dgv_hethong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
