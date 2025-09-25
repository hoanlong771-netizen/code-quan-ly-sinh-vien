# code-quan-ly-sinh-vien
using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCustom();
        }

        private void InitializeCustom()
        {
            // 2.1: Initialize ComboBox and defaults
            comboBoxKhoa.Items.AddRange(new string[] { "QTKD", "CNTT", "NNA" });
            comboBoxKhoa.SelectedIndex = 0; // Default: QTKD
            radioButtonNu.Checked = true;   // Default: Nữ
            UpdateGenderCount();
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            // 2.2: Validate required fields
            if (string.IsNullOrWhiteSpace(txtMSSV.Text) ||
                string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Validate Diem is a number
            if (!double.TryParse(txtDiem.Text, out double diem))
            {
                MessageBox.Show("Điểm trung bình không hợp lệ!");
                return;
            }

            // Check if MSSV exists
            var existingRow = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells["MSSV"].Value?.ToString() == txtMSSV.Text);

            if (existingRow == null)
            {
                // Add new
                dataGridView1.Rows.Add(
                    txtMSSV.Text,
                    txtTen.Text,
                    comboBoxKhoa.SelectedItem.ToString(),
                    radioButtonNam.Checked ? "Nam" : "Nữ",
                    diem.ToString("0.00")
                );
                MessageBox.Show("Thêm mới dữ liệu thành công!");
            }
            else
            {
                // Update existing
                existingRow.Cells["Ten"].Value = txtTen.Text;
                existingRow.Cells["Khoa"].Value = comboBoxKhoa.SelectedItem.ToString();
                existingRow.Cells["GioiTinh"].Value = radioButtonNam.Checked ? "Nam" : "Nữ";
                existingRow.Cells["Diem"].Value = diem.ToString("0.00");
                MessageBox.Show("Cập nhật dữ liệu thành công!");
            }
            UpdateGenderCount();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 2.3: Delete logic
            var rowToDelete = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells["MSSV"].Value?.ToString() == txtMSSV.Text);

            if (rowToDelete == null)
            {
                MessageBox.Show("Không tìm thấy MSSV cần xóa!");
                return;
            }

            var result = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                dataGridView1.Rows.Remove(rowToDelete);
                MessageBox.Show("Xóa sinh viên thành công!");
                UpdateGenderCount();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // 2.4: Reflect selected row to input fields
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                txtMSSV.Text = dataGridView1.CurrentRow.Cells["MSSV"].Value?.ToString();
                txtTen.Text = dataGridView1.CurrentRow.Cells["Ten"].Value?.ToString();
                comboBoxKhoa.SelectedItem = dataGridView1.CurrentRow.Cells["Khoa"].Value?.ToString();
                string gt = dataGridView1.CurrentRow.Cells["GioiTinh"].Value?.ToString();
                radioButtonNam.Checked = gt == "Nam";
                radioButtonNu.Checked = gt == "Nữ";
                txtDiem.Text = dataGridView1.CurrentRow.Cells["Diem"].Value?.ToString();
            }
        }

        private void UpdateGenderCount()
        {
            // 2.5: Update gender counts
            int nam = 0, nu = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string gt = row.Cells["GioiTinh"].Value?.ToString();
                if (gt == "Nam") nam++;
                else if (gt == "Nữ") nu++;
            }
            lblNam.Text = nam.ToString();
            lblNu.Text = nu.ToString();
        }
    }
}
