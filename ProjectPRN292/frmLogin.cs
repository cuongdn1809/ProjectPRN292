
using ProjectPRN292.DAL;
using ProjectPRN292.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace ProjectPRN292
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

           
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Tên người dùng và Mật khẩu không được để trống!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
            else
            {
                //               var hasPass = new Regex(@"^.*[A-Z].*[#@$!%*?&-]+.*$");
                //               if (!hasPass.IsMatch(txtPassword.Text))
                //               {
                //                   MessageBox.Show("Mật khẩu sai!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //                   txtUsername.Focus();
                //               }
                //               else
                //               {
                if (LoginDAL.IsAccountValid(txtUsername.Text.Trim(), txtPassword.Text.Trim()).Count > 0)
                    {
                        DataTable table = LoginDAL.checkAccount(txtUsername.Text, txtPassword.Text);
                        frmTrangChu h = new frmTrangChu();
                        if (table.Rows.Count > 0)
                        {
                            Visible = false;
                            h.ShowDialog();

                        }
                    }
                    else
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
 //               }

                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát ra không?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
