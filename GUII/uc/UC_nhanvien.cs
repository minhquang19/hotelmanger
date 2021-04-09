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
    public partial class UC_nhanvien : UserControl
    {
        public UC_nhanvien()
        {
            InitializeComponent();
            load_dgv();
        }
        public void load_dgv()
        {
            dgv_nhanvien.DataSource = nhanvien_BUS.Instance.load_dgv();
        }

        private void bt_themnhanvien_Click(object sender, EventArgs e)
        {
            string querycheck = "SELECT count([ID]) FROM t_nhanvien WHERE ([ID] = '" + txt_manv.Text + "') ";

            if (txt_manv.Text != "" && txt_tennv.Text != "")
            {
                if (khachhang_BUS.Instance.checktrung(querycheck) == false)
                {
                    nhanvien_DTO nv = new nhanvien_DTO(txt_manv.Text, txt_tennv.Text, dt_ngaysinh.Value.ToString("MM/dd/yyyy"), cb_gioitinh.Text, txt_sdt.Text, cb_chucvu.Text,cb_bophan.Text);
                    if (nhanvien_BUS.Instance.themnhanvien(nv))
                    {
                        MessageBox.Show("Bạn đã thêm thành công khách hàng ", txt_manv.Text);
                        load_dgv();
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

        private void bt_suanhanvien_Click(object sender, EventArgs e)
        {
            if (txt_manv.Text != "" && txt_tennv.Text != "")
            {
                nhanvien_DTO nv = new nhanvien_DTO(txt_manv.Text, txt_tennv.Text, dt_ngaysinh.Value.ToString("MM/dd/yyyy"), cb_gioitinh.Text, txt_sdt.Text, cb_chucvu.Text, cb_bophan.Text);
                if (nhanvien_BUS.Instance.suanhanvien(nv))
                {
                    MessageBox.Show("Bạn đã sửa thành công phòng : ", txt_manv.Text);
                    load_dgv();
                }
                else
                {
                    MessageBox.Show("Rất tiếc, Sửa không thành công");
                }
            }
            else { MessageBox.Show("Mời bạn nhập đầy đủ thông tin", "Thông báo"); }
        }

        private void bt_xoanhanvien_Click(object sender, EventArgs e)
        {
            if (txt_manv.Text != "")
            {
                nhanvien_DTO nv = new nhanvien_DTO(txt_manv.Text);
                DialogResult ok = MessageBox.Show("Bạn có muốn xóa " + txt_manv.Text, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.Yes)
                {
                    if (nhanvien_BUS.Instance.xoanhanvien(nv))
                    {
                        MessageBox.Show("Bạn đã xóa thành công nhân viên  ", txt_manv.Text);
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

        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_manv.Text = dgv_nhanvien.CurrentRow.Cells["id"].Value.ToString();
            txt_tennv.Text = dgv_nhanvien.CurrentRow.Cells["ten"].Value.ToString();
            txt_sdt.Text = dgv_nhanvien.CurrentRow.Cells["sdt"].Value.ToString();
            cb_gioitinh.Text = dgv_nhanvien.CurrentRow.Cells["gioitinh"].Value.ToString();
            cb_chucvu.Text = dgv_nhanvien.CurrentRow.Cells["chucvu"].Value.ToString();
            dt_ngaysinh.Text = dgv_nhanvien.CurrentRow.Cells["ngaysinh"].Value.ToString();
            cb_bophan.Text = dgv_nhanvien.CurrentRow.Cells["bophan"].Value.ToString();
        }

        private void dgv_nhanvien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgv_nhanvien.RowCount; i++)
            {
                dgv_nhanvien.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            if (txt_tim.Text != "")
            {
                nhanvien_DTO kh = new nhanvien_DTO(txt_tim.Text);
                dgv_nhanvien.DataSource = nhanvien_BUS.Instance.timnhanvien(kh);
            }
            else { MessageBox.Show("Mời nhập thông tin muốn tìm kiếm"); }
        }
        public void reset()
        {
            txt_manv.Text = "";
            txt_tennv.Text = "";
            txt_sdt.Text = "";
            cb_bophan.SelectedItem = null;
            cb_chucvu.SelectedItem = null;
            cb_gioitinh.SelectedItem = null;
            load_dgv();
        }

        private void bt_resetnhanvien_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
