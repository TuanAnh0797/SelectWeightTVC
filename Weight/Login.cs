using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Weight
{
    public partial class Login : Form
    {
        string password;
        public Login()
        {
            InitializeComponent();
            getconfig();
        }
        public void getconfig()
        {
            try
            {
                List<string> data = new List<string>();
                string filepath = Directory.GetCurrentDirectory() + "\\User.txt";
                using (var fs = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (var sr = new StreamReader(fs, Encoding.UTF8))
                    {
                        while (!sr.EndOfStream)
                        {
                            data.Add(sr.ReadLine());
                        }
                    }
                }
                password = data[0].Split('>')[1];
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }


        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txb_user.Text == "PME" && txb_password.Text == password)
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

        private void ckb_show_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_show.Checked)
            {
                txb_password.UseSystemPasswordChar = false;
            }
            else
            {
                txb_password.UseSystemPasswordChar = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ChangePassWord p = new ChangePassWord();
            p.confirm = new ChangePassWord.mydeledate(getconfig);
            p.Show();
        }
    }
}
