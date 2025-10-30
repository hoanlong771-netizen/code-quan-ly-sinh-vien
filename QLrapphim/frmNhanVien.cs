using System;
using System.Windows.Forms;
using BLL;

namespace QLrapphim.GUI
{
    public partial class FrmNhanVien : Form
    {
        NhanVienBLL nvBLL = new NhanVienBLL();

        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void LoadNhanVien()
        {
            dgvNhanVien.DataSource = nvBLL.LayTatCaNhanVien();
            dgvNhanVien.Columns["MaNV"].Visible = false;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // tránh click vào header
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                int maNV = Convert.ToInt32(row.Cells["MaNV"].Value);
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString();
                txtChucVu.Text = row.Cells["ChucVu"].Value?.ToString();
                txtCaLam.Text = row.Cells["CaLam"].Value?.ToString();
                txtLuong.Text = row.Cells["Luong"].Value?.ToString();
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtGioiTinh.Text) ||
                string.IsNullOrWhiteSpace(txtDienThoai.Text) ||
                string.IsNullOrWhiteSpace(txtChucVu.Text) ||
                string.IsNullOrWhiteSpace(txtCaLam.Text) ||
                string.IsNullOrWhiteSpace(txtLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!decimal.TryParse(txtLuong.Text, out decimal luong))
            {
                MessageBox.Show("Lương phải là số hợp lệ!");
                return;
            }

            if (nvBLL.ThemNV(txtHoTen.Text, txtEmail.Text, txtGioiTinh.Text, txtDienThoai.Text,
                txtChucVu.Text, txtCaLam.Text, luong))
            {
                MessageBox.Show("Thêm nhân viên thành công!");
                LoadNhanVien(); // tự động cập nhật DataGridView
                                // Xóa dữ liệu cũ để nhập nhân viên tiếp theo
                txtHoTen.Clear();
                txtEmail.Clear();
                txtGioiTinh.Clear();
                txtDienThoai.Clear();
                txtChucVu.Clear();
                txtCaLam.Clear();
                txtLuong.Clear();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null)
            {
                int maNV = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["MaNV"].Value);

                if (!decimal.TryParse(txtLuong.Text, out decimal luong))
                {
                    MessageBox.Show("Lương không hợp lệ!");
                    return;
                }

                if (nvBLL.SuaNV(maNV, txtHoTen.Text, txtEmail.Text, txtGioiTinh.Text, txtDienThoai.Text,
                    txtChucVu.Text, txtCaLam.Text, luong))
                {
                    LoadNhanVien();
                    MessageBox.Show("Sửa thành công!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null)
            {
                int maNV = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["MaNV"].Value);
                if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (nvBLL.XoaNV(maNV))
                    {
                        LoadNhanVien();
                        MessageBox.Show("Xóa thành công!");
                    }
                }
            }
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            LoadNhanVien(); // nạp lại tất cả nhân viên
            MessageBox.Show("Đã tải lại dữ liệu!");
        }

        private void dgvNhanVien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
