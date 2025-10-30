using QLrapphim;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QLRapPhim.GUI
{
    public partial class FrmPoster : Form
    {
        public FrmPoster()
        {
            InitializeComponent();
            LoadPosters();
        }

        private void LoadPosters()
        {
            // Tên file ảnh theo thứ tự bạn muốn hiển thị
            string[] fileNames = {
                "Avengers_Endgame_bia_teaser.jpg",
                "Fast_X_VN_poster.jpg",
                "Frozen2phim.jpg",
                "images.jpg",
                "images1.jpg",
                "images2.jpg",
                "images3.jpg",
                "Joker_(phim_2019).jpq.jpg"
            };

            // Array chứa PictureBox đã kéo thả
            PictureBox[] posters = { pbPoster1, pbPoster2, pbPoster3, pbPoster4,
                                     pbPoster5, pbPoster6, pbPoster7, pbPoster8 };

            // Đường dẫn folder chứa ảnh
            string folderPath = Path.Combine(Application.StartupPath, "Images");

            for (int i = 0; i < posters.Length; i++)
            {
                string filePath = Path.Combine(folderPath, fileNames[i]);
                if (File.Exists(filePath))
                {
                    posters[i].Image = Image.FromFile(filePath);
                    posters[i].SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    posters[i].BackColor = Color.Gray; // nếu file không tồn tại
                }
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDN = new frmDangNhap();
            frmDN.ShowDialog();
        }

        private void pbPoster5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPoster_Load(object sender, EventArgs e)
        {

        }
    }
}
