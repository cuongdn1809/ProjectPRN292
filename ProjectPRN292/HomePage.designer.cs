
namespace HumanManagement
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnNhapKho = new System.Windows.Forms.Button();
            this.btnXuatKho = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(650, 506);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phần Mềm Quản Lý Kho";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Location = new System.Drawing.Point(445, 586);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(100, 28);
            this.btnKhachHang.TabIndex = 2;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.Location = new System.Drawing.Point(26, 586);
            this.btnNhapKho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(100, 28);
            this.btnNhapKho.TabIndex = 3;
            this.btnNhapKho.Text = "Nhập Kho";
            this.btnNhapKho.UseVisualStyleBackColor = true;
            this.btnNhapKho.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnXuatKho
            // 
            this.btnXuatKho.Location = new System.Drawing.Point(163, 586);
            this.btnXuatKho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXuatKho.Name = "btnXuatKho";
            this.btnXuatKho.Size = new System.Drawing.Size(100, 28);
            this.btnXuatKho.TabIndex = 4;
            this.btnXuatKho.Text = "Xuất Kho";
            this.btnXuatKho.UseVisualStyleBackColor = true;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Location = new System.Drawing.Point(585, 586);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(100, 28);
            this.btnHoaDon.TabIndex = 6;
            this.btnHoaDon.Text = "Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(303, 586);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 28);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 648);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.btnXuatKho);
            this.Controls.Add(this.btnNhapKho);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnNhapKho;
        private System.Windows.Forms.Button btnXuatKho;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnEdit;
    }
}