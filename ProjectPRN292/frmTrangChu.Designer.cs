
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
            this.btnHoaDon.Location = new System.Drawing.Point(253, 19);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(75, 23);
            this.btnHoaDon.TabIndex = 13;
            this.btnHoaDon.Text = "Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnXuatKho
            // 
            this.btnXuatKho.Location = new System.Drawing.Point(87, 19);
            this.btnXuatKho.Name = "btnXuatKho";
            this.btnXuatKho.Size = new System.Drawing.Size(75, 23);
            this.btnXuatKho.TabIndex = 12;
            this.btnXuatKho.Text = "Xuất Kho";
            this.btnXuatKho.UseVisualStyleBackColor = true;
            this.btnXuatKho.Click += new System.EventHandler(this.btnXuatKho_Click);
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNhapKho.Location = new System.Drawing.Point(6, 19);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(75, 23);
            this.btnNhapKho.TabIndex = 11;
            this.btnNhapKho.Text = "Nhập Kho";
            this.btnNhapKho.UseVisualStyleBackColor = false;
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Location = new System.Drawing.Point(172, 19);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(75, 23);
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
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Phần Mềm Quản Lý Kho";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbTimkiem
            // 
            this.cbTimkiem.Items.AddRange(new object[] {
            "Tên khách hàng",
            "Tên Sản Phẩm"});
            this.cbTimkiem.Location = new System.Drawing.Point(6, 21);
            this.cbTimkiem.Name = "cbTimkiem";
            this.cbTimkiem.Size = new System.Drawing.Size(109, 21);
            this.cbTimkiem.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
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
            this.groupBox1.Location = new System.Drawing.Point(21, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 58);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Kho Theo";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(121, 21);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(90, 20);
            this.txtTim.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnExitt);
            this.groupBox2.Controls.Add(this.btnHoaDon);
            this.groupBox2.Controls.Add(this.btnNhapKho);
            this.groupBox2.Controls.Add(this.btnKhachHang);
            this.groupBox2.Controls.Add(this.btnXuatKho);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(309, 409);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 58);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // btnExitt
            // 
            this.btnExitt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExitt.Location = new System.Drawing.Point(334, 19);
            this.btnExitt.Name = "btnExitt";
            this.btnExitt.Size = new System.Drawing.Size(75, 23);
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
            this.dgvHome.Location = new System.Drawing.Point(21, 59);
            this.dgvHome.Name = "dgvHome";
            this.dgvHome.Size = new System.Drawing.Size(708, 344);
            this.dgvHome.TabIndex = 20;
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnHoaDon;
            this.ClientSize = new System.Drawing.Size(736, 484);
            this.Controls.Add(this.dgvHome);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}