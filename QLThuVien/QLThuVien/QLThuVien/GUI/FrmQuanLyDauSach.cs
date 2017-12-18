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
    public partial class FrmQuanLyDauSach : Form
    {
        private QLThuVienDbContext db = Service.DBService.db;
        private int index = 0, index1 = 0;

        #region constructor
        public FrmQuanLyDauSach()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm

        private void LoadControl()
        {
            groupThongTin.Enabled = false;
        }

        private void LoadDgvNhanVien()
        {
            int i = 0;
            string keyword = txtTimKiem.Text;
            var dbNV = db.SACHes.ToList()
                       .Select(p => new
                       {
                           ID = p.ID,
                           STT = ++i,
                           TenSach = p.TEN,
                           TacGia = p.TACGIA,
                           NXB = p.NHAXUATBAN,
                           SoLuong = p.SOLUONG
                       })
                       .ToList();

            dgvSACH.DataSource = dbNV
                                    .Where(p => p.TenSach.Contains(keyword) || p.TacGia.Contains(keyword) || p.NXB.Contains(keyword))
                                    .ToList();

            // cập nhật index 
            index = index1;
            try
            {
                dgvSACH.Rows[index].Cells["STT"].Selected = true;
                dgvSACH.Select();
            }
            catch { }
        }


        private void FrmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadControl();
            LoadDgvNhanVien();
        }
        #endregion

        #region Hàm chức năng

        private void ClearControl()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtNXB.Text = "";
            txtSoLuong.Text = "0";
        }

        private void UpdateDetail()
        {
            ClearControl();
            try
            {
                SACH tg = getSACHByID();

                if (tg == null || tg.ID == 0) return;

                // cập nhật trên giao diện
                txtMaSach.Text = tg.MASACH;
                txtTenSach.Text = tg.TEN;
                txtTacGia.Text = tg.TACGIA;
                txtNXB.Text = tg.NHAXUATBAN;
                txtSoLuong.Text = tg.SOLUONG.ToString();

                index1 = index;
                index = dgvSACH.SelectedRows[0].Index;
            }
            catch { }

        }

        private SACH getSACHByID()
        {
            try
            {
                int id = (int)dgvSACH.SelectedRows[0].Cells["ID"].Value;
                SACH nhanvien = db.SACHes.Where(p => p.ID == id).FirstOrDefault();
                return (nhanvien != null) ? nhanvien : new SACH();
            }
            catch
            {
                return new SACH();
            }
        }

        private SACH getSACHByForm()
        {
            SACH ans = new SACH();
            ans.MASACH = txtMaSach.Text;
            ans.TEN = txtTenSach.Text;
            ans.TACGIA = txtTacGia.Text;
            ans.NHAXUATBAN = txtNXB.Text;
            ans.SOLUONG = Int32.Parse(txtSoLuong.Text);

            return ans;
        }

        private bool Check()
        {
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Mã sách không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int cnt = db.SACHes.Where(p => p.MASACH == txtMaSach.Text).ToList().Count;
            if (cnt > 0)
            {
                bool ok = false;
                if (btnSua.Text == "Lưu")
                {
                    // Nếu là sửa
                    SACH tg = getSACHByID();
                    if (tg.MASACH == txtMaSach.Text) ok = true;
                }

                if (!ok)
                {
                    MessageBox.Show("Mã sách đã được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }


            if (txtTenSach.Text == "")
            {
                MessageBox.Show("Tên sách không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (txtTacGia.Text == "")
            {
                MessageBox.Show("Đơn vị tính không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {

            }
            catch
            {
                MessageBox.Show("Số lượng phải là số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        #endregion

        #region sự kiện ngầm
        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            UpdateDetail();
        }
        #endregion

        #region sự kiện
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDgvNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {

                btnThem.Text = "Lưu";
                btnSua.Enabled = false;
                btnXoa.Text = "Hủy";

                groupThongTin.Enabled = true;
                dgvSACH.Enabled = false;

                btnTimKiem.Enabled = false;
                txtTimKiem.Enabled = false;

                ClearControl();

                return;
            }

            if (btnThem.Text == "Lưu")
            {
                if (Check())
                {

                    btnThem.Text = "Thêm";
                    btnSua.Enabled = true;
                    btnXoa.Text = "Xóa";

                    groupThongTin.Enabled = false;
                    dgvSACH.Enabled = true;

                    btnTimKiem.Enabled = true;
                    txtTimKiem.Enabled = true;

                    try
                    {
                        SACH tg = getSACHByForm();
                        db.SACHes.Add(tg);
                        db.SaveChanges();
                        MessageBox.Show("Thêm thông tin sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin sách thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    LoadDgvNhanVien();
                }

                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SACH tg = getSACHByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có sách nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu";
                btnThem.Enabled = false;
                btnXoa.Text = "Hủy";

                groupThongTin.Enabled = true;
                dgvSACH.Enabled = false;

                btnTimKiem.Enabled = false;
                txtTimKiem.Enabled = false;
                return;
            }

            if (btnSua.Text == "Lưu")
            {
                if (Check())
                {
                    btnSua.Text = "Sửa";
                    btnThem.Enabled = true;
                    btnXoa.Text = "Xóa";

                    groupThongTin.Enabled = false;
                    dgvSACH.Enabled = true;

                    btnTimKiem.Enabled = true;
                    txtTimKiem.Enabled = true;

                    SACH tgs = getSACHByForm();

                    tg.MASACH = tgs.MASACH;
                    tg.TEN = tgs.TEN;
                    tg.TACGIA = tgs.TACGIA;
                    tg.NHAXUATBAN = tgs.NHAXUATBAN;

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sửa thông tin sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin sách thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                    LoadDgvNhanVien();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                SACH tg = getSACHByID();
                if (tg.ID == 0)
                {
                    MessageBox.Show("Chưa có sách nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa thông tin sách này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;

                try
                {
                    db.SACHes.Remove(tg);
                    db.SaveChanges();
                    MessageBox.Show("Xóa sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Xóa sách thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadDgvNhanVien();

                return;
            }

            if (btnXoa.Text == "Hủy")
            {
                btnXoa.Text = "Xóa";
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";

                btnThem.Enabled = true;
                btnSua.Enabled = true;

                groupThongTin.Enabled = false;
                dgvSACH.Enabled = true;

                btnTimKiem.Enabled = true;
                txtTimKiem.Enabled = true;

                UpdateDetail();

                return;
            }
        }
        #endregion
    }
}
