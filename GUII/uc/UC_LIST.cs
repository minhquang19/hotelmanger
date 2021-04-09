using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUII
{
    public partial class UC_LIST : UserControl
    {
        public UC_LIST()
        {
            InitializeComponent();
        }
        #region TẠO THUỘC TÍNH
        private string tenphong;
        private string tinhtrang;
        private string loaiphong;
        private Color btn;
        private Color color_ten;
        private Color color_loaiphong;
        private Color color_tinhtrang;
        private Color color_text;
        public string Loaiphong
        {
            get { return loaiphong; }
            set { loaiphong = value; lb_loaiphong.Text = value; }
        }
        public string Tinhtrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; lb_tinhtrang.Text = value; }
        }
        public string Tenphong
        {
            get { return tenphong; }
            set { tenphong = value; lb_tenphong.Text = value; }
        }
        public Color Btn
        {
            get { return btn; }
            set { btn = value; btn_room.BackColor = value; }
        }
        public Color Color_ten
        {
            get { return color_ten; }
            set { color_ten = value; lb_tenphong.BackColor = value; }
        }
        public Color Color_loaiphong
        {
            get { return color_loaiphong; }
            set { color_loaiphong = value; lb_loaiphong.BackColor = value; }
        }
        public Color Color_tinhtrang
        {
            get { return color_tinhtrang; }
            set { color_tinhtrang = value; lb_tinhtrang.BackColor = value; }
        }
        public Color Color_text
        {
            get { return color_text; }
            set { color_text = value; lb_tinhtrang.ForeColor = value; }
        }
        #endregion
    }
}
