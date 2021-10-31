
using ProjectPRN292.DAL;
using ProjectPRN292.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ProjectPRN292
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username and Password must not empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }

            else
            {
                if (LoginList.checkAccount(txtUsername.Text.Trim(), txtPassword.Text.Trim()).Count > 0)
                {
                    DataTable table = LoginDAL.checkAccount(txtUsername.Text, txtPassword.Text);
                    Home h = new Home();
                    if (table.Rows.Count > 0)
                    {
                        h.ShowDialog();
                        this.Close();
                    }

                }
                else
                    MessageBox.Show("Wrong username or password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            int a;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
