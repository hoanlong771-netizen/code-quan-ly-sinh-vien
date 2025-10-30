using System;
using System.Windows.Forms;

namespace QLRapPhim.GUI
{
    public partial class frmThanhToan : Form
    {
        private string tenPhim, ghe, hinhThuc;
        private int tongTien;
        private string thucAn;

        public frmThanhToan(string tenPhim, string ghe, int tongTien, string hinhThuc, string thucAn)
        {
            InitializeComponent();
            this.tenPhim = tenPhim;
            this.ghe = ghe;
            this.thucAn = thucAn;
            this.tongTien = tongTien;
            this.hinhThuc = hinhThuc;

            HienThiBill();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {

        }

        private void HienThiBill()
        {
            rtbBill.Text =
                $"🎬 Phim: {tenPhim}\n" +
                $"💺 Ghế: {ghe}\n" +
                $"🍿 Thức ăn: {thucAn}\n" +
                $"💰 Tổng tiền: {tongTien:N0} VND\n" +
                $"🧾 Hình thức: {hinhThuc}\n\n" +
                $"Cảm ơn bạn đã mua vé tại Rạp phim!";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công! Chúc bạn xem phim vui vẻ 🍿");
            this.Close();
        }
    }
}
