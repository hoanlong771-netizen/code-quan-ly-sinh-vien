// Auto-generated designer file — edited to match frmDatve.cs usage
using System;

namespace QLRapPhim.GUI
{
    partial class FrmDatVe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controls referenced from FrmDatVe.cs
        private System.Windows.Forms.Label lblTenPhim;
        private System.Windows.Forms.Label lblGiaVe;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// Matches controls used in FrmDatVe.cs
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.lblGiaVe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flpGhe = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numsolBapNuoc = new System.Windows.Forms.NumericUpDown();
            this.numSoLuongBap = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.numSoLuongNuoc = new System.Windows.Forms.NumericUpDown();
            this.chkThanhToanTienMat = new System.Windows.Forms.CheckBox();
            this.chkThanhToanDienTu = new System.Windows.Forms.CheckBox();
            this.cboBapNuoc = new System.Windows.Forms.ComboBox();
            this.cboBap = new System.Windows.Forms.ComboBox();
            this.cboNuoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numsolBapNuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongBap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongNuoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhim.Location = new System.Drawing.Point(24, 573);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(106, 25);
            this.lblTenPhim.TabIndex = 0;
            this.lblTenPhim.Text = "Tên phim";
            this.lblTenPhim.Click += new System.EventHandler(this.lblTenPhim_Click);
            // 
            // lblGiaVe
            // 
            this.lblGiaVe.AutoSize = true;
            this.lblGiaVe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaVe.Location = new System.Drawing.Point(24, 609);
            this.lblGiaVe.Name = "lblGiaVe";
            this.lblGiaVe.Size = new System.Drawing.Size(74, 25);
            this.lblGiaVe.TabIndex = 1;
            this.lblGiaVe.Text = "Giá vé";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Màn Hình Phim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flpGhe
            // 
            this.flpGhe.AutoScroll = true;
            this.flpGhe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpGhe.Location = new System.Drawing.Point(12, 106);
            this.flpGhe.Name = "flpGhe";
            this.flpGhe.Size = new System.Drawing.Size(806, 446);
            this.flpGhe.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Bắp :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "ComBo :";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(200, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 38);
            this.button2.TabIndex = 12;
            this.button2.Text = "Mua";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnMua_Click);
            // 
            // numsolBapNuoc
            // 
            this.numsolBapNuoc.Location = new System.Drawing.Point(286, 68);
            this.numsolBapNuoc.Name = "numsolBapNuoc";
            this.numsolBapNuoc.Size = new System.Drawing.Size(60, 22);
            this.numsolBapNuoc.TabIndex = 4;
            this.numsolBapNuoc.ValueChanged += new System.EventHandler(this.numberSoLuongBapNuoc_ValueChanged);
            // 
            // numSoLuongBap
            // 
            this.numSoLuongBap.Location = new System.Drawing.Point(286, 111);
            this.numSoLuongBap.Name = "numSoLuongBap";
            this.numSoLuongBap.Size = new System.Drawing.Size(60, 22);
            this.numSoLuongBap.TabIndex = 4;
            this.numSoLuongBap.ValueChanged += new System.EventHandler(this.numSoLuongBap_ValueChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(87, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 38);
            this.button3.TabIndex = 11;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // numSoLuongNuoc
            // 
            this.numSoLuongNuoc.Location = new System.Drawing.Point(286, 158);
            this.numSoLuongNuoc.Name = "numSoLuongNuoc";
            this.numSoLuongNuoc.Size = new System.Drawing.Size(60, 22);
            this.numSoLuongNuoc.TabIndex = 6;
            this.numSoLuongNuoc.ValueChanged += new System.EventHandler(this.numSoLuongNuoc_ValueChanged);
            // 
            // chkThanhToanTienMat
            // 
            this.chkThanhToanTienMat.AutoSize = true;
            this.chkThanhToanTienMat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThanhToanTienMat.Location = new System.Drawing.Point(24, 146);
            this.chkThanhToanTienMat.Name = "chkThanhToanTienMat";
            this.chkThanhToanTienMat.Size = new System.Drawing.Size(200, 26);
            this.chkThanhToanTienMat.TabIndex = 8;
            this.chkThanhToanTienMat.Text = "Thanh Toán Tiền Mặt";
            this.chkThanhToanTienMat.UseVisualStyleBackColor = true;
            this.chkThanhToanTienMat.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkThanhToanDienTu
            // 
            this.chkThanhToanDienTu.AutoSize = true;
            this.chkThanhToanDienTu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThanhToanDienTu.Location = new System.Drawing.Point(24, 192);
            this.chkThanhToanDienTu.Name = "chkThanhToanDienTu";
            this.chkThanhToanDienTu.Size = new System.Drawing.Size(195, 26);
            this.chkThanhToanDienTu.TabIndex = 9;
            this.chkThanhToanDienTu.Text = "Thanh Toán Điện Tử";
            this.chkThanhToanDienTu.UseVisualStyleBackColor = true;
            // 
            // cboBapNuoc
            // 
            this.cboBapNuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBapNuoc.FormattingEnabled = true;
            this.cboBapNuoc.Location = new System.Drawing.Point(112, 68);
            this.cboBapNuoc.Name = "cboBapNuoc";
            this.cboBapNuoc.Size = new System.Drawing.Size(150, 24);
            this.cboBapNuoc.TabIndex = 3;
            this.cboBapNuoc.SelectedIndexChanged += new System.EventHandler(this.cboBapNuoc_SelectedIndexChanged);
            // 
            // cboBap
            // 
            this.cboBap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBap.FormattingEnabled = true;
            this.cboBap.Location = new System.Drawing.Point(112, 111);
            this.cboBap.Name = "cboBap";
            this.cboBap.Size = new System.Drawing.Size(150, 24);
            this.cboBap.TabIndex = 3;
            this.cboBap.SelectedIndexChanged += new System.EventHandler(this.cboBap_SelectedIndexChanged);
            // 
            // cboNuoc
            // 
            this.cboNuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNuoc.FormattingEnabled = true;
            this.cboNuoc.Location = new System.Drawing.Point(112, 157);
            this.cboNuoc.Name = "cboNuoc";
            this.cboNuoc.Size = new System.Drawing.Size(150, 24);
            this.cboNuoc.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nước :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numSoLuongNuoc);
            this.panel1.Controls.Add(this.cboBapNuoc);
            this.panel1.Controls.Add(this.numSoLuongBap);
            this.panel1.Controls.Add(this.numsolBapNuoc);
            this.panel1.Controls.Add(this.cboNuoc);
            this.panel1.Controls.Add(this.cboBap);
            this.panel1.Location = new System.Drawing.Point(824, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 220);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(95, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 38);
            this.label6.TabIndex = 13;
            this.label6.Text = "THỨC ĂN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtTongTien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblTongTien);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.chkThanhToanTienMat);
            this.panel2.Controls.Add(this.chkThanhToanDienTu);
            this.panel2.Location = new System.Drawing.Point(824, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 332);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(123, 77);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(162, 27);
            this.txtTongTien.TabIndex = 14;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "THANH TOÁN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(20, 78);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(101, 22);
            this.lblTongTien.TabIndex = 13;
            this.lblTongTien.Text = "Tổng Tiền :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLrapphim.Properties.Resources.Cinema_24h_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1279, 696);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpGhe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGiaVe);
            this.Controls.Add(this.lblTenPhim);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDatVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đặt vé";
            this.Load += new System.EventHandler(this.FrmDatVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numsolBapNuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongBap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongNuoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void numberSoLuongBapNuoc_ValueChanged(object sender, EventArgs e)
        {
            CapNhatTongTien();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpGhe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numsolBapNuoc;
        private System.Windows.Forms.NumericUpDown numSoLuongBap;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numSoLuongNuoc;
        private System.Windows.Forms.CheckBox chkThanhToanTienMat;
        private System.Windows.Forms.CheckBox chkThanhToanDienTu;
        private System.Windows.Forms.ComboBox cboBapNuoc;
        private System.Windows.Forms.ComboBox cboBap;
        private System.Windows.Forms.ComboBox cboNuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}