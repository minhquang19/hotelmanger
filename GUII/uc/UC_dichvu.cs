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
using DTO;

namespace QL_KS
{
    public partial class UC_dichvu : UserControl
    {
        public UC_dichvu()
        {
            InitializeComponent();
            load_dgv();
            load_combo();
            load_loaidv();
        }
        public void load_dgv()
        {
            dgv_dichvu.DataSource = ql_dichvu_BUS.Instance.load_dgv();
        }    
        public void load_combo()
        {
            cb_loaidv.DisplayMember = "Ten";
            cb_loaidv.ValueMember = "ID";
            cb_loaidv.DataSource = dichvu_BUS.Instance.loadloaidichvu();
        }

        private void bt_them_phong_Click(object sender, EventArgs e)
        {
            if (txt_tendv.Text != "" && txt_gia.Text != "")
            {
                string querycheck = "SELECT count([ID]) FROM t_dichvu WHERE ([Ten] like N'%"+txt_tendv.Text+"%')";
                ql_dichvu_DTO qldv = new ql_dichvu_DTO(lb_temp.Text, txt_tendv.Text,cb_loaidv.SelectedValue.ToString(),txt_gia.Text );
                if (ql_dichvu_BUS.Instance.checktrung(querycheck) == false)
                {
                    if (ql_dichvu_BUS.Instance.themdv(qldv))
                    {
                        MessageBox.Show("Bạn đã thêm thành công dịch vụ " + txt_tendv.Text);
                        load_dgv();
                    }
                    else
                    {
                        MessageBox.Show("Rất tiếc, thêm không thành công");
                    }
                }
                else { MessageBox.Show("Dịch vụ này đã tồn tại"); }
               
            }
            else MessageBox.Show("Mời nhập đầy đủ thông tin");
        }

        private void dgv_dichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_temp.Text = dgv_dichvu.CurrentRow.Cells["madv"].Value.ToString();
            txt_tendv.Text = dgv_dichvu.CurrentRow.Cells["tendv"].Value.ToString();
            cb_loaidv.Text = dgv_dichvu.CurrentRow.Cells["loaidv"].Value.ToString();
            txt_gia.Text = dgv_dichvu.CurrentRow.Cells["gia"].Value.ToString();
        }

        private void dgv_dichvu_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgv_dichvu.RowCount; i++)
            {
                dgv_dichvu.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void bt_xoaphong_Click(object sender, EventArgs e)
        {

            if (lb_temp.Text != "")
            {
                ql_dichvu_DTO dv = new ql_dichvu_DTO(lb_temp.Text);
                DialogResult ok = MessageBox.Show("Bạn có muốn xóa dịch vụ có mã " + lb_temp.Text, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.Yes)
                {
                    if (ql_dichvu_BUS.Instance.xoadv(dv))
                    {
                        MessageBox.Show("Bạn đã xóa thành công dịch vụ mã   "+ lb_temp.Text);
                        load_dgv();
                    }
                    else
                    {
                        MessageBox.Show("Rất tiếc, Xóa không thành công");
                    }
                }
            }
            else { MessageBox.Show("Mời bạn chọn đối tượng muốn xóa", "Thông báo"); }
        }

        private void bt_sua_phong_Click(object sender, EventArgs e)
        {
            if (txt_tendv.Text != "" && txt_gia.Text != "")
            {
                ql_dichvu_DTO qldv = new ql_dichvu_DTO(lb_temp.Text,txt_tendv.Text,cb_loaidv.SelectedValue.ToString(),txt_gia.Text);
                if (ql_dichvu_BUS.Instance.suadichvu(qldv))
                {
                    MessageBox.Show("Bạn đã sửa thành công dịch vụ : " + txt_tendv.Text);
                    load_dgv();
                }
                else
                {
                    MessageBox.Show("Rất tiếc, Sửa không thành công");
                }
            }
            else { MessageBox.Show("Mời bạn nhập đầy đủ thông tin", "Thông báo"); }
        }

        public void load_loaidv()
        {
            dgv_loaidichvu.DataSource = dichvu_BUS.Instance.loadloaidichvu();
        }

        private void dgv_loaidichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maloaidv.Text =  dgv_loaidichvu.CurrentRow.Cells["id"].Value.ToString();
            txt_tenloaidv.Text = dgv_loaidichvu.CurrentRow.Cells["ten"].Value.ToString();
        }

        private void dgv_loaidichvu_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgv_loaidichvu.RowCount; i++)
            {
                dgv_loaidichvu.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void bt_themloaidv_Click(object sender, EventArgs e)
        {

        }

        private void bt_xoaloaidv_Click(object sender, EventArgs e)
        {

        }
    }

}
