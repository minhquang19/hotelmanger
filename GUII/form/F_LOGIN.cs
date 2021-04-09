#pragma warning disable CS0234 // The type or namespace name 'DAO' does not exist in the namespace 'QL_KS' (are you missing an assembly reference?)
#pragma warning restore CS0234 // The type or namespace name 'DAO' does not exist in the namespace 'QL_KS' (are you missing an assembly reference?)
using System;
using DTO;
using BUS;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUII.form;

namespace QL_KS
{
    public partial class F_LOGIN : Form
    {
        login_BUS lgbus = new login_BUS();
        public F_traphong traphong;

        public F_LOGIN()
        {
            InitializeComponent();
        }
        private void bt_showpass_MouseDown(object sender, MouseEventArgs e)
        {
            txt_pass.UseSystemPasswordChar = true;
        }

        private void bt_showpass_MouseUp(object sender, MouseEventArgs e)
        {
            txt_pass.UseSystemPasswordChar = false;
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            string user = txt_user.Text;
            string pass = txt_pass.Text;
            login_DTO login = new login_DTO(user,pass);
            if (lgbus.checkLogin(login))
            {
                F_MAIN f = new F_MAIN(user);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            }
            
        }


    }
}
