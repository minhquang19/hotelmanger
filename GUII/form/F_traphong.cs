using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUII.form
{
    public partial class F_traphong : Form
    {
        #region KHAI BÁO
        private string mota;
        public decimal Tienphong;
        private string user;
        private string tenkh;
        public string makh;
        public string sdt;
        public string checkin;
        public string songay;
        private string maphong;
        public decimal temp = 0;
        public decimal sum = 0;
        private string tenphong;
        private string loaiphong;
        private int idthuephong;
        public String Name_user = null;
        private static F_traphong instance;
        public string Maphong { get => maphong; set => maphong = value; }
        public string Tenphong { get => tenphong; set => tenphong = value; }
        public string Loaiphong { get => loaiphong; set => loaiphong = value; }
        public int Idthuephong { get => idthuephong; set => idthuephong = value; }

        public static F_traphong Instance
        {
            get { if (instance == null) instance = new F_traphong(); return F_traphong.instance; }
            private set { F_traphong.instance = value; }
        }

        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string User { get => user; set => user = value; }
        public string Mota { get => mota; set => mota = value; }

        public F_traphong() { }
        #endregion
        public F_traphong(string ma, string ten, string loai, string user)
        {
            InitializeComponent();
            this.Maphong = ma;
            this.Tenphong = ten;
            this.Loaiphong = loai;
            this.User = user;
            showinfo();
            showdichvu();
        }
        //SHOW INFO
        public void showinfo()
        {
            txt_maphong.Text = Maphong;
            txt_checkout.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txt_loaiphong.Text = Loaiphong;
            txt_nhanvien.Text = User;
            #region LAY THONG TN
            // LẤY MÃ KHÁCH HÀNG
            traphong_DTO tp = new traphong_DTO(Maphong);
            DataTable dt = new DataTable();
            dt = traphong_BUS.Instance.load_thuephong(tp);
            foreach (DataRow row in dt.Rows)
            {
                txt_makh.Text = row["Idkhachhang"].ToString();
                this.makh = row["Idkhachhang"].ToString();
                this.Idthuephong = (int)row["ID"];
                txt_checkin.Text = Convert.ToDateTime(row["Checkin"]).ToString("dd/MM/yyyy");
                this.checkin = Convert.ToDateTime(row["Checkin"]).ToString("dd/MM/yyyy"); ;
            }
            //HỌ TÊN KHÁCH HÀNG
            traphong_DTO kh = new traphong_DTO(txt_makh.Text);
            DataTable data = new DataTable();
            data = traphong_BUS.Instance.load_kh(kh);
            foreach (DataRow row in data.Rows)
            {
                txt_hoten.Text = row["Ten"].ToString();
                this.Tenkh = row["Ten"].ToString();
                this.sdt = row["Sdt"].ToString();
            }
            // PHÍ THUÊ PHÒNG
            traphong_DTO phithue = new traphong_DTO(Idthuephong);
            DataTable data1 = new DataTable();
            data1 = traphong_BUS.Instance.load_phithue(phithue);
            foreach (DataRow row in data1.Rows)
            {
                txt_phithuephong.Text = string.Format("{0:0,0 VNĐ}", (decimal)row["Thuephong"]);
                txt_songay.Text = row["Songay"].ToString();
                this.songay = row["Songay"].ToString();
                this.Tienphong = (decimal)row["Thuephong"];
            }
            #endregion
        }
        // SHOW DGV DICH VU
        public void showdichvu()
        {
            traphong_DTO dv = new traphong_DTO(Idthuephong);
            dgv_dv.DataSource = traphong_BUS.Instance.load_dgv(dv);

            for (int r = 0; r < dgv_dv.Rows.Count; r++)
            {
                temp = Convert.ToDecimal(dgv_dv.Rows[r].Cells["thanhtien"].Value);
                sum = sum + temp;
            }
            txt_phidichvu.Text = string.Format("{0:0,0 VNĐ}", sum);

        }
        //STT
        private void dgv_dv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgv_dv.RowCount; i++)
            {
                dgv_dv.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //TÍNH TIỀN THEO KHUYẾN MẠI %
        private void txt_khuyenmai_OnValueChanged(object sender, EventArgs e)
        {
            decimal khuyenmai;
            if (txt_khuyenmai.Text == "") khuyenmai = 0;
            else { khuyenmai = Convert.ToDecimal(txt_khuyenmai.Text) / 100; }
            decimal VAT = ((Tienphong + sum) * (1 - khuyenmai)) / 10;
            decimal Tongtien = ((Tienphong + sum) * (1 - khuyenmai)) + VAT;
            txt_vat.Text = string.Format("{0:0,0 VNĐ}", VAT);
            txt_tongcong.Text = string.Format("{0:0,0 VNĐ}", Tongtien);
        }
        //TRẢ PHÒNG
        private void bt_traphong_Click(object sender, EventArgs e)
        {
            gethoadon();
            traphong_DTO tp = new traphong_DTO(Maphong);
            traphong_DTO xp = new traphong_DTO(Idthuephong);
            DialogResult ok = MessageBox.Show("Bạn có muốn trả phòng " + Maphong + "  không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ok == DialogResult.Yes)
            {
                traphong_DTO bill = new traphong_DTO(Maphong);
                if (traphong_BUS.Instance.thanhtoan(bill))
                {
                    if (traphong_BUS.Instance.traphong_sua(tp))
                    {
                        if (traphong_BUS.Instance.xoathuephong(xp))
                        {
                            MessageBox.Show("Bạn đã trả phòng   " + Maphong);
                        }
                        else
                        {
                            MessageBox.Show("Rất tiếc,Trả không thành công");
                        }


                            //    if (traphong_BUS.Instance.traphong_sua(tp))
                            //    {
                            //        if (traphong_BUS.Instance.xoathuephong(xp))
                            //        {
                            //            traphong_DTO bill = new traphong_DTO(Maphong);
                            //            if(traphong_BUS.Instance.thanhtoan(bill))
                            //            {
                            //                MessageBox.Show("Bạn đã trả phòng   " + Maphong);
                            //            }
                            //            else { MessageBox.Show("Chưa có hóa đơn cho phòng " + Maphong); }

                            //        }
                            //        else { MessageBox.Show("Chưa có hóa đơn cho phòng " + Maphong); }
                            //    }
                            //    else
                            //    {
                            //        MessageBox.Show("Rất tiếc,Trả không thành công");
                            //    }

                    }

                }
                else { MessageBox.Show("Chưa có hóa đơn cho phòng " + Maphong); }
            }
        }
        private void bt_hoadon_Click(object sender, EventArgs e)
        {
           
            F_HOADON f = new F_HOADON(txt_hoten.Text, txt_makh.Text, sdt, checkin, maphong, loaiphong, songay, txt_phithuephong.Text, txt_phidichvu.Text, txt_khuyenmai.Text, txt_vat.Text, txt_tongcong.Text,txt_nhanvien.Text,Idthuephong, DateTime.Now.ToString("dd/MM/yyyy"));
            f.ShowDialog();
        }
        public void gethoadon()
        {
            room_DTO kh = new room_DTO(Maphong);
            DataTable data = new DataTable();
            data = loadroom_BUS.Instance.load_hoadon1(kh);
            foreach (DataRow row in data.Rows)
            {
                this.Mota = row["Mota"].ToString();
            }
            if(Mota =="Chưa Thanh Toán")
            {
                MessageBox.Show("Chưa thanh toán");
            }    
        }
    }
}
