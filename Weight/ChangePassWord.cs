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
    public partial class ChangePassWord : Form
    {
        string password;
        public delegate void mydeledate();
        public mydeledate confirm;
        public ChangePassWord()
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txb_curent.Text == password)
            {
                writecsv();
                getconfig();
                confirm?.Invoke();
                MessageBox.Show("Thay đổi mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void writecsv()
        {
            List<string> dataconfig = new List<string>();
            dataconfig.Add($"PassWord>{txb_new.Text}");
            string filepath = Directory.GetCurrentDirectory() + "\\User.txt";
            File.Delete(filepath);
            using (var sr = new StreamWriter(filepath, true, Encoding.UTF8))
            {
                dataconfig.ForEach(data =>
                {
                    sr.WriteLine(data);

                });
            }

        }

        private void ckb_show_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_show.Checked)
            {
                txb_curent.UseSystemPasswordChar = false;
                txb_new.UseSystemPasswordChar = false;
            }
            else
            {
                txb_curent.UseSystemPasswordChar = true;
                txb_new.UseSystemPasswordChar = true;
            }
        }
    }
}
