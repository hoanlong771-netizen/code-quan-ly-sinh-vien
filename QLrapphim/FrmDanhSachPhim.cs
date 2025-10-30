using QLrapphim.GUI;
using QLRapPhim.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLrapphim
{
    public partial class FrmDanhSachPhim : Form
    {
        public FrmDanhSachPhim()
        {
            InitializeComponent();
            LoadPhim();

        }

        private void LoadPhim()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS03;Initial Catalog=QLRapphim;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaPhim, TenPhim, TheLoai, ThoiGianChieu, GiaVe, Poster FROM Phim", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPhim.DataSource = dt;
                conn.Close();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoaPhim_Click(object sender, EventArgs e)
        {
            if (dgvPhim.CurrentRow == null) return;

            int maPhim = Convert.ToInt32(dgvPhim.CurrentRow.Cells["MaPhim"].Value);
            string tenPhim = dgvPhim.CurrentRow.Cells["TenPhim"].Value.ToString();

            DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa phim '{tenPhim}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS03;Initial Catalog=QLRapphim;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Phim WHERE MaPhim=@id", conn);
                cmd.Parameters.AddWithValue("@id", maPhim);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            LoadPhim();
            MessageBox.Show($"Đã xóa phim '{tenPhim}'!");
        }


        private void btnChonPhim_Click(object sender, EventArgs e)
        {
            if (dgvPhim.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một phim trước!");
                return;
            }

            // Lấy dữ liệu từ DataGridView
            string tenPhim = dgvPhim.CurrentRow.Cells["TenPhim"].Value.ToString();
            string giaVeText = dgvPhim.CurrentRow.Cells["GiaVe"].Value.ToString();

            // Chuyển giá vé sang số, bỏ chữ "VND" nếu có
            giaVeText = giaVeText.Replace(" VND", "").Trim();
            if (!int.TryParse(giaVeText, out int giaVe))
            {
                MessageBox.Show("Giá vé không hợp lệ!");
                return;
            }

            // Mở FrmDatVe
            FrmDatVe frmDatVe = new FrmDatVe(tenPhim, giaVe.ToString());
            frmDatVe.ShowDialog();
        }

        private void btnThemPhim_Click(object sender, EventArgs e)
        {
            string tenPhim = txtTenPhim.Text.Trim();
            if (string.IsNullOrEmpty(tenPhim))
            {
                MessageBox.Show("Vui lòng nhập tên phim!");
                return;
            }

            string theLoai = "Hành động"; // Hoặc lấy từ combobox
            int giaVe = 80000;
            int thoiLuong = 120; // ví dụ

            using (SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS03;Initial Catalog=QLRapphim;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Phim WHERE TenPhim=@ten", conn);
                checkCmd.Parameters.AddWithValue("@ten", tenPhim);
                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Phim này đã tồn tại!");
                    return;
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Phim(TenPhim, TheLoai, ThoiGianChieu, GiaVe) VALUES(@ten, @tl, @tg, @gia)", conn);
                cmd.Parameters.AddWithValue("@ten", tenPhim);
                cmd.Parameters.AddWithValue("@tl", theLoai);
                cmd.Parameters.AddWithValue("@tg", thoiLuong);
                cmd.Parameters.AddWithValue("@gia", giaVe);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            txtTenPhim.Clear();
            LoadPhim();
            MessageBox.Show("Thêm phim thành công!");
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien frmNV = new FrmNhanVien(); // form thật
            frmNV.ShowDialog();
        }


        private void dgvPhim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvPhim.Rows[e.RowIndex];
            txtTenPhim.Text = row.Cells["TenPhim"].Value.ToString();
            txtGiaVe.Text = row.Cells["GiaVe"].Value.ToString() + " VND";
            txtTheLoai.Text = row.Cells["TheLoai"].Value.ToString();
            txtThoiGian.Text = row.Cells["ThoiGianChieu"].Value.ToString() + " phút";
            // --- Hiển thị ảnh Poster ---
            try
            {
                string posterPath = row.Cells["Poster"].Value.ToString();
                string fullPath = System.IO.Path.Combine(Application.StartupPath, posterPath);

                if (System.IO.File.Exists(fullPath))
                {
                    picPoster.Image = Image.FromFile(fullPath);
                }
                else
                {
                    picPoster.Image = null;
                    MessageBox.Show("Không tìm thấy ảnh: " + fullPath);
                }
            }
            catch
            {
                picPoster.Image = null;
            }
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            frmDoanhThu frmDT = new frmDoanhThu();
            frmDT.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblTheLoai_Click(object sender, EventArgs e)
        {

        }

        private void FrmDanhSachPhim_Load(object sender, EventArgs e)
        {

        }

        private void picPoster_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
