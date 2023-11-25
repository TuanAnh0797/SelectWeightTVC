using Newtonsoft.Json;
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
    public partial class Form1 : Form
    {
        string curentdirec;
        public Form1()
        {
            InitializeComponent();
            curentdirec = Directory.GetCurrentDirectory();
            try
            {
                loadlanguege();
                UpdateUI();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void setupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login p = new Login();
            this.Hide();
            p.ShowDialog();
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_hilowcheck_Click(object sender, EventArgs e)
        {
            FrHiLowCheck p = new FrHiLowCheck();
            this.Hide();
            p.ShowDialog();
            this.Show();
        }

        private void btn_normal_Click(object sender, EventArgs e)
        {
            FrNormalCheck p = new FrNormalCheck();
            this.Hide();
            p.ShowDialog();
            this.Show();
        }

        private void btn_changelaguage_Click(object sender, EventArgs e)
        {
            try
            {
                Changelanguege();
                UpdateUI();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateUI()
        {
            this.Text = ConverLanguage.MainForm.Title;
            lbl_header.Text = ConverLanguage.MainForm.Header;
            btn_hilowcheck.Text = ConverLanguage.MainForm.Mode1;
            btn_normal.Text = ConverLanguage.MainForm.Mode2;
            btn_changelaguage.Text = ConverLanguage.MainForm.Language;
            lbl_version.Text = ConverLanguage.Version;

        }
        public void loadlanguege()
        {
           string  contentmode = File.ReadAllText(curentdirec + "\\Mode.txt");
            if (!contentmode.ToUpper().Contains("VIETNAM"))
            {
                ConverLanguage.Mode = "J";
            }
            else
            {
                ConverLanguage.Mode = "V";
            }
            string dataconfig = File.ReadAllText(curentdirec + "\\Config.json");
            Config mycongif = JsonConvert.DeserializeObject<Config>(dataconfig);
            ConverLanguage.Version = mycongif.Version;
            if (ConverLanguage.Mode == "V")
            {
                ConverLanguage.MainForm.Title = mycongif.VietNamese .MainForm.Title;
                ConverLanguage.MainForm.Header = mycongif.VietNamese.MainForm.Header;
                ConverLanguage.MainForm.Mode1 = mycongif.VietNamese.MainForm.Mode1;
                ConverLanguage.MainForm.Mode2 = mycongif.VietNamese.MainForm.Mode2;
                ConverLanguage.MainForm.Language = mycongif.VietNamese.MainForm.Language;
                //
                ConverLanguage.SetupForm.NoneCe = mycongif.VietNamese.SetupForm.NoneCe;
                ConverLanguage.SetupForm.Link1 = mycongif.VietNamese.SetupForm.Link1;
                ConverLanguage.SetupForm.Link2 = mycongif.VietNamese.SetupForm.Link2;
                ConverLanguage.SetupForm.HaveCe = mycongif.VietNamese.SetupForm.HaveCe;
                ConverLanguage.SetupForm.TitleNotify = mycongif.VietNamese.SetupForm.TitleNotify;
                ConverLanguage.SetupForm.NotifySucces = mycongif.VietNamese.SetupForm.NotifySucces;
                ConverLanguage.SetupForm.Notify1 = mycongif.VietNamese.SetupForm.Notify1;
                ConverLanguage.SetupForm.Notify2 = mycongif.VietNamese.SetupForm.Notify2;
                ConverLanguage.SetupForm.Notify3 = mycongif.VietNamese.SetupForm.Notify3;
                ConverLanguage.SetupForm.Notify4 = mycongif.VietNamese.SetupForm.Notify4;
                ConverLanguage.SetupForm.Notify5 = mycongif.VietNamese.SetupForm.Notify5;
                ConverLanguage.SetupForm.Notify6 = mycongif.VietNamese.SetupForm.Notify6;
                ConverLanguage.SetupForm.Notify7 = mycongif.VietNamese.SetupForm.Notify7;
                ConverLanguage.SetupForm.Notify8 = mycongif.VietNamese.SetupForm.Notify8;
                //
                ConverLanguage.HiLowForm.Title = mycongif.VietNamese.HiLowForm.Title;
                ConverLanguage.HiLowForm.Header = mycongif.VietNamese.HiLowForm.Header;
                ConverLanguage.HiLowForm.Notify1 = mycongif.VietNamese.HiLowForm.Notify1;
                ConverLanguage.HiLowForm.Notify2 = mycongif.VietNamese.HiLowForm.Notify2;
                ConverLanguage.HiLowForm.Type1 = mycongif.VietNamese.HiLowForm.Type1;
                ConverLanguage.HiLowForm.Type2 = mycongif.VietNamese.HiLowForm.Type2;
                //
                ConverLanguage.NormalForm.Title = mycongif.VietNamese.NormalForm.Title;
                ConverLanguage.NormalForm.Header = mycongif.VietNamese.NormalForm.Header;
                ConverLanguage.NormalForm.Notify1 = mycongif.VietNamese.NormalForm.Notify1;
                ConverLanguage.NormalForm.Notify2 = mycongif.VietNamese.NormalForm.Notify2;
                ConverLanguage.NormalForm.Type1 = mycongif.VietNamese.NormalForm.Type1;
                ConverLanguage.NormalForm.Type2 = mycongif.VietNamese.NormalForm.Type2;
                //
               

            }
            else
            {
                ConverLanguage.MainForm.Title = mycongif.Japanese.MainForm.Title;
                ConverLanguage.MainForm.Header = mycongif.Japanese.MainForm.Header;
                ConverLanguage.MainForm.Mode1 = mycongif.Japanese.MainForm.Mode1;
                ConverLanguage.MainForm.Mode2 = mycongif.Japanese.MainForm.Mode2;
                ConverLanguage.MainForm.Language = mycongif.Japanese.MainForm.Language;
                //
                ConverLanguage.SetupForm.NoneCe = mycongif.Japanese.SetupForm.NoneCe;
                ConverLanguage.SetupForm.Link1 = mycongif.Japanese.SetupForm.Link1;
                ConverLanguage.SetupForm.Link2 = mycongif.Japanese.SetupForm.Link2;
                ConverLanguage.SetupForm.HaveCe = mycongif.Japanese.SetupForm.HaveCe;
                ConverLanguage.SetupForm.TitleNotify = mycongif.Japanese.SetupForm.TitleNotify;
                ConverLanguage.SetupForm.NotifySucces = mycongif.Japanese.SetupForm.NotifySucces;
                ConverLanguage.SetupForm.Notify1 = mycongif.Japanese.SetupForm.Notify1;
                ConverLanguage.SetupForm.Notify2 = mycongif.Japanese.SetupForm.Notify2;
                ConverLanguage.SetupForm.Notify3 = mycongif.Japanese.SetupForm.Notify3;
                ConverLanguage.SetupForm.Notify4 = mycongif.Japanese.SetupForm.Notify4;
                ConverLanguage.SetupForm.Notify5 = mycongif.Japanese.SetupForm.Notify5;
                ConverLanguage.SetupForm.Notify6 = mycongif.Japanese.SetupForm.Notify6;
                ConverLanguage.SetupForm.Notify7 = mycongif.Japanese.SetupForm.Notify7;
                ConverLanguage.SetupForm.Notify8 = mycongif.Japanese.SetupForm.Notify8;
                //
                ConverLanguage.HiLowForm.Title = mycongif.Japanese.HiLowForm.Title;
                ConverLanguage.HiLowForm.Header = mycongif.Japanese.HiLowForm.Header;
                ConverLanguage.HiLowForm.Notify1 = mycongif.Japanese.HiLowForm.Notify1;
                ConverLanguage.HiLowForm.Notify2 = mycongif.Japanese.HiLowForm.Notify2;
                ConverLanguage.HiLowForm.Type1 = mycongif.Japanese.HiLowForm.Type1;
                ConverLanguage.HiLowForm.Type2 = mycongif.Japanese.HiLowForm.Type2;
                //
                ConverLanguage.NormalForm.Title = mycongif.Japanese.NormalForm.Title;
                ConverLanguage.NormalForm.Header = mycongif.Japanese.NormalForm.Header;
                ConverLanguage.NormalForm.Notify1 = mycongif.Japanese.NormalForm.Notify1;
                ConverLanguage.NormalForm.Notify2 = mycongif.Japanese.NormalForm.Notify2;
                ConverLanguage.NormalForm.Type1 = mycongif.Japanese.NormalForm.Type1;
                ConverLanguage.NormalForm.Type2 = mycongif.Japanese.NormalForm.Type2;

              
            }

        }
        public void Changelanguege()
        {
            string dataconfig = File.ReadAllText(curentdirec + "\\Config.json");
            Config mycongif = JsonConvert.DeserializeObject<Config>(dataconfig);
            ConverLanguage.Version = mycongif.Version;
            if (ConverLanguage.Mode == "J")
            {
                ConverLanguage.MainForm.Title = mycongif.VietNamese.MainForm.Title;
                ConverLanguage.MainForm.Header = mycongif.VietNamese.MainForm.Header;
                ConverLanguage.MainForm.Mode1 = mycongif.VietNamese.MainForm.Mode1;
                ConverLanguage.MainForm.Mode2 = mycongif.VietNamese.MainForm.Mode2;
                ConverLanguage.MainForm.Language = mycongif.VietNamese.MainForm.Language;
                //
                ConverLanguage.SetupForm.NoneCe = mycongif.VietNamese.SetupForm.NoneCe;
                ConverLanguage.SetupForm.Link1 = mycongif.VietNamese.SetupForm.Link1;
                ConverLanguage.SetupForm.Link2 = mycongif.VietNamese.SetupForm.Link2;
                ConverLanguage.SetupForm.HaveCe = mycongif.VietNamese.SetupForm.HaveCe;
                ConverLanguage.SetupForm.TitleNotify = mycongif.VietNamese.SetupForm.TitleNotify;
                ConverLanguage.SetupForm.NotifySucces = mycongif.VietNamese.SetupForm.NotifySucces;
                ConverLanguage.SetupForm.Notify1 = mycongif.VietNamese.SetupForm.Notify1;
                ConverLanguage.SetupForm.Notify2 = mycongif.VietNamese.SetupForm.Notify2;
                ConverLanguage.SetupForm.Notify3 = mycongif.VietNamese.SetupForm.Notify3;
                ConverLanguage.SetupForm.Notify4 = mycongif.VietNamese.SetupForm.Notify4;
                ConverLanguage.SetupForm.Notify5 = mycongif.VietNamese.SetupForm.Notify5;
                ConverLanguage.SetupForm.Notify6 = mycongif.VietNamese.SetupForm.Notify6;
                ConverLanguage.SetupForm.Notify7 = mycongif.VietNamese.SetupForm.Notify7;
                ConverLanguage.SetupForm.Notify8 = mycongif.VietNamese.SetupForm.Notify8;
                //
                ConverLanguage.HiLowForm.Title = mycongif.VietNamese.HiLowForm.Title;
                ConverLanguage.HiLowForm.Header = mycongif.VietNamese.HiLowForm.Header;
                ConverLanguage.HiLowForm.Notify1 = mycongif.VietNamese.HiLowForm.Notify1;
                ConverLanguage.HiLowForm.Notify2 = mycongif.VietNamese.HiLowForm.Notify2;
                ConverLanguage.HiLowForm.Type1 = mycongif.VietNamese.HiLowForm.Type1;
                ConverLanguage.HiLowForm.Type2 = mycongif.VietNamese.HiLowForm.Type2;
                //
                ConverLanguage.NormalForm.Title = mycongif.VietNamese.NormalForm.Title;
                ConverLanguage.NormalForm.Header = mycongif.VietNamese.NormalForm.Header;
                ConverLanguage.NormalForm.Notify1 = mycongif.VietNamese.NormalForm.Notify1;
                ConverLanguage.NormalForm.Notify2 = mycongif.VietNamese.NormalForm.Notify2;
                ConverLanguage.NormalForm.Type1 = mycongif.VietNamese.NormalForm.Type1;
                ConverLanguage.NormalForm.Type2 = mycongif.VietNamese.NormalForm.Type2;
                //
                ConverLanguage.Mode = "V";
                writecsv("VIETNAM");

            }
            else
            {
                ConverLanguage.MainForm.Title = mycongif.Japanese.MainForm.Title;
                ConverLanguage.MainForm.Header = mycongif.Japanese.MainForm.Header;
                ConverLanguage.MainForm.Mode1 = mycongif.Japanese.MainForm.Mode1;
                ConverLanguage.MainForm.Mode2 = mycongif.Japanese.MainForm.Mode2;
                ConverLanguage.MainForm.Language = mycongif.Japanese.MainForm.Language;
                //
                ConverLanguage.SetupForm.NoneCe = mycongif.Japanese.SetupForm.NoneCe;
                ConverLanguage.SetupForm.Link1 = mycongif.Japanese.SetupForm.Link1;
                ConverLanguage.SetupForm.Link2 = mycongif.Japanese.SetupForm.Link2;
                ConverLanguage.SetupForm.HaveCe = mycongif.Japanese.SetupForm.HaveCe;
                ConverLanguage.SetupForm.TitleNotify = mycongif.Japanese.SetupForm.TitleNotify;
                ConverLanguage.SetupForm.NotifySucces = mycongif.Japanese.SetupForm.NotifySucces;
                ConverLanguage.SetupForm.Notify1 = mycongif.Japanese.SetupForm.Notify1;
                ConverLanguage.SetupForm.Notify2 = mycongif.Japanese.SetupForm.Notify2;
                ConverLanguage.SetupForm.Notify3 = mycongif.Japanese.SetupForm.Notify3;
                ConverLanguage.SetupForm.Notify4 = mycongif.Japanese.SetupForm.Notify4;
                ConverLanguage.SetupForm.Notify5 = mycongif.Japanese.SetupForm.Notify5;
                ConverLanguage.SetupForm.Notify6 = mycongif.Japanese.SetupForm.Notify6;
                ConverLanguage.SetupForm.Notify7 = mycongif.Japanese.SetupForm.Notify7;
                ConverLanguage.SetupForm.Notify8 = mycongif.Japanese.SetupForm.Notify8;
                //
                ConverLanguage.HiLowForm.Title = mycongif.Japanese.HiLowForm.Title;
                ConverLanguage.HiLowForm.Header = mycongif.Japanese.HiLowForm.Header;
                ConverLanguage.HiLowForm.Notify1 = mycongif.Japanese.HiLowForm.Notify1;
                ConverLanguage.HiLowForm.Notify2 = mycongif.Japanese.HiLowForm.Notify2;
                ConverLanguage.HiLowForm.Type1 = mycongif.Japanese.HiLowForm.Type1;
                ConverLanguage.HiLowForm.Type2 = mycongif.Japanese.HiLowForm.Type2;
                //
                ConverLanguage.NormalForm.Title = mycongif.Japanese.NormalForm.Title;
                ConverLanguage.NormalForm.Header = mycongif.Japanese.NormalForm.Header;
                ConverLanguage.NormalForm.Notify1 = mycongif.Japanese.NormalForm.Notify1;
                ConverLanguage.NormalForm.Notify2 = mycongif.Japanese.NormalForm.Notify2;
                ConverLanguage.NormalForm.Type1 = mycongif.Japanese.NormalForm.Type1;
                ConverLanguage.NormalForm.Type2 = mycongif.Japanese.NormalForm.Type2;

                ConverLanguage.Mode = "J";
                writecsv("JAPAN");
            }

        }

        public void writecsv(string data)
        {
            string filepath = Directory.GetCurrentDirectory() + "\\Mode.txt";
            File.Delete(filepath);
            using (var sr = new StreamWriter(filepath, true, Encoding.UTF8))
            {
                    sr.WriteLine(data);

            }

        }
    }
}
