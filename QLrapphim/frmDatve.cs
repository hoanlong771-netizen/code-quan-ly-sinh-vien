using QLrapphim;
using QLRapPhim;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BLL;

namespace QLRapPhim.GUI
{
    public partial class FrmDatVe : Form
    {
        string tenPhim;
        int giaVe;

        List<Button> gheDaChon = new List<Button>();

        public FrmDatVe(string tenPhim, string giaVe)
        {
            InitializeComponent();
            this.tenPhim = tenPhim;
            this.giaVe = int.Parse(giaVe);
        }

        private void FrmDatVe_Load(object sender, EventArgs e)
        {
            lblTenPhim.Text = tenPhim;
            lblGiaVe.Text = giaVe + " VND";

            // tạo 50 ghế
            TaoGhe(54);


            // 🟢 Load combo, bắp, nước tách riêng
            BapNuocBLL bnBLL = new BapNuocBLL();

            // Combo
            cboBapNuoc.DataSource = bnBLL.LayCombo();
            cboBapNuoc.DisplayMember = "TenBN";
            cboBapNuoc.ValueMember = "GiaBN";
            cboBapNuoc.SelectedIndex = -1;

            // Bắp
            cboBap.DataSource = bnBLL.LayBap();
            cboBap.DisplayMember = "TenBN";
            cboBap.ValueMember = "GiaBN";
            cboBap.SelectedIndex = -1;
            // Nước
            cboNuoc.DataSource = bnBLL.LayNuoc();
            cboNuoc.DisplayMember = "TenBN";
            cboNuoc.ValueMember = "GiaBN";
            cboNuoc.SelectedIndex = -1;

            numSoLuongBap.Value = 0;
            numSoLuongNuoc.Value = 0;

            // Tổng tiền lúc đầu = 0
            txtTongTien.Text = "0 VND";
        }
        private void TaoGhe(int soGhe)
        {
            flpGhe.Controls.Clear();

            int padding = 5; // khoảng cách giữa các ghế
            int panelWidth = flpGhe.ClientSize.Width;

            int ghePerRow = 10; // số ghế mỗi hàng, có thể thay đổi theo panel
            int gheWidth = (panelWidth - (ghePerRow + 1) * padding) / ghePerRow;

            for (int i = 1; i <= soGhe; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.Width = gheWidth;
                btn.Height = gheWidth; // giữ vuông
                btn.Margin = new Padding(padding);
                btn.BackColor = Color.White;
                btn.Click += BtnGhe_Click;
                flpGhe.Controls.Add(btn);
            }
        }

        private void BtnGhe_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.LightGreen;
                gheDaChon.Add(btn);
            }
            else
            {
                btn.BackColor = Color.White;
                gheDaChon.Remove(btn);
            }
            CapNhatTongTien();
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            // Kiểm tra có chọn ghế chưa
            if (gheDaChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ghế!");
                return;
            }

            // Lấy thông tin cơ bản
            string tenPhim = lblTenPhim.Text;
            string danhSachGhe = string.Join(", ", gheDaChon.ConvertAll(g => g.Text));
            string tongTienText = txtTongTien.Text.Replace(".", "").Replace(" VND", "").Trim();

            if (!int.TryParse(tongTienText, out int tongTien))
            {
                MessageBox.Show("Tổng tiền không hợp lệ!");
                return;
            }

            // Kiểm tra hình thức thanh toán
            if (chkThanhToanTienMat.Checked && chkThanhToanDienTu.Checked)
            {
                MessageBox.Show("Vui lòng chỉ chọn 1 hình thức thanh toán!");
                return;
            }

            if (!chkThanhToanTienMat.Checked && !chkThanhToanDienTu.Checked)
            {
                MessageBox.Show("Vui lòng chọn hình thức thanh toán!");
                return;
            }

            // 🔸 Gộp phần thức ăn (bắp, nước, combo)
            // 🔸 Gộp phần thức ăn (bắp, nước, combo)
            string thucAn = "";
            bool coThucAn = false;

