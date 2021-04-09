using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace QL_KS
{
    class GradientPanel:Panel
    {
        private System.ComponentModel.IContainer components;

        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new
            LinearGradientBrush(this.ClientRectangle, this.ColorTop,this.ColorBottom, 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
