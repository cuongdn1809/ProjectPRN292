
namespace ProjectPRN292
{
    partial class frmTrangChu
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
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnXuatKho = new System.Windows.Forms.Button();
            this.btnNhapKho = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTimkiem = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnExitt = new System.Windows.Forms.Button();
            this.dgvHome = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHome)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHoaDon.Location = new System.Drawing.Point(440, 23);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(100, 28);
            this.btnHoaDon.TabIndex = 13;
            this.btnHoaDon.Text = "Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnXuatKho
            // 
            this.btnXuatKho.Location = new System.Drawing.Point(116, 23);
            this.btnXuatKho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXuatKho.Name = "btnXuatKho";
            this.btnXuatKho.Size = new System.Drawing.Size(100, 28);
            this.btnXuatKho.TabIndex = 12;
            this.btnXuatKho.Text = "Xuất Kho";
            this.btnXuatKho.UseVisualStyleBackColor = true;
            this.btnXuatKho.Click += new System.EventHandler(this.btnXuatKho_Click);
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNhapKho.Location = new System.Drawing.Point(8, 23);
            this.btnNhapKho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(100, 28);
            this.btnNhapKho.TabIndex = 11;
            this.btnNhapKho.Text = "Nhập Kho";
            this.btnNhapKho.UseVisualStyleBackColor = false;
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Location = new System.Drawing.Point(224, 23);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(100, 28);
            this.btnKhachHang.TabIndex = 10;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quản Lý Kho Hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbTimkiem
            // 
            this.cbTimkiem.Items.AddRange(new object[] {
            "Tên khách hàng",
            "Tên Sản Phẩm",
            "Tên Thương Hiệu"});
            this.cbTimkiem.Location = new System.Drawing.Point(8, 26);
            this.cbTimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTimkiem.Name = "cbTimkiem";
            this.cbTimkiem.Size = new System.Drawing.Size(144, 24);
            this.cbTimkiem.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtTim);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbTimkiem);
            this.groupBox1.Location = new System.Drawing.Point(28, 503);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(384, 71);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Kho Theo";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(161, 26);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(119, 22);
            this.txtTim.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnSanPham);
            this.groupBox2.Controls.Add(this.btnExitt);
            this.groupBox2.Controls.Add(this.btnHoaDon);
            this.groupBox2.Controls.Add(this.btnNhapKho);
            this.groupBox2.Controls.Add(this.btnKhachHang);
            this.groupBox2.Controls.Add(this.btnXuatKho);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(412, 503);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(660, 71);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // btnSanPham
            // 
            this.btnSanPham.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSanPham.Location = new System.Drawing.Point(332, 23);
            this.btnSanPham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(100, 28);
            this.btnSanPham.TabIndex = 15;
            this.btnSanPham.Text = "Sản Phẩm";
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnExitt
            // 
            this.btnExitt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExitt.Location = new System.Drawing.Point(548, 23);
            this.btnExitt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExitt.Name = "btnExitt";
            this.btnExitt.Size = new System.Drawing.Size(100, 28);
            this.btnExitt.TabIndex = 14;
            this.btnExitt.Text = "Thoát";
            this.btnExitt.UseVisualStyleBackColor = true;
            this.btnExitt.Click += new System.EventHandler(this.btnExitt_Click);
            // 
            // dgvHome
            // 
            this.dgvHome.AllowUserToAddRows = false;
            this.dgvHome.AllowUserToDeleteRows = false;
            this.dgvHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHome.Location = new System.Drawing.Point(28, 73);
            this.dgvHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHome.Name = "dgvHome";
            this.dgvHome.RowHeadersWidth = 51;
            this.dgvHome.Size = new System.Drawing.Size(1044, 423);
            this.dgvHome.TabIndex = 20;
            this.dgvHome.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHome_CellClick);
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnHoaDon;
            this.ClientSize = new System.Drawing.Size(1084, 596);
            this.Controls.Add(this.dgvHome);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnXuatKho;
        private System.Windows.Forms.Button btnNhapKho;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTimkiem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.DataGridView dgvHome;
        private System.Windows.Forms.Button btnExitt;
        private System.Windows.Forms.Button btnSanPham;
    }
}