            if (cboBapNuoc.SelectedItem != null)
            {
                DataRowView combo = (DataRowView)cboBapNuoc.SelectedItem;
                thucAn += $"- Combo: {combo["TenBN"]}\n";
                coThucAn = true;
            }

            if (numSoLuongBap.Value > 0 && cboBap.SelectedItem != null)
            {
                DataRowView bap = (DataRowView)cboBap.SelectedItem;
                thucAn += $"- Bắp: {bap["TenBN"]} x{numSoLuongBap.Value}\n";
                coThucAn = true;
            }

            if (numSoLuongNuoc.Value > 0 && cboNuoc.SelectedItem != null)
            {
                DataRowView nuoc = (DataRowView)cboNuoc.SelectedItem;
                thucAn += $"- Nước: {nuoc["TenBN"]} x{numSoLuongNuoc.Value}\n";
                coThucAn = true;
            }

            if (!coThucAn)
                thucAn = "Không chọn";


            // Xác định hình thức thanh toán
            string hinhThuc = chkThanhToanTienMat.Checked ? "Tiền mặt" : "Điện tử";

            // ===== TIỀN MẶT =====
            if (chkThanhToanTienMat.Checked)
            {
                frmThanhToan frm = new frmThanhToan(tenPhim, danhSachGhe, tongTien, hinhThuc, thucAn);
                frm.ShowDialog();
            }
            // ===== THANH TOÁN ĐIỆN TỬ =====
            else if (chkThanhToanDienTu.Checked)
            {
                FrmQRCode qr = new FrmQRCode(tenPhim, danhSachGhe, tongTien, thucAn);
                qr.ShowDialog();
            }

            // 🔁 Reset sau khi thanh toán
            foreach (var ghe in gheDaChon)
                ghe.BackColor = Color.White;

            gheDaChon.Clear();
            numSoLuongBap.Value = 0;
            numSoLuongNuoc.Value = 0;
            cboBap.SelectedIndex = -1;
            cboNuoc.SelectedIndex = -1;
            cboBapNuoc.SelectedIndex = -1;
            txtTongTien.Text = "0 VND";
        }




        private void CapNhatTongTien()
        {
            int tienVe = gheDaChon.Count * giaVe;
            int giaBap = 0;
            int giaNuoc = 0;
            int giaCombo = 0;

            // Bắp
            if (cboBap.SelectedItem != null)
            {
                DataRowView drvBap = (DataRowView)cboBap.SelectedItem;
                giaBap = Convert.ToInt32(drvBap["GiaBN"]) * (int)numSoLuongBap.Value;
            }

            // Nước
            if (cboNuoc.SelectedItem != null)
            {
                DataRowView drvNuoc = (DataRowView)cboNuoc.SelectedItem;
                giaNuoc = Convert.ToInt32(drvNuoc["GiaBN"]) * (int)numSoLuongNuoc.Value;
            }

            // Combo
            if (cboBapNuoc.SelectedItem != null)
            {
                DataRowView drvCombo = (DataRowView)cboBapNuoc.SelectedItem;
                giaCombo = Convert.ToInt32(drvCombo["GiaBN"]);
            }

            int tongTien = tienVe + giaBap + giaNuoc + giaCombo;
            txtTongTien.Text = tongTien.ToString("N0") + " VND";
        }



        private void cboBap_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatTongTien();
        }

        private void lblTenPhim_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void numSoLuongBapNuoc_ValueChanged(object sender, EventArgs e)
        {
            CapNhatTongTien();
        }

        private void numSoLuongBap_ValueChanged(object sender, EventArgs e)
        {
            CapNhatTongTien();
        }

        private void numSoLuongNuoc_ValueChanged(object sender, EventArgs e)
        {
            CapNhatTongTien();
        }

        private void cboBapNuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatTongTien();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
