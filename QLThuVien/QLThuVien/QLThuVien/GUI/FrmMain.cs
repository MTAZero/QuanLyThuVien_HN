using QLThuVien.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien.GUI
{
    public partial class FrmMain : Form
    {
        private QLThuVienDbContext db = Service.DBService.db;
        private NHANVIEN nv = new NHANVIEN();

        #region constructor
        public FrmMain(NHANVIEN _nv)
        {
            InitializeComponent();
            Service.DBService.Reload();
            nv = _nv;
        }
        #endregion

        #region LoadForm

        private void LoadPhanQuyen()
        {
            if (nv.QUYEN == 1)
            {
                // phan quyen admin
                btnQuanLyNhanViem.Enabled = true;
                btnQuanLyDauSach.Enabled = true;
                btnQuanLyDocGia.Enabled = true;
                btnQuanLyMuonTra.Enabled = true;
                btnNhapSach.Enabled = true;
                
                return;
            }

            if (nv.QUYEN == 0)
            {
                // phan quyen nhan vien
                btnQuanLyNhanViem.Enabled = false;
                btnQuanLyDauSach.Enabled = false;
                btnQuanLyDocGia.Enabled = false;
                btnQuanLyMuonTra.Enabled = true;
                btnNhapSach.Enabled = true;
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadPhanQuyen();
            txtTTNhanVien.Text = nv.TEN + " - " + ((nv.QUYEN == 0) ? "Nhân viên" : "Quản trị");
        }
        #endregion

        #region sự kiện
        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            FrmQuanLyNhanVien form = new FrmQuanLyNhanVien();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(form);
            form.Show();
        }


        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn đăng xuất không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.Cancel) return;

            this.Close();
        }


        private void txtDoiMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDoiMatKhau form = new FrmDoiMatKhau(nv);
            form.ShowDialog();
        }
        #endregion

        private void btnQlDauSach_Click(object sender, EventArgs e)
        {
            FrmQuanLyDauSach form = new FrmQuanLyDauSach();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(form);
            form.Show();
        }
    }
}
