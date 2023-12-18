using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Weight
{
    public partial class FrHiLowCheck : Form
    {
        string filePathCE;
        string filePathnoneCE;
        public FrHiLowCheck()
        {
            InitializeComponent();
            try
            {
                getconfig();
                UpdateUI();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          

        }
        public void UpdateUI()
        {
            this.Text = ConverLanguage.HiLowForm.Title;
            lbl_header.Text = ConverLanguage.HiLowForm.Header;
        }
        public void getconfig()
        {
            try
            {
                List<string> data = new List<string>();
                string filepath = Directory.GetCurrentDirectory() + "\\config.txt";
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
                filePathCE = data[1].Split('>')[1].TrimStart('"').TrimEnd('"');
                filePathnoneCE = data[2].Split('>')[1].TrimStart('"').TrimEnd('"');
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }


        }

        private void txb_Lot_KeyDown(object sender, KeyEventArgs e)
        {
            timer3.Start();
            //if (e.KeyData == Keys.Enter)
            //{
            //    try
            //    {
            //        if (txb_Lot.Text.Length == 7 && txb_Lot.Text.Substring(6, 1) == "A")
            //        {
            //            if (System.IO.File.Exists(filePathCE))
            //            {
            //                lbl_mode.Text = "Có dấu CE (HDSD A1)";
            //                lbl_mode.BackColor = Color.LightGreen;
            //                lbl_mode.Visible = true;
            //                timer1.Start();
            //            }
            //            else
            //            {
            //                MessageBox.Show($"Không tìm thấy File \n {filePathCE}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }

            //        }
            //        else if (txb_Lot.Text.Length == 8)
            //        {
            //            if (txb_Lot.Text.Substring(6, 2) == "VA")
            //            {
            //                if (System.IO.File.Exists(filePathCE))
            //                {
            //                    lbl_mode.Text = "Có dấu CE (HDSD A1)";
            //                    lbl_mode.BackColor = Color.LightGreen;
            //                    lbl_mode.Visible = true;
            //                    timer1.Start();
            //                }
            //                else
            //                {
            //                    MessageBox.Show($"Không tìm thấy File \n {filePathCE}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                }
            //            }
            //            else if (txb_Lot.Text.Substring(6, 2) == "TA")
            //            {

            //                if (System.IO.File.Exists(filePathnoneCE))
            //                {
            //                    lbl_mode.Text = "Không có dấu CE (HDSD quyển)";
            //                    lbl_mode.BackColor = Color.LightYellow;
            //                    lbl_mode.Visible = true;
            //                    timer2.Start();
            //                }
            //                else
            //                {
            //                    MessageBox.Show($"Không tìm thấy File \n {filePathnoneCE}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                }

            //            }
            //            else
            //            {
            //                MessageBox.Show($"Sai định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show($"Sai định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    catch (Exception ex)
            //    {

            //        MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    }

            //}

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                    Process.Start(filePathCE);
                    timer1.Stop();
                    Environment.Exit(0);
            }
            catch (Exception ex)
            {
                timer1.Stop();
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
           

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                    Process.Start(filePathnoneCE);
                    timer2.Stop();
                    Environment.Exit(0);
            }
            catch (Exception ex)
            {
                timer2.Stop();
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void txb_Lot_MouseDown(object sender, MouseEventArgs e)
        {
            txb_Lot.SelectAll();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                if (txb_Lot.Text.Length == 7 && txb_Lot.Text.Substring(6, 1) == "A")
                {
                    if (System.IO.File.Exists(filePathCE))
                    {
                        lbl_mode.Text = $"{ConverLanguage.HiLowForm.Type2}";
                        lbl_mode.BackColor = Color.LightGreen;
                        lbl_mode.Visible = true;
                        timer3.Stop();
                        timer1.Start();
                    }
                    else
                    {
                        timer3.Stop();
                        MessageBox.Show($"{ConverLanguage.HiLowForm.Notify1} \n {filePathCE}", $"{ConverLanguage.SetupForm.TitleNotify}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (txb_Lot.Text.Length == 8)
                {
                    if (txb_Lot.Text.Substring(6, 1) == "T")
                    {
                        if (System.IO.File.Exists(filePathnoneCE))
                        {
                            lbl_mode.Text = $"{ConverLanguage.NormalForm.Type1}";
                            lbl_mode.BackColor = Color.LightYellow;
                            lbl_mode.Visible = true;
                            timer3.Stop();
                            timer2.Start();
                        }
                        else
                        {
                            timer3.Stop();
                            MessageBox.Show($"{ConverLanguage.NormalForm.Notify1} \n {filePathCE}", $"{ConverLanguage.SetupForm.TitleNotify}", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        if (System.IO.File.Exists(filePathCE))
                        {
                            lbl_mode.Text = $"{ConverLanguage.NormalForm.Type2}";
                            lbl_mode.BackColor = Color.LightGreen;
                            lbl_mode.Visible = true;
                            timer3.Stop();
                            timer1.Start();
                        }
                        else
                        {
                            timer3.Stop();
                            MessageBox.Show($"{ConverLanguage.NormalForm.Notify1} \n {filePathCE}", $"{ConverLanguage.SetupForm.TitleNotify}", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                else
                {
                    timer3.Stop();
                    MessageBox.Show($"{ConverLanguage.HiLowForm.Notify2}", $"{ConverLanguage.SetupForm.TitleNotify}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                timer3.Stop();
                MessageBox.Show(ex.Message, "ERROR báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            txb_Lot.Text = "";
        }
    }
}
