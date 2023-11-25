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
    public partial class SetUp : Form
    {
        public SetUp()
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
            grb_1.Text = ConverLanguage.SetupForm.NoneCe;
            grb_2.Text = ConverLanguage.SetupForm.HaveCe;
            lbl_11.Text = ConverLanguage.SetupForm.Link1;
            lbl_21.Text = ConverLanguage.SetupForm.Link1;
            lbl_22.Text = ConverLanguage.SetupForm.Link2;
            lbl_12.Text = ConverLanguage.SetupForm.Link2;


        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_HL.Text == "")
                {
                    //MessageBox.Show($"Chưa cài đặt link Hi-Low check không dấu CE", $"{ConverLanguage.SetupForm.TitleNotify}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show($"{ConverLanguage.SetupForm.Notify3}", $"{ConverLanguage.SetupForm.TitleNotify}", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if(txb_N.Text =="")
                {
                    //MessageBox.Show("Chưa cài đặt link chế độ thường không dấu CE", $"{ConverLanguage.SetupForm.TitleNotify}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show($"{ConverLanguage.SetupForm.Notify4}", $"{ConverLanguage.SetupForm.TitleNotify}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(txb_HL_CE.Text =="")
                {
                   // MessageBox.Show("Chưa cài đặt link Hi-Low check có dấu CE", $"{ConverLanguage.SetupForm.TitleNotify}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show($"{ConverLanguage.SetupForm.Notify1}", $"{ConverLanguage.SetupForm.TitleNotify}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(txb_N_CE.Text == "")
                {
                    MessageBox.Show($"{ConverLanguage.SetupForm.Notify2}", $"{ConverLanguage.SetupForm.TitleNotify}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txb_HL.Text == txb_N.Text || txb_HL.Text == txb_HL_CE.Text || txb_HL.Text == txb_N_CE.Text)
                {
                    //MessageBox.Show("Link Hi-Low check không dấu CE bị lặp", $"{ConverLanguage.SetupForm.TitleNotify}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show($"{ConverLanguage.SetupForm.Notify7}", $"{ConverLanguage.SetupForm.TitleNotify}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txb_N.Text == txb_HL_CE.Text || txb_N.Text == txb_N_CE.Text)
                {
                    MessageBox.Show($"{ConverLanguage.SetupForm.Notify8}", $"{ConverLanguage.SetupForm.TitleNotify}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(txb_HL_CE.Text == txb_N_CE.Text)
                {
                    MessageBox.Show($"{ConverLanguage.SetupForm.Notify5}", $"{ConverLanguage.SetupForm.TitleNotify}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    writecsv();
                    MessageBox.Show($"{ConverLanguage.SetupForm.NotifySucces}",$"{ConverLanguage.SetupForm.TitleNotify}");
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void writecsv()
        {
            List<string> dataconfig = new List<string>();
            dataconfig.Add("HiLow Check");
            dataconfig.Add($"Có dấu CE>\"{txb_HL_CE.Text.Trim()}\"");
            dataconfig.Add($"Không dấu CE>\"{txb_HL.Text.Trim()}\"");
            dataconfig.Add("Normal Check");
            dataconfig.Add($"Có dấu CE>\"{txb_N_CE.Text.Trim()}\"");
            dataconfig.Add($"Không dấu CE>\"{txb_N.Text.Trim()}\"");
            string filepath = Directory.GetCurrentDirectory() + "\\config.txt";
            File.Delete(filepath);
            using (var sr = new StreamWriter(filepath, true, Encoding.UTF8))
            {
                dataconfig.ForEach(data =>
                {
                    sr.WriteLine(data);

                });
            }

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
                txb_HL_CE.Text = data[1].Split('>')[1].TrimStart('"').TrimEnd('"');
                txb_N_CE.Text = data[4].Split('>')[1].TrimStart('"').TrimEnd('"');
                txb_HL.Text = data[2].Split('>')[1].TrimStart('"').TrimEnd('"');
                txb_N.Text = data[5].Split('>')[1].TrimStart('"').TrimEnd('"');
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }


        }
    }
}
