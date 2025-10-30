using System;
using System.Data;
using System.Windows.Forms;
using BLL; 

namespace QLRapPhim.GUI
{
    public partial class frmDoanhThu : Form
    {
        DoanhThuBLL doanhThuBLL = new DoanhThuBLL();

        public frmDoanhThu()
        {
            InitializeComponent();
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            HienThiDoanhThu();
        }

        private void HienThiDoanhThu()
        {
            DataTable dt = doanhThuBLL.LayTatCaDoanhThu();
            dataGridView1.DataSource = dt;

            // Cập nhật biểu đồ
            chart1.Series["Series1"].Points.Clear();
            foreach (DataRow row in dt.Rows)
            {
                chart1.Series["Series1"].Points.AddXY(
                    Convert.ToDateTime(row["Ngay"]).ToString("MM-dd"),
                    Convert.ToDouble(row["TongDoanhThu"]));
            }
        }
            private void chart1_Click(object sender, EventArgs e)
        {
            // Chưa làm gì, chỉ để tránh lỗi
        }

    }
}