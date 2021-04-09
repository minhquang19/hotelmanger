using BUS;
using DTO;
using QL_KS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUII
{

    public partial class F_nhanphong : Form
    {
        public F_nhanphong(string ma,string ten,string loai,int tinhtrang)
        {
            InitializeComponent();
            txt_maphong.Text = ma;
            txt_tenphong.Text = ten;
            txt_loaiphong.Text = loai;
            loadcombo();
            cb_makhach.SelectedItem = null;
            cb_makhach.Text = "";

        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bt_nhanphong_Click(object sender, EventArgs e)
        {
            if(dt_checkin.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày nhận phòng lớn hơn ngày hiện tại, vui lòng nhập lại");
            }
            else
            {
                string test = dt_checkin.Value.ToString("MM/dd/yyyy");
                nhanphong_DTO kh = new nhanphong_DTO(cb_makhach.Text, txt_maphong.Text, test);
                if (nhanphong_BUS.Instance.themphong(kh))
                {
                    MessageBox.Show("Nhận phòng thành công", "Thông Báo");
                    this.Close();
                    if (nhanphong_BUS.Instance.suatinhtrang(kh))
                    {

                    }
                }
                else { MessageBox.Show("fail", "Thông Báo"); }
            }
            

        }
        public void loadcombo()
        {
            cb_makhach.DataSource = nhanphong_BUS.Instance.loadcombo();
            cb_makhach.DisplayMember = "ID";
            cb_makhach.ValueMember = "ID";
        }
        private void cb_makhach_TextChanged(object sender, EventArgs e)
        {
            if(cb_makhach.Text == "")
            {
                panel3.Visible = false;
            }
            else
            {
                nhanphong_DTO kh = new nhanphong_DTO(cb_makhach.Text);
                DataTable dt = new DataTable();
                dt = nhanphong_BUS.Instance.getmakh(kh);
                foreach (DataRow row in dt.Rows)
                {
                    txt_hoten.Text = row["Ten"].ToString();
                    txt_ngaysinh.Text = row["Ngaysinh"].ToString();
                    txt_gioitinh.Text = row["Gioitinh"].ToString();
                    txt_sdt.Text = row["sdt"].ToString();
                    txt_cmt.Text = row["CMND"].ToString();
                    txt_quoctich.Text = row["Quoctich"].ToString();
                    txt_email.Text = row["Email"].ToString();
                }
                panel3.Visible = true;
            }
        }
    }
}
