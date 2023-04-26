using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АИС
{
    public partial class CompanyBranch_Form : Form
    {
        public CompanyBranch_Form()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.google.com/maps/place/%D0%A0%D0%B0%D1%80%D0%B8%D1%82%D0%B5%D1%82/@42.876654,74.604942,18z/data=!4m6!3m5!1s0x389eb7c32e8e75c9:0x2361c8239bb812a5!8m2!3d42.8766543!4d74.604942!16s%2Fg%2F1tk6t8nt?hl=ru-RU";
            Process.Start(url);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Menu_Form frm = new Menu_Form();
            frm.Show();
            this.Close();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.google.com/maps/place/%D0%94%D0%B5%D1%82%D1%81%D0%BA%D0%B8%D0%B9+%D0%BC%D0%B8%D1%80/@42.87409,74.618263,17z/data=!4m6!3m5!1s0x389eb7b8dca5f787:0x8b9452eb5cf6a711!8m2!3d42.875675!4d74.618818!16s%2Fg%2F1tplnphb?hl=ru-RU";
            Process.Start(url);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.google.com/maps/place/%D0%A2%D0%A0%D0%A6+%D0%93%D0%A3%D0%9C/@42.87514,74.614682,17z/data=!4m6!3m5!1s0x389eb7c722e4dfc9:0x16c010462673e2fa!8m2!3d42.874951!4d74.6144456!16s%2Fg%2F1q6j3wn0g?hl=ru-RU";
            Process.Start(url);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.google.com/maps/place/%D0%A2%D0%A0%D0%A6+%D0%93%D0%A3%D0%9C/@42.87514,74.614682,17z/data=!4m6!3m5!1s0x389eb7c722e4dfc9:0x16c010462673e2fa!8m2!3d42.874951!4d74.6144456!16s%2Fg%2F1q6j3wn0g?hl=ru-RU";
            Process.Start(url);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.google.com/maps/place/%D0%A0%D0%B0%D1%80%D0%B8%D1%82%D0%B5%D1%82/@42.876654,74.604942,17z/data=!4m6!3m5!1s0x389eb7c32e8e75c9:0x2361c8239bb812a5!8m2!3d42.8766543!4d74.604942!16s%2Fg%2F1tk6t8nt?hl=ru-RU";
            Process.Start(url);
        }

        private void CompanyBranch_Form_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            string url = "http://books.kg/adress/";
            Process.Start(url);
        }

        private void оКомпанииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company_Form frm = new Company_Form();
            frm.Show();
            this.Close();
        }

        private void производствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyBranch_Form frm = new CompanyBranch_Form();
            frm.Show();
            this.Close();
        }

        private void социальнаяОтветственностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bookkeeping_Form frm = new Bookkeeping_Form();
            frm.Show();
            this.Close();
        }

        private void контактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact_Form frm = new Contact_Form();
            frm.Show();
            this.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
