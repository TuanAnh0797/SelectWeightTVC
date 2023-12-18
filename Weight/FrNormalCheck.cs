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
    public partial class FrNormalCheck : Form
    {
        string filePathCE;
        string filePathnoneCE;
        public FrNormalCheck()
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
            this.Text = ConverLanguage.NormalForm.Title;
            lbl_header.Text = ConverLanguage.NormalForm.Header;
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
                filePathCE = data[4].Split('>')[1].TrimStart('"').TrimEnd('"');
                filePathnoneCE = data[5].Split('>')[1].TrimStart('"').TrimEnd('"');
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
          

        }

        private void txb_lot_KeyDown(object sender, KeyEventArgs e)
        {
            timer3.Start();

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

        private void txb_lot_MouseDown(object sender, MouseEventArgs e)
        {
            txb_lot.SelectAll();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                if (txb_lot.Text.Length == 7 && txb_lot.Text.Substring(6, 1) == "A")
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
                else if (txb_lot.Text.Length == 8)
                {
                    if (txb_lot.Text.Substring(6, 1) == "T")
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
                   
                    //else
                    //{
                    //    timer3.Stop();
                    //    MessageBox.Show($"{ConverLanguage.NormalForm.Notify2}", $"{ConverLanguage.SetupForm.TitleNotify}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
                else
                {
                    timer3.Stop();
                    MessageBox.Show($"{ConverLanguage.NormalForm.Notify2}", $"{ConverLanguage.SetupForm.TitleNotify}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                timer3.Stop();
                MessageBox.Show(ex.Message, "ERROR báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            txb_lot.Text = "";
        }
    }
}
