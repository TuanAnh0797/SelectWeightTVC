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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
