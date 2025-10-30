using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace QLrapphim
{
    public partial class frmDangNhap : Form
    {
        TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        public frmDangNhap()
        {
            InitializeComponent();
            txtTaiKhoan.Text = "Username";
            txtTaiKhoan.ForeColor = Color.Gray;

            // Placeholder cho mật khẩu
            txtMatKhau.Text = "Password";
            txtMatKhau.ForeColor = Color.Gray;
            txtMatKhau.UseSystemPasswordChar = false; // hiện chữ mờ
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDN = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;

            if (tkBLL.KiemTraDangNhap(tenDN, matKhau))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");

                FrmDanhSachPhim frmPhim = new FrmDanhSachPhim();
                this.Hide();
                frmPhim.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi");
            }
        }

        // txtTaiKhoan
        private void txtTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "Username")
            {
                txtTaiKhoan.Text = "";
                txtTaiKhoan.ForeColor = Color.Black;
            }
        }

        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text))
            {
                txtTaiKhoan.Text = "Username";
                txtTaiKhoan.ForeColor = Color.Gray;
            }
        }

        // txtMatKhau
        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Pass")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
                txtMatKhau.UseSystemPasswordChar = true; // ẩn mật khẩu
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                txtMatKhau.Text = "Pass";
                txtMatKhau.ForeColor = Color.Gray;
                txtMatKhau.UseSystemPasswordChar = false; // hiện placeholder
                chkHienMatKhau.Checked = false; // reset checkbox khi placeholder hiện
            }
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text != "Pass")
            {
                txtMatKhau.UseSystemPasswordChar = !chkHienMatKhau.Checked;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
