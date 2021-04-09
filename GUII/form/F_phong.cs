using GUII.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using DTO;
using BUS;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUII
{
    public partial class F_phong : Form
    {
        #region KHAI BÁO
        private string ma;
        private string ten;
        private string loai;
        private string user;
        private int tinhtrang;
        private bool nhanphong;
        private bool traphong;
        private bool dattruoc;
        private bool dichvu;
        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Loai { get => loai; set => loai = value; }
        public int Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
        public bool Nhanphong { get => nhanphong; set => bt_nhanphong.Enabled = value; }
        public bool Traphong { get => traphong; set => bt_traphong.Enabled = value; }
        public bool Dattruoc { get => dattruoc; set => bt_dattruoc.Enabled = value; }
        public string User { get => user; set => user = value; }
        public bool Dichvu { get => dichvu; set => bt_dichvu.Enabled = value; }
        #endregion
        public F_phong()
        {
            InitializeComponent();
            
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bt_nhanphong_Click_1(object sender, EventArgs e)
        {
            F_nhanphong f = new F_nhanphong(Ma, Ten, Loai, Tinhtrang);
            f.ShowDialog();
            this.Hide();
        }
        private void bt_dichvu_Click(object sender, EventArgs e)
        {
            F_dichvu f = new F_dichvu(Ma, Ten, Loai);
            f.Tam = Ma;
            f.ShowDialog();
            this.Hide();
        }
        private void bt_dattruoc_Click(object sender, EventArgs e)
        {
            DialogResult ok = MessageBox.Show("Phòng "+ Ma+" đã dọn phòng xong ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ok == DialogResult.Yes)
            {
                traphong_DTO bill = new traphong_DTO(Ma);
                if (traphong_BUS.Instance.donphong(bill))
                {
                    MessageBox.Show("Đã Dọn Phòng Xong");
                }
            }
        }
        private void bt_traphong_Click(object sender, EventArgs e)
        {
            F_traphong f = new F_traphong(Ma, Ten, Loai,User);
            f.Show();
            this.Hide();
        }
    }
}
