
namespace ProjectPRN292
{
    partial class frmNhapHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cbSanPham = new System.Windows.Forms.ComboBox();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtGiaSP = new System.Windows.Forms.TextBox();
            this.txtGiaThue = new System.Windows.Forms.TextBox();
            this.txtThuongHieu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 31);
            this.label5.TabIndex = 56;
            this.label5.Text = " Nhập Kho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 72;
            this.label6.Text = "Giá thuê";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Enabled = false;
            this.dtpNgayNhap.Location = new System.Drawing.Point(227, 130);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(280, 22);
            this.dtpNgayNhap.TabIndex = 71;
            // 
            // cbSanPham
            // 
            this.cbSanPham.FormattingEnabled = true;
            this.cbSanPham.Location = new System.Drawing.Point(227, 182);
            this.cbSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSanPham.Name = "cbSanPham";
            this.cbSanPham.Size = new System.Drawing.Size(280, 24);
            this.cbSanPham.TabIndex = 68;
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Location = new System.Drawing.Point(227, 84);
            this.cbKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(280, 24);
            this.cbKhachHang.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "Giá sản phẩm";
            // 
            // nSoLuong
            // 
            this.nSoLuong.Location = new System.Drawing.Point(227, 327);
            this.nSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nSoLuong.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nSoLuong.Name = "nSoLuong";
            this.nSoLuong.Size = new System.Drawing.Size(280, 22);
            this.nSoLuong.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 185);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 64;
            this.label9.Text = "Tên Sản Phẩm";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(227, 418);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(280, 62);
            this.txtNote.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 329);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 62;
            this.label7.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 421);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "Ghi chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Tên Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Ngày Nhập";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(302, 502);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 58;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(122, 502);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // txtGiaSP
            // 
            this.txtGiaSP.Location = new System.Drawing.Point(227, 280);
            this.txtGiaSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaSP.Name = "txtGiaSP";
            this.txtGiaSP.Size = new System.Drawing.Size(280, 22);
            this.txtGiaSP.TabIndex = 73;
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.Location = new System.Drawing.Point(227, 374);
            this.txtGiaThue.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Size = new System.Drawing.Size(280, 22);
            this.txtGiaThue.TabIndex = 74;
            this.txtGiaThue.WordWrap = false;
            // 
            // txtThuongHieu
            // 
            this.txtThuongHieu.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtThuongHieu.Location = new System.Drawing.Point(227, 231);
            this.txtThuongHieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThuongHieu.Name = "txtThuongHieu";
            this.txtThuongHieu.Size = new System.Drawing.Size(280, 22);
            this.txtThuongHieu.TabIndex = 97;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 234);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 96;
            this.label8.Text = "Thương Hiệu";
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 552);
            this.Controls.Add(this.txtThuongHieu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGiaThue);
            this.Controls.Add(this.txtGiaSP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.cbSanPham);
            this.Controls.Add(this.cbKhachHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nSoLuong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Kho";
            ((System.ComponentModel.ISupportInitialize)(this.nSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.ComboBox cbSanPham;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nSoLuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtGiaSP;
        private System.Windows.Forms.TextBox txtGiaThue;
        private System.Windows.Forms.TextBox txtThuongHieu;
        private System.Windows.Forms.Label label8;
    }
}