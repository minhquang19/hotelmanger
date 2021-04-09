using System;
using Bunifu.Framework.UI;
using BUS;
using DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using COMExcel = Microsoft.Office.Interop.Excel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUII;
using System.Deployment.Application;
using System.Data.SqlClient;
#pragma warning disable CS0234 // The type or namespace name 'DAO' does not exist in the namespace 'QL_KS' (are you missing an assembly reference?)
#pragma warning restore CS0234 // The type or namespace name 'DAO' does not exist in the namespace 'QL_KS' (are you missing an assembly reference?)
#pragma warning disable CS0234 // The type or namespace name 'DTO' does not exist in the namespace 'QL_KS' (are you missing an assembly reference?)
#pragma warning restore CS0234 // The type or namespace name 'DTO' does not exist in the namespace 'QL_KS' (are you missing an assembly reference?)

namespace QL_KS
{
    public partial class UC_Phong : UserControl
    {
        #region KHAI BÁO
        private static UC_Phong instance;

        public static UC_Phong Instance
        {
            get { if (instance == null) instance = new UC_Phong(); return UC_Phong.instance; }
            private set { UC_Phong.instance = value; }
        }
        private string Id_hoadon;

        public string User { get => user; set => user = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Id_hoadon1 { get => Id_hoadon; set => Id_hoadon = value; }

        private string chucvu;

        private string user;
        #endregion
        public UC_Phong()
        {
            InitializeComponent();
            room();
            loadroom();
            loadloaiphong();
            loadcsvc();
            loadcomboloaiphong();
            loadcombotinhtrang();
            load_dgv();
            loadthietbi();
            load_dgvthuephong();
            load_hoadon();
            //phanquyen();
        }
        public void phanquyen()
        {
            if(Chucvu.Equals("NHANVIEN"))
            {
                group_phong.Enabled = false;
                group_loaiphong.Enabled = false;
            }    
        }    
        // LOAD SƠ ĐỒ PHÒNG
        #region SƠ ĐỒ PHÒNG
        public void buttonDoubleclick(object sender, EventArgs e)
        {
            F_phong btnphong = new F_phong();
            btnphong.Ma = ((sender as UC_LIST).Tag as room_DTO).Id;
            btnphong.Ten = ((sender as UC_LIST).Tag as room_DTO).Name;
            btnphong.Loai = ((sender as UC_LIST).Tag as room_DTO).Type_name;
            btnphong.Tinhtrang = ((sender as UC_LIST).Tag as room_DTO).Status;
            btnphong.User = User;
            switch (btnphong.Tinhtrang)
            {
                case 1:
                    btnphong.Dichvu = false;
                    btnphong.Traphong = false;
                    btnphong.Dattruoc = false;
                    break;
                case 2:
                    btnphong.Nhanphong = false;
                    btnphong.Dattruoc = false;
                    break;
                case 4:
                    btnphong.Nhanphong = false;
                    btnphong.Traphong = false;
                    btnphong.Dichvu = false;
                    break;
                default:
                    break;
            }
            btnphong.Show();
        }
        public void room()
        {
            List<room_DTO> roomlist = room_BUS.Instance.loadroomlist();
            foreach (room_DTO item in roomlist)
            {
                UC_LIST uc = new UC_LIST();
                uc.Tenphong = item.Name;
                uc.Loaiphong = item.Type_name;
                uc.Tinhtrang = item.Stt_name;
                switch (item.Status)
                {
                    case 1:
                        uc.BackColor = Color.FromArgb(178, 224, 184);
                        uc.Color_tinhtrang = Color.FromArgb(178, 224, 184);
                        uc.Btn = Color.FromArgb(1, 162, 99);
                        uc.Color_ten = Color.FromArgb(1, 162, 99);
                        uc.Color_loaiphong = Color.FromArgb(1, 162, 99);
                        break;
                    case 2:
                        uc.BackColor = Color.FromArgb(249, 211, 207);
                        uc.Color_tinhtrang = Color.FromArgb(249, 211, 207);
                        uc.Btn = Color.FromArgb(231, 76, 60);
                        uc.Color_ten = Color.FromArgb(231, 76, 60);
                        uc.Color_loaiphong = Color.FromArgb(231, 76, 60);
                        uc.Color_text = Color.Red;
                        break;
                    case 4:
                        uc.BackColor = Color.FromArgb(163, 180, 255);
                        uc.Color_tinhtrang = Color.FromArgb(163, 180, 255);
                        uc.Btn = Color.FromArgb(93, 124, 255);
                        uc.Color_ten = Color.FromArgb(93, 124, 255);
                        uc.Color_loaiphong = Color.FromArgb(93, 124, 255);
                        uc.Color_text = Color.Blue;
                        break;
                    default:
                        break;
                }
                flp_sodophong.Controls.Add(uc);
                uc.Click += new System.EventHandler(this.buttonDoubleclick);
                uc.Tag = item;
            }
            
        }
        public void resetsdp()
        {
            flp_sodophong.Controls.Clear();
            room();
        }
        #endregion
        //QUẢN LÝ PHÒNG
        #region QUẢN LÝ PHÒNG
        private void reset()
        {
            txt_maphong.Text = "";
            txt_tenphong.Text = "";
            cb_loaiphong.SelectedItem = null;
            cb_trangthai.SelectedItem = null;
        }
        public void loadroom()
        {
            dgv_phong.DataSource = loadroom_BUS.Instance.loadroom();
        }
        public void loadcombotinhtrang()
        {
            cb_trangthai.DisplayMember = "Tentinhtrang";
            cb_trangthai.ValueMember = "ID";
            cb_trangthai.DataSource = loadroom_BUS.Instance.loadcombotinhtrang();
        }
        public void loadcomboloaiphong()
        {
            cb_loaiphong.DisplayMember = "Tenloaiphong";
            cb_loaiphong.ValueMember = "IDLP";
            cb_loaiphong.DataSource = loadroom_BUS.Instance.loadcomboloaiphong();
            //
            cb_loaiphong1.DisplayMember = "Tenloaiphong";
            cb_loaiphong1.ValueMember = "IDLP";
            cb_loaiphong1.DataSource = loadroom_BUS.Instance.loadcomboloaiphong();

        }
        private void bt_reset_phong_Click(object sender, EventArgs e)
        {
            reset();
            loadroom();
        }
        private void bt_them_phong_Click(object sender, EventArgs e)
        {
            string tenphong = txt_tenphong.Text;
            string maphong = txt_maphong.Text;
            int loaiphong = (int)cb_loaiphong.SelectedValue;
            int trangthai = (int)cb_trangthai.SelectedValue;
            string querycheck = "SELECT count([ID]) FROM t_phong WHERE ([ID] = '" + maphong + "') ";
            if (tenphong.Length != 0 && maphong.Length != 0)
            {
                if (loadroom_BUS.Instance.checktrung(querycheck) == false)
                {
                    loadroom_DTO room = new loadroom_DTO(maphong, tenphong, loaiphong, trangthai);
                    if (loadroom_BUS.Instance.addroom(room))
                    {
                        MessageBox.Show("Bạn đã thêm thành công phòng ", tenphong);
                        loadroom();
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

        private void dgv_phong_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgv_phong.RowCount; i++)
            {
                dgv_phong.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void dgv_phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maphong.Text = dgv_phong.CurrentRow.Cells[1].Value.ToString();
            lb_temp.Text = dgv_phong.CurrentRow.Cells[1].Value.ToString();
            txt_tenphong.Text = dgv_phong.CurrentRow.Cells[2].Value.ToString();
            cb_loaiphong.Text = dgv_phong.CurrentRow.Cells[3].Value.ToString();
            cb_trangthai.Text = dgv_phong.CurrentRow.Cells[4].Value.ToString();
        }

        private void bt_sua_phong_Click(object sender, EventArgs e)
        {
            string tenphong = txt_tenphong.Text;
            string maphong = txt_maphong.Text;
            int loaiphong = (int)cb_loaiphong.SelectedValue;
            int trangthai = (int)cb_trangthai.SelectedValue;
            string temp = lb_temp.Text;
            if (tenphong.Length != 0 && maphong.Length != 0)
            {
                loadroom_DTO room = new loadroom_DTO(maphong, tenphong, loaiphong, trangthai, temp);
                if (loadroom_BUS.Instance.suaphong(room))
                {
                    MessageBox.Show("Bạn đã sửa thành công phòng  " +tenphong);
                    loadroom();
                }
                else
                {
                    MessageBox.Show("Rất tiếc, Sửa không thành công");
                }
            }
            else { MessageBox.Show("Mời bạn nhập đầy đủ thông tin", "Thông báo"); }
        }
        private void bt_xoaphong_Click(object sender, EventArgs e)
        {
            string maphong = txt_maphong.Text;
            if (maphong.Length != 0)
            {
                loadroom_DTO room = new loadroom_DTO(maphong);
                DialogResult ok = MessageBox.Show("Bạn có muốn xóa " + maphong, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.Yes)
                {
                    if (loadroom_BUS.Instance.xoaphong(room))
                    {
                        MessageBox.Show("Bạn đã xóa thành công phòng  ", maphong);
                        loadroom();
                    }
                    else
                    {
                        MessageBox.Show("Rất tiếc, Xóa không thành công");
                    }
                }
            }
            else { MessageBox.Show("Mời bạn chọn đối tượng muốn xóa", "Thông báo"); }
        }
        private void bt_timphong_Click(object sender, EventArgs e)
        {
            string key = txt_timphong.Text;
            if (key.Length != 0)
            {
                loadroom_DTO room = new loadroom_DTO(key, "0");
                dgv_phong.DataSource = loadroom_BUS.Instance.timphong(room);
            }
            else { MessageBox.Show("Mời nhập thông tin muốn tìm kiếm"); }
        }
        #endregion
        // QUẢN LÝ LOẠI PHÒNG
        #region QUẢN LÝ LOẠI PHÒNG
        public void loadloaiphong()
        {
            dgv_loaiphong.DataSource = loaiphong_BUS.Instance.load_dgv();
        }
        private void dgv_loaiphong_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgv_loaiphong.RowCount; i++)
            {
                dgv_loaiphong.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void bt_reset_loaiphong_Click(object sender, EventArgs e)
        {
            txt_tenloaiphong.Text = "";
            txt_giaphong.Text = "";
            txt_songuoi.Text = "";
            loadloaiphong();
        }

        private void bt_xoa_loaiphong_Click(object sender, EventArgs e)
        {
            if (txt_maloaiphong.Text != "")
            {
                loaiphong_DTO lp = new loaiphong_DTO(txt_maloaiphong.Text);
                DialogResult ok = MessageBox.Show("Bạn có muốn xóa " + txt_maloaiphong.Text, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.Yes)
                {
                    if (loaiphong_BUS.Instance.xoaloaiphong(lp))
                    {
                        MessageBox.Show("Bạn đã xóa thành công phòng  ", txt_maloaiphong.Text);
                        loadloaiphong();
                    }
                    else
                    {
                        MessageBox.Show("Rất tiếc, Xóa không thành công");
                    }
                }
            }
            else { MessageBox.Show("Mời bạn chọn đối tượng muốn xóa", "Thông báo"); }
        }
        private void bt_them_loaiphong_Click(object sender, EventArgs e)
        {
            loaiphong_DTO lp = new loaiphong_DTO(txt_tenloaiphong.Text, txt_giaphong.Text, txt_songuoi.Text);
            string querycheck = "SELECT count([Tenloaiphong]) FROM t_loaiphong WHERE ([Tenloaiphong] = N'" + txt_tenloaiphong.Text + "') ";
            if (txt_tenloaiphong.Text != "" && txt_giaphong.Text!= "" && txt_songuoi.Text != "")
            {
                if (loadroom_BUS.Instance.checktrung(querycheck) == false)
                {
                    if (loaiphong_BUS.Instance.themloaiphong(lp))
                    {
                        MessageBox.Show("Bạn đã thêm thành công loại phòng " + txt_tenloaiphong.Text);
                        loadloaiphong();
                    }
                    else
                    {
                        MessageBox.Show("Rất tiếc, thêm không thành công");
                    }
                }
                else { MessageBox.Show("Tên loại phòng bị trùng"); }

            }
            else { MessageBox.Show("Mời nhập đầy đủ thông tin"); }

        }
        private void bt_sua_loaiphong_Click(object sender, EventArgs e)
        {
            if (txt_tenloaiphong.Text != "" && txt_giaphong.Text != "" && txt_songuoi.Text != "")
            {
                loaiphong_DTO lp = new loaiphong_DTO(txt_tenloaiphong.Text, txt_giaphong.Text, txt_songuoi.Text, txt_maloaiphong.Text);
                if (loaiphong_BUS.Instance.sualoaiphong(lp))
                {
                    MessageBox.Show("Bạn đã sửa thành công  loại phòng  " + txt_tenloaiphong.Text);
                    loadloaiphong();
                }
                else
                {
                    MessageBox.Show("Rất tiếc, Sửa không thành công");
                }
            }
            else { MessageBox.Show("Mời bạn nhập đầy đủ thông tin", "Thông báo"); }
        }
        private void dgv_loaiphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maloaiphong.Text = dgv_loaiphong.CurrentRow.Cells["idlp"].Value.ToString();
            txt_tenloaiphong.Text = dgv_loaiphong.CurrentRow.Cells["tenlp"].Value.ToString();
            txt_giaphong.Text = dgv_loaiphong.CurrentRow.Cells["gialp"].Value.ToString();
            txt_songuoi.Text = dgv_loaiphong.CurrentRow.Cells["songuoilp"].Value.ToString();
        }
        #endregion
        //QUẢN LÝ CƠ SỞ VẬT CHẤT
        #region QUẢN LÝ CSVC
        //PHÒNG VẬT TƯ
        public void loadthietbi()
        {
            cb_thietbi.DisplayMember = "Ten";
            cb_thietbi.ValueMember = "ID";
            cb_thietbi.DataSource = loadroom_BUS.Instance.loadcsvc();
        }
        public void load_dgv()
        {
            CSVC_DTO csvc = new CSVC_DTO(cb_loaiphong1.SelectedValue.ToString());
            dgv_phongvattu.DataSource = CSVC_BUS.Instance.load_dgv(csvc);
        }
        private void cb_loaiphong1_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_dgv();
        }
        private void dgv_phongvattu_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgv_phongvattu.RowCount; i++)
            {
                dgv_phongvattu.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void dgv_phongvattu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_idvattu.Text = dgv_phongvattu.CurrentRow.Cells["id"].Value.ToString();
            cb_thietbi.Text = dgv_phongvattu.CurrentRow.Cells["tenthietbi"].Value.ToString();
            num_soluong.Value = Convert.ToDecimal(dgv_phongvattu.CurrentRow.Cells["soluong"].Value);
        }
        private void bt_themvattu_Click(object sender, EventArgs e)
        {
            CSVC_DTO cs = new CSVC_DTO(cb_loaiphong1.SelectedValue.ToString(),cb_thietbi.SelectedValue.ToString(),num_soluong.Value.ToString());
            string querycheck = "SELECT count([Idcosovatchat]) FROM t_phongvattu WHERE ([Idcosovatchat] = N'" + cb_thietbi.SelectedValue.ToString() + "') ";
            if (cb_thietbi.Text != "" && num_soluong.Value != 0)
            {
                if (CSVC_BUS.Instance.themvattu(cs))
                {
                    MessageBox.Show("Bạn đã thêm thành công thiết bị " + cb_thietbi.Text);
                    load_dgv();
                }
                else
                {
                    MessageBox.Show("Rất tiếc, thêm không thành công");
                }
            }
            else { MessageBox.Show("Mời nhập đầy đủ thông tin"); }
        }
        private void bt_suathietbi_Click(object sender, EventArgs e)
        {
            if (lb_idvattu.Text != "")
            {
                CSVC_DTO cs = new CSVC_DTO(cb_loaiphong1.SelectedValue.ToString(),cb_thietbi.SelectedValue.ToString(),num_soluong.Value.ToString(),lb_idvattu.Text);
                if (CSVC_BUS.Instance.suavattu(cs))
                {
                    MessageBox.Show("Bạn đã sửa thành công thiết bị  " + txt_tencsvc.Text);
                    load_dgv();
                }
                else
                {
                    MessageBox.Show("Rất tiếc, Sửa không thành công");
                }
            }
            else { MessageBox.Show("Mời bạn nhập đầy đủ thông tin", "Thông báo"); }
        }

        private void bt_xoavattu_Click(object sender, EventArgs e)
        {
            if (lb_idvattu.Text != "")
            {
                CSVC_DTO cs = new CSVC_DTO(lb_idvattu.Text);
                DialogResult ok = MessageBox.Show("Bạn có muốn xóa " + cb_thietbi.Text, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.Yes)
                {
                    if (CSVC_BUS.Instance.xoavattu(cs))
                    {
                        MessageBox.Show("Bạn đã xóa thành công thiết bị  " + cb_thietbi.Text);
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
        //CSVC
        public void loadcsvc()
        {
            dgv_csvc.DataSource = loadroom_BUS.Instance.loadcsvc();
        }

        private void dgv_csvc_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgv_csvc.RowCount; i++)
            {
                dgv_csvc.Rows[i].Cells[0].Value = i + 1;
            }
        }
        
        
        private void dgv_csvc_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgv_csvc.RowCount; i++)
            {
                dgv_csvc.Rows[i].Cells[0].Value = i + 1;
            }
        }

        
        private void bt_resetsdp_Click(object sender, EventArgs e)
        {
            resetsdp();
        }
        private void dgv_csvc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           lb_idvsvc.Text = dgv_csvc.CurrentRow.Cells["ma"].Value.ToString();
            txt_tencsvc.Text = dgv_csvc.CurrentRow.Cells["ten"].Value.ToString();
            txt_gia.Text = dgv_csvc.CurrentRow.Cells["donvitinh"].Value.ToString();
        }
        private void bt_themcsvc_Click(object sender, EventArgs e)
        {
            CSVC_DTO cs = new CSVC_DTO(txt_tencsvc.Text,txt_gia.Text);
            string querycheck = "SELECT count([Ten]) FROM t_cosovatchat WHERE ([Ten] = '%" + txt_tencsvc.Text + "%') ";
            if ( txt_tencsvc.Text != "")
            {
                if (khachhang_BUS.Instance.checktrung(querycheck) == false)
                {
                    if (CSVC_BUS.Instance.themcsvc(cs))
                    {
                        MessageBox.Show("Bạn đã thêm thành công thiết bị "+ txt_tencsvc.Text);
                        loadcsvc();
                        loadthietbi();
                    }
                    else
                    {
                        MessageBox.Show("Rất tiếc, thêm không thành công");
                    }
                }

                else { MessageBox.Show("Mã thiết bị bị trùng, vui lòng nhập lại"); }
            }
            else MessageBox.Show("Mời nhập đầy đủ thông tin");
        }
        private void bt_xoacsvc_Click(object sender, EventArgs e)
        {
            if (lb_idvsvc.Text != "")
            {
                CSVC_DTO cs = new CSVC_DTO(lb_idvsvc.Text);
                DialogResult ok = MessageBox.Show("Bạn có muốn xóa " + txt_tencsvc.Text, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.Yes)
                {
                    if (CSVC_BUS.Instance.xoacsvc(cs))
                    {
                        MessageBox.Show("Bạn đã xóa thành công thiết bị  " + txt_tencsvc.Text);
                        loadcsvc();
                    }
                    else
                    {
                        MessageBox.Show("Rất tiếc, Xóa không thành công");
                    }
                }
            }
            else { MessageBox.Show("Mời bạn chọn đối tượng muốn xóa", "Thông báo"); }
        }
        private void bt_suacsvc_Click(object sender, EventArgs e)
        {
            if (lb_idvsvc.Text != "" && txt_tencsvc.Text != "")
            {
                CSVC_DTO cs = new CSVC_DTO(txt_tencsvc.Text, txt_gia.Text);
                if (CSVC_BUS.Instance.suacsvc(cs))
                {
                    MessageBox.Show("Bạn đã sửa thành công thiết bị  "+ txt_tencsvc.Text);
                    loadcsvc();
                }
                else
                {
                    MessageBox.Show("Rất tiếc, Sửa không thành công");
                }
            }
            else { MessageBox.Show("Mời bạn nhập đầy đủ thông tin", "Thông báo"); }
        }
        private void bt_resetcsvc_Click(object sender, EventArgs e)
        {
            txt_tencsvc.Text = "";
            txt_gia.Text = "";
            loadcsvc();
        }
        #endregion
        //SHOW THUÊ PHÒNG
        #region THUÊ PHÒNG
        public void load_dgvthuephong()
        {
            dgv_thuephong.DataSource = loadroom_BUS.Instance.load_dgvthuephong();
        }

        private void dgv_thuephong_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgv_thuephong.RowCount; i++)
            {
                dgv_thuephong.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void xuiButton1_Click(object sender, EventArgs e)
        {
            load_dgvthuephong();
        }
        public void load_hoadon()
        {
            dgv_hoadon.DataSource = loadroom_BUS.Instance.load_hoadon();
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            load_hoadon();
        }

        private void dgv_hoadon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgv_hoadon.RowCount; i++)
            {
                dgv_hoadon.Rows[i].Cells[0].Value = i + 1;
            }
        }
        #endregion
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
        
        }
        private void dgv_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maphong.Text = dgv_phong.CurrentRow.Cells[1].Value.ToString();
        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            resetsdp();
        }
    }
}
