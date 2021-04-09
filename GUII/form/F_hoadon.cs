using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using DTO;
using COMExcel = Microsoft.Office.Interop.Excel;
using BUS;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUII.form
{
    public partial class F_HOADON : Form
    {
        #region khai bao
        private string idnhanvien;
        private string ten;
        private int idthuephong;
        private string makh;
        private string sdt;
        private string checkin;
        private string maphong;
        private string loaiphong;
        private string ngayo;
        private string loai;
        private string tienphong;
        private string tiendv;
        private string khuyenmai;
        private string vat;
        private string tongtien;
        private string nhanvien;
        public string Ten { get => ten; set => ten = value; }
        public string Makh { get => makh; set => makh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Checkin { get => checkin; set => checkin = value; }
        public string Maphong { get => maphong; set => maphong = value; }
        public string Loaiphong { get => loaiphong; set => loaiphong = value; }
        public string Ngayo { get => ngayo; set => ngayo = value; }
        public string Loai { get => loai; set => loai = value; }
        public string Tienphong { get => tienphong; set => tienphong = value; }
        public string Tiendv { get => tiendv; set => tiendv = value; }
        public string Khuyenmai { get => khuyenmai; set => khuyenmai = value; }
        public string Vat { get => vat; set => vat = value; }
        public string Tongtien { get => tongtien; set => tongtien = value; }
        public string Nhanvien { get => nhanvien; set => nhanvien = value; }
        public int Idthuephong { get => idthuephong; set => idthuephong = value; }
        public string Idnhanvien { get => idnhanvien; set => idnhanvien = value; }
        #endregion
        public F_HOADON(string ten, string makh, string sdt, string checkin, string maphong, string loaiphong, string ngayo, string tienthuephong, string tiendichvu, string khuyenmai, string vat, string tongtien, string nhanvien,int idthuephong,string date)
        {
            this.Ten = ten;
            this.Khuyenmai = khuyenmai;
            this.Makh = makh;
            this.Sdt = sdt;
            this.Checkin = checkin;
            this.Maphong = maphong;
            this.Loaiphong = loaiphong;
            this.Vat = vat;
            this.Ngayo = ngayo;
            this.Tongtien = tongtien;
            this.Tiendv = tiendichvu;
            this.Tienphong = tienthuephong;
            this.Nhanvien = nhanvien;
            this.Idthuephong = idthuephong;
            InitializeComponent();
        }
        public F_HOADON()
        {

        }
        private void F_HOADON_Load(object sender, EventArgs e)
        {
            load_dgv();
            lb_tenkh.Text = Ten;
            lb_makh.Text = Makh;
            lb_sdt.Text = Sdt;
            lb_checkin.Text = Checkin;
            lb_maphong.Text = Maphong;
            lb_loaiphong.Text = loaiphong;
            lb_khuyenmai.Text = khuyenmai;
            lb_songayo.Text = ngayo;
            lb_tienthuephong.Text = Tienphong;
            lb_tiendichvu.Text = Tiendv;
            lb_vat.Text = vat;
            lb_tongtien.Text = tongtien;
            lb_nhanvientt.Text = nhanvien;
            LB_DATE.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void bt_traphong_Click(object sender, EventArgs e)
        {
            user_DTO u = new user_DTO(Nhanvien);
            DataTable data = new DataTable();
            data = user_BUS.Instance.load_user(u);
            foreach (DataRow row in data.Rows)
            {
               this.Idnhanvien = row["Idnhanvien"].ToString();
            }
            traphong_DTO bill = new traphong_DTO(Idnhanvien, Makh, Maphong, Tongtien, "CHƯA THANH TOÁN", Tienphong, Tiendv, Khuyenmai, DateTime.Now.ToString("MM/dd/yyyy"));
            if (traphong_BUS.Instance.thembill(bill))
            {
                 MessageBox.Show("Lưu hóa đơn thành công");
            }    

        }
        public void load_dgv()
        {
            traphong_DTO dv = new traphong_DTO(Idthuephong);
            dgv_hoadon.DataSource = traphong_BUS.Instance.load_dgv(dv);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql, sql1,sql2;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang,tblGia;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["C1:G1"].Font.Size = 16;
            exRange.Range["C1:G1"].Font.Bold = true;
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["C1:G1"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["C1:G1"].MergeCells = true;
            exRange.Range["C1:G1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C1:G1"].Value = "KHÁCH SẠN MINH QUANG";
            exRange.Range["F2:G2"].MergeCells = true;
            //exRange.Range["F2:G2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["F2:G2"].Value = "Số Điện Thoại : 0389769239";
            exRange.Range["F3:H3"].MergeCells = true;
            //exRange.Range["F3:H3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["F3:H3"].Value = "Địa Chỉ : 41A Phú Diễn Bắc Từ Liêm Hà Nội";
            exRange.Range["C5:G5"].Font.Size = 16;
            exRange.Range["C5:G5"].Font.Bold = true;
            exRange.Range["C5:G5"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C5:G5"].MergeCells = true;
            exRange.Range["C5:G5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C5:G5"].Value = "HÓA ĐƠN TRẢ PHÒNG";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LBVNLAK;Initial Catalog=QL_KHACHSAN;Integrated Security=True");
            sql = "SELECT t_khachhang.Ten,t_khachhang.ID,t_hoadonthu.Idphong,t_thuephong.Checkin FROM t_khachhang,t_hoadonthu,t_thuephong WHERE t_hoadonthu.Idkhachhang = t_khachhang.ID and t_thuephong.Idphong = t_hoadonthu.Idphong and t_thuephong.ID = '"+Idthuephong+"'";
            DataTable table = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            dap.Fill(table);
            tblThongtinHD = table;
            // Thông tin chung
            exRange.Range["C7:C7"].Font.Size = 12;
            exRange.Range["C7:C7"].Font.Bold = true;
            exRange.Range["C7:C7"].Value = "Tên Khách Hàng:";
            exRange.Range["C7:C7"].ColumnWidth = 20;
            exRange.Range["D7:D7"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["F7:F7"].Font.Bold = true;
            exRange.Range["F7:F7"].ColumnWidth = 20;
            //exRange.Range["F7:F7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["F7:F7"].Font.Size = 12;
            exRange.Range["F7:F7"].Value = " Mã Khách hàng:";
            exRange.Range["G7:G7"].Value = tblThongtinHD.Rows[0][1].ToString();
            exRange.Range["C9:C9"].Value = "Mã Phòng:";
            exRange.Range["C9:C9"].Font.Bold = true;
            exRange.Range["D9:D9"].Value = tblThongtinHD.Rows[0][2].ToString();
            exRange.Range["F9:F9"].Value = "Check In :";
            exRange.Range["F9:F9"].Font.Bold = true;
            exRange.Range["G9:G9"].Value = tblThongtinHD.Rows[0][3].ToString();
            //Lấy thông tin dịch vụ

            sql1 = "SELECT t_dichvu.Ten,t_dichvu.Dongia,t_sudungdichvu.Soluong,(t_sudungdichvu.Soluong * t_dichvu.Dongia) as 'Thanhtien' FROM t_sudungdichvu, t_dichvu, t_thuephong, t_loaidichvu WHERE t_sudungdichvu.Iddichvu = t_dichvu.ID and t_sudungdichvu.Idthuephong = t_thuephong.ID and t_loaidichvu.ID = t_dichvu.Idloai and t_thuephong.ID = '"+Idthuephong+"'";
            SqlDataAdapter dap1 = new SqlDataAdapter(sql1, con);
            DataTable dt = new DataTable();
            dap1.Fill(dt);
            tblThongtinHang = dt;
            exRange.Range["C12:G12"].Font.Bold = true;
            exRange.Range["C12:G12"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C12:G12"].ColumnWidth = 20;
            exRange.Range["C12:C12"].Value = "STT";
            exRange.Range["D12:D12"].Value = "Tên Dịch Vụ";
            exRange.Range["E12:E12"].Value = "Đơn Gia";
            exRange.Range["F12:F12"].Value = "Số Lượng";
            exRange.Range["G12:G12"].Value = "Thành Tiền";
            exRange.Range["C12:G12"].Borders.LineStyle = COMExcel.XlLineStyle.xlContinuous;
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                exSheet.Cells[3][hang + 13].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exSheet.Cells[3][hang + 13] = hang + 1;
                exSheet.Cells[3][hang + 13].Borders.LineStyle = COMExcel.XlLineStyle.xlContinuous;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 4][hang + 13].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                    exSheet.Cells[cot + 4][hang + 13].Borders.LineStyle = COMExcel.XlLineStyle.xlContinuous;
                    exSheet.Cells[cot + 4][hang + 13] = tblThongtinHang.Rows[hang][cot].ToString();
                }
            }
            sql2 = "SELECT t_hoadonthu.Tienthuephong,t_hoadonthu.Tiendichvu,t_hoadonthu.Khuyenmai,t_hoadonthu.Tongtien,t_nhanvien.Ten FROM t_hoadonthu,t_nhanvien WHERE t_hoadonthu.Idnhanvien = t_nhanvien.ID and t_hoadonthu.ID = (SELECT MAX(ID) FROM t_hoadonthu) ";
            SqlDataAdapter dap2 = new SqlDataAdapter(sql2, con);
            DataTable dt2 = new DataTable();
            dap2.Fill(dt2);
            tblGia  = dt2;
            exRange = exSheet.Cells[cot][hang + 15];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tiền Thuê Phòng:";
            exRange = exSheet.Cells[cot + 1][hang + 15];
            exRange.Font.Bold = true;
            exRange.Value2 = tblGia.Rows[0][0].ToString();
            exRange = exSheet.Cells[cot][hang + 16];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tiền Dịch Vụ:";
            exRange = exSheet.Cells[cot + 1][hang + 16];
            exRange.Font.Bold = true;
            exRange.Value2 = tblGia.Rows[0][1].ToString();
            exRange = exSheet.Cells[cot][hang + 17];
            exRange.Font.Bold = true;
            exRange.Value2 = "Khuyến Mại:";
            exRange = exSheet.Cells[cot + 1][hang + 17];
            exRange.Font.Bold = true;
            exRange.Value2 = tblGia.Rows[0][2].ToString() + "%";
            exRange = exSheet.Cells[cot][hang + 18];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng Tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 18];
            exRange.Font.Bold = true;
            exRange.Value2 = tblGia.Rows[0][3].ToString();
            exRange = exSheet.Cells[cot + 3][hang + 15];
            exRange.Font.Bold = true;
            exRange.Value2 = "Nhân Viên ";
            exRange = exSheet.Cells[cot + 3][hang + 17];
            exRange.Font.Bold = true;
            exRange.Value2 = tblGia.Rows[0][4].ToString();
            exApp.Visible = true;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
