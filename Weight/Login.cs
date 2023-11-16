using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Weight
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txb_user.Text == "PME" && txb_password.Text == "123456")
            {
                SetUp p = new SetUp();
                p.Show();
                txb_user.Text = "";
                txb_password.Text = "";
            }
            else
            {
                MessageBox.Show($"Không đúng mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txb_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                txb_password.Focus();
            }
        }

        private void txb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_Login.Focus();
            }
        }
    }
}
