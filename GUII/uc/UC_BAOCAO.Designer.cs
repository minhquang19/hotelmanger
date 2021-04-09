namespace GUII.uc
{
    partial class UC_BAOCAO
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_BAOCAO));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_tu = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_den = new System.Windows.Forms.DateTimePicker();
            this.bt_xembaocao = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(162)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 58);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(431, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUII.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 111);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(931, 486);
            this.reportViewer1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F);
            this.label2.Location = new System.Drawing.Point(125, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Từ";
            // 
            // dt_tu
            // 
            this.dt_tu.Font = new System.Drawing.Font("Verdana", 12F);
            this.dt_tu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_tu.Location = new System.Drawing.Point(171, 74);
            this.dt_tu.Name = "dt_tu";
            this.dt_tu.Size = new System.Drawing.Size(121, 27);
            this.dt_tu.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F);
            this.label3.Location = new System.Drawing.Point(329, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Đến";
            // 
            // dt_den
            // 
            this.dt_den.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_den.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_den.Location = new System.Drawing.Point(390, 74);
            this.dt_den.Name = "dt_den";
            this.dt_den.Size = new System.Drawing.Size(130, 27);
            this.dt_den.TabIndex = 8;
            // 
            // bt_xembaocao
            // 
            this.bt_xembaocao.ActiveBorderThickness = 1;
            this.bt_xembaocao.ActiveCornerRadius = 20;
            this.bt_xembaocao.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bt_xembaocao.ActiveForecolor = System.Drawing.Color.White;
            this.bt_xembaocao.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bt_xembaocao.BackColor = System.Drawing.SystemColors.Control;
            this.bt_xembaocao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_xembaocao.BackgroundImage")));
            this.bt_xembaocao.ButtonText = "Xem Báo Cáo";
            this.bt_xembaocao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_xembaocao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xembaocao.ForeColor = System.Drawing.Color.SeaGreen;
            this.bt_xembaocao.IdleBorderThickness = 1;
            this.bt_xembaocao.IdleCornerRadius = 20;
            this.bt_xembaocao.IdleFillColor = System.Drawing.Color.White;
            this.bt_xembaocao.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bt_xembaocao.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bt_xembaocao.Location = new System.Drawing.Point(712, 61);
            this.bt_xembaocao.Margin = new System.Windows.Forms.Padding(5);
            this.bt_xembaocao.Name = "bt_xembaocao";
            this.bt_xembaocao.Size = new System.Drawing.Size(181, 45);
            this.bt_xembaocao.TabIndex = 9;
            this.bt_xembaocao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_xembaocao.Click += new System.EventHandler(this.bt_xembaocao_Click);
            // 
            // UC_BAOCAO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_xembaocao);
            this.Controls.Add(this.dt_den);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_tu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "UC_BAOCAO";
            this.Size = new System.Drawing.Size(937, 600);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_tu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_den;
        private Bunifu.Framework.UI.BunifuThinButton2 bt_xembaocao;
    }
}
