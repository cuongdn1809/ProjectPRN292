
namespace ProjectPRN292
{
    partial class frmAddSanPham
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
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTebSanPham = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            this.SuspendLayout();
            // 
            // numGia
            // 
            this.numGia.Location = new System.Drawing.Point(185, 144);
            this.numGia.Name = "numGia";
            this.numGia.Size = new System.Drawing.Size(280, 22);
            this.numGia.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 31);
            this.label5.TabIndex = 56;
            this.label5.Text = "Thêm Sản Phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Giá sản phẩm";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(185, 201);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(280, 22);
            this.txtNote.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Ghi chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Tên sản phẩm";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(302, 275);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(122, 275);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtTebSanPham
            // 
            this.txtTebSanPham.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtTebSanPham.Location = new System.Drawing.Point(185, 91);
            this.txtTebSanPham.Name = "txtTebSanPham";
            this.txtTebSanPham.Size = new System.Drawing.Size(280, 22);
            this.txtTebSanPham.TabIndex = 64;
            // 
            // frmAddSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 369);
            this.Controls.Add(this.txtTebSanPham);
            this.Controls.Add(this.numGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "frmAddSanPham";
            this.Text = "frmAddSanPham";
            this.Load += new System.EventHandler(this.frmAddSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTebSanPham;
    }
}