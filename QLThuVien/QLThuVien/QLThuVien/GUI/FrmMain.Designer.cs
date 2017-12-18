namespace QLThuVien.GUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDoiMatKhau = new System.Windows.Forms.LinkLabel();
            this.txtTTNhanVien = new System.Windows.Forms.Label();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnQuanLyDocGia = new System.Windows.Forms.Button();
            this.btnNhapSach = new System.Windows.Forms.Button();
            this.btnQuanLyMuonTra = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnQuanLyDauSach = new System.Windows.Forms.Button();
            this.btnQuanLyNhanViem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelMain);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.PanelMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 701);
            this.panel1.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(220, 27);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1136, 672);
            this.panelMain.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtDoiMatKhau);
            this.panel2.Controls.Add(this.txtTTNhanVien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(220, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1136, 27);
            this.panel2.TabIndex = 1;
            // 
            // txtDoiMatKhau
            // 
            this.txtDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtDoiMatKhau.Location = new System.Drawing.Point(752, 0);
            this.txtDoiMatKhau.Name = "txtDoiMatKhau";
            this.txtDoiMatKhau.Size = new System.Drawing.Size(70, 25);
            this.txtDoiMatKhau.TabIndex = 1;
            this.txtDoiMatKhau.TabStop = true;
            this.txtDoiMatKhau.Text = "Đổi mật khẩu";
            this.txtDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtDoiMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtDoiMatKhau_LinkClicked);
            // 
            // txtTTNhanVien
            // 
            this.txtTTNhanVien.BackColor = System.Drawing.Color.Teal;
            this.txtTTNhanVien.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtTTNhanVien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTNhanVien.ForeColor = System.Drawing.Color.White;
            this.txtTTNhanVien.Location = new System.Drawing.Point(822, 0);
            this.txtTTNhanVien.Name = "txtTTNhanVien";
            this.txtTTNhanVien.Size = new System.Drawing.Size(312, 25);
            this.txtTTNhanVien.TabIndex = 0;
            this.txtTTNhanVien.Text = "Phạm Thị Quỳnh - Nhân viên";
            this.txtTTNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.White;
            this.PanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMenu.Controls.Add(this.btnQuanLyDocGia);
            this.PanelMenu.Controls.Add(this.btnNhapSach);
            this.PanelMenu.Controls.Add(this.btnQuanLyMuonTra);
            this.PanelMenu.Controls.Add(this.btnDong);
            this.PanelMenu.Controls.Add(this.btnQuanLyDauSach);
            this.PanelMenu.Controls.Add(this.btnQuanLyNhanViem);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(220, 699);
            this.PanelMenu.TabIndex = 0;
            // 
            // btnQuanLyDocGia
            // 
            this.btnQuanLyDocGia.BackColor = System.Drawing.Color.White;
            this.btnQuanLyDocGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyDocGia.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuanLyDocGia.FlatAppearance.BorderSize = 2;
            this.btnQuanLyDocGia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuanLyDocGia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnQuanLyDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuanLyDocGia.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDocGia.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLyDocGia.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLyDocGia.Image")));
            this.btnQuanLyDocGia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuanLyDocGia.Location = new System.Drawing.Point(3, 215);
            this.btnQuanLyDocGia.Name = "btnQuanLyDocGia";
            this.btnQuanLyDocGia.Size = new System.Drawing.Size(213, 100);
            this.btnQuanLyDocGia.TabIndex = 8;
            this.btnQuanLyDocGia.Text = "QUẢN LÝ ĐỘC GIẢ";
            this.btnQuanLyDocGia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuanLyDocGia.UseVisualStyleBackColor = false;
            // 
            // btnNhapSach
            // 
            this.btnNhapSach.BackColor = System.Drawing.Color.White;
            this.btnNhapSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNhapSach.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNhapSach.FlatAppearance.BorderSize = 2;
            this.btnNhapSach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNhapSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNhapSach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNhapSach.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapSach.ForeColor = System.Drawing.Color.Black;
            this.btnNhapSach.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapSach.Image")));
            this.btnNhapSach.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNhapSach.Location = new System.Drawing.Point(3, 321);
            this.btnNhapSach.Name = "btnNhapSach";
            this.btnNhapSach.Size = new System.Drawing.Size(213, 100);
            this.btnNhapSach.TabIndex = 5;
            this.btnNhapSach.Text = "NHẬP SÁCH";
            this.btnNhapSach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNhapSach.UseVisualStyleBackColor = false;
            // 
            // btnQuanLyMuonTra
            // 
            this.btnQuanLyMuonTra.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.btnQuanLyMuonTra.BackColor = System.Drawing.Color.White;
            this.btnQuanLyMuonTra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyMuonTra.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuanLyMuonTra.FlatAppearance.BorderSize = 2;
            this.btnQuanLyMuonTra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuanLyMuonTra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnQuanLyMuonTra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuanLyMuonTra.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyMuonTra.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLyMuonTra.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLyMuonTra.Image")));
            this.btnQuanLyMuonTra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuanLyMuonTra.Location = new System.Drawing.Point(3, 427);
            this.btnQuanLyMuonTra.Name = "btnQuanLyMuonTra";
            this.btnQuanLyMuonTra.Size = new System.Drawing.Size(213, 100);
            this.btnQuanLyMuonTra.TabIndex = 7;
            this.btnQuanLyMuonTra.Text = "QUẢN LÝ MƯỢN TRẢ";
            this.btnQuanLyMuonTra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuanLyMuonTra.UseVisualStyleBackColor = false;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.White;
            this.btnDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDong.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDong.FlatAppearance.BorderSize = 2;
            this.btnDong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.Black;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDong.Location = new System.Drawing.Point(3, 533);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(213, 100);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "ĐĂNG XUẤT";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnQuanLyDauSach
            // 
            this.btnQuanLyDauSach.BackColor = System.Drawing.Color.White;
            this.btnQuanLyDauSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyDauSach.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuanLyDauSach.FlatAppearance.BorderSize = 2;
            this.btnQuanLyDauSach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuanLyDauSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnQuanLyDauSach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuanLyDauSach.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDauSach.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLyDauSach.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLyDauSach.Image")));
            this.btnQuanLyDauSach.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuanLyDauSach.Location = new System.Drawing.Point(3, 3);
            this.btnQuanLyDauSach.Name = "btnQuanLyDauSach";
            this.btnQuanLyDauSach.Size = new System.Drawing.Size(213, 100);
            this.btnQuanLyDauSach.TabIndex = 3;
            this.btnQuanLyDauSach.Text = "QUẢN LÝ ĐẦU SÁCH";
            this.btnQuanLyDauSach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuanLyDauSach.UseVisualStyleBackColor = false;
            this.btnQuanLyDauSach.Click += new System.EventHandler(this.btnQlDauSach_Click);
            // 
            // btnQuanLyNhanViem
            // 
            this.btnQuanLyNhanViem.BackColor = System.Drawing.Color.White;
            this.btnQuanLyNhanViem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyNhanViem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuanLyNhanViem.FlatAppearance.BorderSize = 2;
            this.btnQuanLyNhanViem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuanLyNhanViem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnQuanLyNhanViem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuanLyNhanViem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNhanViem.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLyNhanViem.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLyNhanViem.Image")));
            this.btnQuanLyNhanViem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuanLyNhanViem.Location = new System.Drawing.Point(3, 109);
            this.btnQuanLyNhanViem.Name = "btnQuanLyNhanViem";
            this.btnQuanLyNhanViem.Size = new System.Drawing.Size(213, 100);
            this.btnQuanLyNhanViem.TabIndex = 2;
            this.btnQuanLyNhanViem.Text = "QUẢN LÝ NHÂN VIÊN";
            this.btnQuanLyNhanViem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuanLyNhanViem.UseVisualStyleBackColor = false;
            this.btnQuanLyNhanViem.Click += new System.EventHandler(this.btnQLNhanVien_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 701);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtTTNhanVien;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button btnQuanLyMuonTra;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnNhapSach;
        private System.Windows.Forms.Button btnQuanLyDauSach;
        private System.Windows.Forms.Button btnQuanLyNhanViem;
        private System.Windows.Forms.LinkLabel txtDoiMatKhau;
        private System.Windows.Forms.Button btnQuanLyDocGia;
    }
}

