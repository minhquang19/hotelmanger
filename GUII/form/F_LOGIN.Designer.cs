namespace QL_KS
{
    partial class F_LOGIN
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_LOGIN));
            this.gradientPanel1 = new QL_KS.GradientPanel();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.bt_showpass = new XanderUI.XUISuperButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.DarkGreen;
            this.gradientPanel1.ColorTop = System.Drawing.Color.LightSeaGreen;
            this.gradientPanel1.Controls.Add(this.txt_pass);
            this.gradientPanel1.Controls.Add(this.txt_user);
            this.gradientPanel1.Controls.Add(this.bt_showpass);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.bt_login);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(327, 506);
            this.gradientPanel1.TabIndex = 12;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(123)))), ((int)(((byte)(51)))));
            this.txt_pass.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.SystemColors.Menu;
            this.txt_pass.Location = new System.Drawing.Point(27, 337);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(264, 34);
            this.txt_pass.TabIndex = 25;
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(135)))), ((int)(((byte)(77)))));
            this.txt_user.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.SystemColors.Menu;
            this.txt_user.Location = new System.Drawing.Point(27, 259);
            this.txt_user.Multiline = true;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(264, 34);
            this.txt_user.TabIndex = 24;
            // 
            // bt_showpass
            // 
            this.bt_showpass.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(123)))), ((int)(((byte)(50)))));
            this.bt_showpass.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bt_showpass.ButtonImage")));
            this.bt_showpass.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.bt_showpass.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.bt_showpass.ButtonText = "";
            this.bt_showpass.CornerRadius = 5;
            this.bt_showpass.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bt_showpass.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(110)))), ((int)(((byte)(20)))));
            this.bt_showpass.HoverTextColor = System.Drawing.Color.White;
            this.bt_showpass.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.bt_showpass.Location = new System.Drawing.Point(293, 337);
            this.bt_showpass.Name = "bt_showpass";
            this.bt_showpass.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(110)))), ((int)(((byte)(20)))));
            this.bt_showpass.SelectedTextColor = System.Drawing.Color.White;
            this.bt_showpass.Size = new System.Drawing.Size(32, 31);
            this.bt_showpass.SuperSelected = false;
            this.bt_showpass.TabIndex = 21;
            this.bt_showpass.TextColor = System.Drawing.Color.White;
            this.bt_showpass.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bt_showpass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_showpass_MouseDown);
            this.bt_showpass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_showpass_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(128)))), ((int)(((byte)(62)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(23, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "PassWord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(140)))), ((int)(((byte)(89)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(23, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "User Name";
            // 
            // bt_login
            // 
            this.bt_login.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bt_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bt_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_login.BorderRadius = 0;
            this.bt_login.ButtonText = "  LOGIN";
            this.bt_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_login.DisabledColor = System.Drawing.Color.Gray;
            this.bt_login.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_login.Iconimage = ((System.Drawing.Image)(resources.GetObject("bt_login.Iconimage")));
            this.bt_login.Iconimage_right = null;
            this.bt_login.Iconimage_right_Selected = null;
            this.bt_login.Iconimage_Selected = null;
            this.bt_login.IconMarginLeft = 0;
            this.bt_login.IconMarginRight = 0;
            this.bt_login.IconRightVisible = true;
            this.bt_login.IconRightZoom = 0D;
            this.bt_login.IconVisible = true;
            this.bt_login.IconZoom = 60D;
            this.bt_login.IsTab = false;
            this.bt_login.Location = new System.Drawing.Point(91, 394);
            this.bt_login.Name = "bt_login";
            this.bt_login.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bt_login.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bt_login.OnHoverTextColor = System.Drawing.Color.White;
            this.bt_login.selected = false;
            this.bt_login.Size = new System.Drawing.Size(142, 48);
            this.bt_login.TabIndex = 12;
            this.bt_login.Text = "  LOGIN";
            this.bt_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_login.Textcolor = System.Drawing.Color.White;
            this.bt_login.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // F_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(327, 498);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "F_LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bt_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private XanderUI.XUISuperButton bt_showpass;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
    }
}

