using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using BUS;
using DTO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUII.form
{
    public partial class F_taikhoan : Form
    {
        private string username;
        private string pass;
        public F_taikhoan(string temp)
        {
            this.Username = temp;
            InitializeComponent();
            laythongtin();
            txt_taikhoan.Text = Username;
            txt_mkcu.UseSystemPasswordChar = true;
        }
       

        public void laythongtin()
        {
            user_DTO u = new user_DTO(Username);
            DataTable data = new DataTable();
            data = user_BUS.Instance.load_user(u);
            foreach (DataRow row in data.Rows)
            {
                txt_manv.Text = row["Idnhanvien"].ToString();
                txt_tennv.Text = row["Ten"].ToString();
                txt_chucvu.Text = row["Chucvu"].ToString();
                pass = row["PASS"].ToString();
            }
        }
        public string Username { get => username; set => username = value; }
        public string Pass { get => pass; set => pass = value; }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txt_mkcu_TextChanged(object sender, EventArgs e)
        {
            if (txt_mkcu.Text == pass)
            {
                lb_mkcu.Visible = true;
                lb_mkcu.Text = "True";
            }
            if (txt_mkcu.Text != pass)
            {
                lb_mkcu.Visible = true;
                lb_mkcu.Text = "False";
            }
        }

        private void txt_mkmoi2_TextChanged(object sender, EventArgs e)
        {
            if (txt_mkmoi.Text == txt_mkmoi2.Text)
            {
                lb_mkmoi.Visible = true;
                lb_mkmoi.Text = "True";
            }
            if (txt_mkmoi.Text != txt_mkmoi2.Text)
            {
                lb_mkmoi.Visible = true;
                lb_mkmoi.Text = "False";
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txt_mkcu.Text == pass && txt_mkmoi.Text == txt_mkmoi2.Text)
            {
                user_DTO u = new user_DTO(Username,txt_mkmoi2.Text);
                if (user_BUS.Instance.update_pass(u))
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công");
                }
                else { MessageBox.Show("Thay đổi mật khẩu thất bại"); }
            }
            else { MessageBox.Show("Bạn đã nhập sai thông tin mật khẩu, vui lòng kiểm tra lại"); }
        }
    }
}
