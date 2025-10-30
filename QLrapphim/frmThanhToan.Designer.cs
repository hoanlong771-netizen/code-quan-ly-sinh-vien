namespace QLRapPhim.GUI
{
    partial class frmThanhToan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox rtbBill;
        private System.Windows.Forms.Button btnXacNhan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.rtbBill = new System.Windows.Forms.RichTextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbBill
            // 
            this.rtbBill.Location = new System.Drawing.Point(12, 12);
            this.rtbBill.Name = "rtbBill";
            this.rtbBill.ReadOnly = true;
            this.rtbBill.Size = new System.Drawing.Size(421, 229);
            this.rtbBill.TabIndex = 0;
            this.rtbBill.Text = "";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(173, 258);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(100, 35);
            this.btnXacNhan.TabIndex = 1;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // frmThanhToan
            // 
            this.ClientSize = new System.Drawing.Size(445, 305);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.rtbBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thanh Toán";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            this.ResumeLayout(false);

        }
    }
}
