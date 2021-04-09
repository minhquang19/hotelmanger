namespace GUII
{
    partial class UC_LIST
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
            this.lb_tinhtrang = new System.Windows.Forms.Label();
            this.btn_room = new System.Windows.Forms.Button();
            this.lb_tenphong = new System.Windows.Forms.Label();
            this.lb_loaiphong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_tinhtrang
            // 
            this.lb_tinhtrang.AutoSize = true;
            this.lb_tinhtrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(224)))), ((int)(((byte)(184)))));
            this.lb_tinhtrang.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tinhtrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(162)))), ((int)(((byte)(99)))));
            this.lb_tinhtrang.Location = new System.Drawing.Point(85, 32);
            this.lb_tinhtrang.Name = "lb_tinhtrang";
            this.lb_tinhtrang.Size = new System.Drawing.Size(81, 18);
            this.lb_tinhtrang.TabIndex = 6;
            this.lb_tinhtrang.Text = "Có Người";
            // 
            // btn_room
            // 
            this.btn_room.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(162)))), ((int)(((byte)(99)))));
            this.btn_room.Location = new System.Drawing.Point(-1, -2);
            this.btn_room.Name = "btn_room";
            this.btn_room.Size = new System.Drawing.Size(80, 86);
            this.btn_room.TabIndex = 7;
            this.btn_room.UseVisualStyleBackColor = false;
            // 
            // lb_tenphong
            // 
            this.lb_tenphong.AutoSize = true;
            this.lb_tenphong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(162)))), ((int)(((byte)(99)))));
            this.lb_tenphong.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenphong.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_tenphong.Location = new System.Drawing.Point(12, 15);
            this.lb_tenphong.Name = "lb_tenphong";
            this.lb_tenphong.Size = new System.Drawing.Size(57, 25);
            this.lb_tenphong.TabIndex = 9;
            this.lb_tenphong.Text = "101";
            // 
            // lb_loaiphong
            // 
            this.lb_loaiphong.AutoSize = true;
            this.lb_loaiphong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(162)))), ((int)(((byte)(99)))));
            this.lb_loaiphong.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loaiphong.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_loaiphong.Location = new System.Drawing.Point(18, 49);
            this.lb_loaiphong.Name = "lb_loaiphong";
            this.lb_loaiphong.Size = new System.Drawing.Size(44, 16);
            this.lb_loaiphong.TabIndex = 10;
            this.lb_loaiphong.Text = "STD1";
            // 
            // UC_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(224)))), ((int)(((byte)(184)))));
            this.Controls.Add(this.lb_loaiphong);
            this.Controls.Add(this.lb_tenphong);
            this.Controls.Add(this.btn_room);
            this.Controls.Add(this.lb_tinhtrang);
            this.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.Name = "UC_LIST";
            this.Size = new System.Drawing.Size(170, 84);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_tinhtrang;
        private System.Windows.Forms.Button btn_room;
        private System.Windows.Forms.Label lb_tenphong;
        private System.Windows.Forms.Label lb_loaiphong;
    }
}
