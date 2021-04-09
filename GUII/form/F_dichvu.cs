using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DTO;
using BUS;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUII.form
{
    public partial class F_dichvu : Form
    {
        #region KHAI BÁO
        private string tam;
        private int idthuephong;

        public string Tam { get => tam; set => tam = value; }
        public int Idthuephong { get => idthuephong; set => idthuephong = value; }
        #endregion
        #region HÀM
        public F_dichvu(string ma, string ten, string loai)
        {
            InitializeComponent();
            txt_maphong.Text = ma;
            this.Tam = ma;
            txt_tenphong.Text = ten;
            cb_loaidv.SelectedValue = null;
            txt_loaiphong.Text = loai;
            loadkh();
            loadloaidv();
            load_dgv();

        }
        public void loadkh()
        {
            dichvu_DTO dv = new dichvu_DTO(Tam);
            DataTable dt = new DataTable();
            dt = dichvu_BUS.Instance.loadkh(dv);
            foreach (DataRow row in dt.Rows)
            {
                txt_makh.Text = row["Idkhachhang"].ToString();
                this.Idthuephong = (int)row["ID"];
            }
        }
        public void loadloaidv()
        {
            cb_loaidv.DisplayMember = "Ten";
            cb_loaidv.ValueMember = "ID";
            cb_loaidv.DataSource = dichvu_BUS.Instance.loadloaidichvu();
        }    
        public void load_dgv()
        {
            dichvu_DTO dv = new dichvu_DTO(Idthuephong);
            dgv_dichvu.DataSource = dichvu_BUS.Instance.load_dgv(dv);
        }
        #endregion
        #region SỰ KIỆN
        private void cb_loaidv_SelectedIndexChanged(object sender, EventArgs e)
        {
            dichvu_DTO dv = new dichvu_DTO(cb_loaidv.SelectedValue.ToString());
            cb_dichvu.DisplayMember = "Ten";
            cb_dichvu.ValueMember = "ID";
            cb_dichvu.DataSource = dichvu_BUS.Instance.loaddichvu(dv);
        }
        private void dgv_dichvu_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgv_dichvu.RowCount; i++)
            {
                dgv_dichvu.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bt_them_phong_Click(object sender, EventArgs e)
        {
            dichvu_DTO dv = new dichvu_DTO(Idthuephong, (int)cb_dichvu.SelectedValue, (int)num_soluong.Value);
            if(num_soluong.Value != 0)
            {
                if (dichvu_BUS.Instance.themdichvu(dv))
                {
                    MessageBox.Show("Thêm dịch vụ thành công");
                    load_dgv();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else { MessageBox.Show("Vui Lòng Nhập Số Lượng"); }

        }
        private void dgv_dichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_loaidv.Text = dgv_dichvu.CurrentRow.Cells["loai"].Value.ToString();
            lb_id.Text = dgv_dichvu.CurrentRow.Cells["id"].Value.ToString();
            cb_dichvu.Text = dgv_dichvu.CurrentRow.Cells["dichvu"].Value.ToString();
            num_soluong.Value = Convert.ToDecimal(dgv_dichvu.CurrentRow.Cells["Soluong"].Value);

        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lb_id.Text);
            dichvu_DTO dv = new dichvu_DTO(id);
            if (lb_id.Text != "")
            {
                if (dichvu_BUS.Instance.xoadichvu(dv))
                {
                    MessageBox.Show("Xóa dịch vụ thành công");
                    load_dgv();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            else { MessageBox.Show("Vui Lòng chọn đối tượng"); }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lb_id.Text);
            dichvu_DTO dv = new dichvu_DTO(id,(int)cb_dichvu.SelectedValue, (int)num_soluong.Value);
            if (num_soluong.Value != 0)
            {
                if (dichvu_BUS.Instance.suadichvu(dv))
                {
                    MessageBox.Show("Sửa dịch vụ thành công");
                    load_dgv();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
            else { MessageBox.Show("Vui Lòng Nhập Số Lượng"); }
        }
        #endregion
    }
}
