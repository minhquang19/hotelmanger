using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DTO;
using BUS;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUII.form;
using System.Diagnostics;

namespace QL_KS
{
    public partial class F_MAIN : Form
    {
        private string username;
        private string chucvu;
        public string Username { get => username; set => username = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }

        public F_MAIN(string username)
        {
            InitializeComponent();
            this.Username = username;
            uC_trangchu3.Show();
            uC_trangchu3.BringToFront();
            lb_tenuser.Text = username;
            lb_1.Text = username;
            phanquyen();
        }
        public void phanquyen()
        {
            user_DTO u = new user_DTO(Username);
            DataTable data = new DataTable();
            data = user_BUS.Instance.load_user(u);
            foreach (DataRow row in data.Rows)
            {
                this.Chucvu = row["Chucvu"].ToString();
            }
            if(Chucvu.Equals("NHANVIEN"))
            {
                bt_hethong1.Visible = false;
                bt_baocao.Visible = false;
                bt_nhanvien1.Visible = false;
            }    
        }    
        private void bt_tramgchu_Click(object sender, EventArgs e)
        {
            uC_trangchu2.Show();
            uC_trangchu2.BringToFront();
        }

        private void bt_phong_Click(object sender, EventArgs e)
        {
            uC_Phong2.Show();
            uC_Phong2.Chucvu = Chucvu;
            uC_Phong2.User = Username;
            uC_Phong2.BringToFront();
        }

        private void bt_khachhang_Click(object sender, EventArgs e)
        {
            uC_khachhang2.Show();
            uC_khachhang2.BringToFront();
        }

        private void bt_dichvu_Click(object sender, EventArgs e)
        {
            uC_dichvu1.Show();
            uC_dichvu1.BringToFront();
        }

        private void bt_nhanvien_Click(object sender, EventArgs e)
        {
            uC_nhanvien1.Show();
            uC_nhanvien1.BringToFront();
        }

        private void bt_taikhoan_Click(object sender, EventArgs e)
        {
            F_taikhoan f = new F_taikhoan(Username);
            uC_dichvu1.Hide();
            uC_hethong1.Hide();
            uC_khachhang2.Hide();
            uC_nhanvien1.Hide();
            uC_Phong2.Hide();
            uC_BAOCAO1.Hide();
            f.ShowDialog();
        }

        private void bt_hethong_Click(object sender, EventArgs e)
        {
            uC_hethong1.Show();
            uC_hethong1.BringToFront();
        }

        private void F_MAIN_Load(object sender, EventArgs e)
        {
            uC_trangchu3.Show();
            uC_trangchu3.BringToFront();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

//
        private void bt_themnhanvien_Click(object sender, EventArgs e)
        {
            uC_trangchu3.Show();
            uC_trangchu3.BringToFront();
        }

        private void bt_phong1_Click(object sender, EventArgs e)
        {
            uC_Phong3.Show();
            uC_Phong3.Chucvu = Chucvu;
            uC_Phong3.User = Username;
            uC_Phong3.BringToFront();
        }

        private void bt_khachhang2_Click(object sender, EventArgs e)
        {
            uC_khachhang3.Show();
            uC_khachhang3.BringToFront();
        }

        private void bt_nhanvien1_Click(object sender, EventArgs e)
        {

            uC_nhanvien2.Show();
            uC_nhanvien2.BringToFront();
        }

        private void bt_taikhoan1_Click(object sender, EventArgs e)
        {
            F_taikhoan f = new F_taikhoan(Username);
            uC_dichvu2.Hide();
            uC_hethong2.Hide();
            uC_khachhang3.Hide();
            uC_nhanvien2.Hide();
            uC_Phong3.Hide();
            uC_BAOCAO1.Hide();
            f.ShowDialog();
        }

        private void bt_hethong1_Click(object sender, EventArgs e)
        {
            uC_hethong2.Show();
            uC_hethong2.BringToFront();
        }

        private void bt_dichvu1_Click(object sender, EventArgs e)
        {
            uC_dichvu2.Show();
            uC_dichvu2.BringToFront();
        }

        private void xuiButton5_Click(object sender, EventArgs e)
        {
            F_LOGIN f = new F_LOGIN();
            this.Close();
        }

        private void bt_baocao_Click(object sender, EventArgs e)
        {
            uC_BAOCAO1.Show();
            uC_BAOCAO1.BringToFront();
        }

        private void bt_trangchu_Click(object sender, EventArgs e)
        {
            uC_trangchu3.Show();
            uC_trangchu3.BringToFront();

        }
    }
}