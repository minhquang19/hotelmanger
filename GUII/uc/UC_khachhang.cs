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
using System.Threading;
using DTO;

namespace QL_KS
{
    public partial class UC_khachhang : UserControl
    {
        public UC_khachhang()
        {
            InitializeComponent();
            loadkhachhang();
        }
        #region EVENT
        private void dgv_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makh.Text = dgv_khachhang.CurrentRow.Cells[1].Value.ToString();
            lb_temp.Text = dgv_khachhang.CurrentRow.Cells[1].Value.ToString();
            txt_tenkh.Text = dgv_khachhang.CurrentRow.Cells[2].Value.ToString();
            dt_ngaysinh.Text = dgv_khachhang.CurrentRow.Cells[3].Value.ToString();
            cb_gioitinh.Text = dgv_khachhang.CurrentRow.Cells[4].Value.ToString();
            txt_sdt.Text = dgv_khachhang.CurrentRow.Cells[5].Value.ToString();
            txt_cmnd.Text = dgv_khachhang.CurrentRow.Cells[6].Value.ToString();
            txt_quoctich.Text = dgv_khachhang.CurrentRow.Cells[7].Value.ToString();
            txt_email.Text = dgv_khachhang.CurrentRow.Cells[8].Value.ToString();
        }

        private void dgv_khachhang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgv_khachhang.RowCount; i++)
            {
                dgv_khachhang.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            reset();
        }
        //THÊM SỬA XÓA
        private void bt_them_Click(object sender, EventArgs e)
        {
            string querycheck = "SELECT count([ID]) FROM t_khachhang WHERE ([ID] = '" + txt_makh.Text + "') ";
            if (txt_makh.Text != "" && txt_tenkh.Text != "")
            {
                if (khachhang_BUS.Instance.checktrung(querycheck) == false)
                {
                    khachhang_DTO kh = new khachhang_DTO(txt_makh.Text, txt_tenkh.Text, dt_ngaysinh.Value.ToString("MM/dd/yyyy"), cb_gioitinh.Text, txt_sdt.Text, txt_cmnd.Text, txt_quoctich.Text, txt_email.Text, lb_temp.Text);
                    if (khachhang_BUS.Instance.themkhachhang(kh))
                    {
                        MessageBox.Show("Bạn đã thêm thành công khách hàng ", txt_makh.Text);
                        loadkhachhang();
                    }
                    else
                    {
                        MessageBox.Show("Rất tiếc, thêm không thành công");
                    }
                }

                else { MessageBox.Show("Mã phòng bị trùng, vui lòng nhập lại"); }
            }
            else MessageBox.Show("Mời nhập đầy đủ thông tin");
        }
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string makh = txt_makh.Text;
            if (makh.Length != 0)
            {
                khachhang_DTO kh = new khachhang_DTO(makh, makh, "", makh, makh, makh, makh, makh, makh);
                DialogResult ok = MessageBox.Show("Bạn có muốn xóa " + makh, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.Yes)
                {
                    if (khachhang_BUS.Instance.xoakhachhang(kh))
                    {
                        MessageBox.Show("Bạn đã xóa thành công phòng  ", makh);
                        loadkhachhang();
                    }
                    else
                    {
                        MessageBox.Show("Rất tiếc, Xóa không thành công");
                    }
                }
            }
            else { MessageBox.Show("Mời bạn chọn đối tượng muốn xóa", "Thông báo"); }
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {

            string temp = lb_temp.Text;
            if (txt_makh.Text != "" && txt_tenkh.Text != "")
            {
                khachhang_DTO kh = new khachhang_DTO(txt_makh.Text, txt_tenkh.Text, dt_ngaysinh.Value.ToString("MM/dd/yyyy"), cb_gioitinh.SelectedItem.ToString(), txt_sdt.Text, txt_cmnd.Text, txt_quoctich.Text, txt_email.Text, lb_temp.Text);
                if (khachhang_BUS.Instance.suakhachhang(kh))
                {
                    MessageBox.Show("Bạn đã sửa thành công phòng : ", txt_makh.Text);
                    loadkhachhang();
                }
                else
                {
                    MessageBox.Show("Rất tiếc, Sửa không thành công");
                }
            }
            else { MessageBox.Show("Mời bạn nhập đầy đủ thông tin", "Thông báo"); }
        }
        private void bt_timphong_Click(object sender, EventArgs e)
        {
            string key = txt_tim.Text;
            if (key.Length != 0)
            {
                khachhang_DTO kh = new khachhang_DTO(key);
                dgv_khachhang.DataSource = khachhang_BUS.Instance.timkhachhang(kh);
            }
            else { MessageBox.Show("Mời nhập thông tin muốn tìm kiếm"); }
        }
        #endregion
        public void loadkhachhang()
        {
            dgv_khachhang.DataSource = khachhang_BUS.Instance.loadkhachhang();
        }
        public void reset()
        {
            txt_makh.Text = "" ;
            txt_tenkh.Text = "";
            cb_gioitinh.Text = "";
            txt_email.Text = "";
            txt_cmnd.Text = "";
            txt_sdt.Text = "";
            txt_quoctich.Text = "";
        }
        
    }
}
