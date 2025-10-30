using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace QLRapPhim.GUI
{
    public partial class FrmQRCode : Form
    {
        private string tenPhim;
        private string gheDaChon;
        private int tongTien;
        private string thucAn; // ✅ Thêm biến này để giữ thông tin thức ăn

        public FrmQRCode(string tenPhim, string gheDaChon, int tongTien, string thucAn)
        {
            InitializeComponent();
            this.tenPhim = tenPhim;
            this.gheDaChon = gheDaChon;
            this.tongTien = tongTien;
            this.thucAn = thucAn; // ✅ Gán giá trị
        }

        private async void FrmQRCode_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\Images\tải xuống.jpg";

            if (System.IO.File.Exists(path))
            {
                pictureBoxQRCode.Image = Image.FromFile(path);
            }
            else
            {
                MessageBox.Show("Không tìm thấy ảnh QR!");
            }

            // Giả lập chờ 5 giây để "đang quét QR"
            await Task.Delay(5000);

            // ✅ Gọi form Thanh Toán (thêm tham số thucAn)
            frmThanhToan frm = new frmThanhToan(tenPhim, gheDaChon, tongTien, "Thanh toán điện tử", thucAn);
            frm.ShowDialog();

            // Đóng form QR
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // ✅ Người dùng nhấn Xác nhận thủ công
            frmThanhToan frm = new frmThanhToan(tenPhim, gheDaChon, tongTien, "Điện tử", thucAn);
            frm.ShowDialog();
            this.Close();
        }

        private void pictureBoxQRCode_Click(object sender, EventArgs e)
        {

        }
    }
}
