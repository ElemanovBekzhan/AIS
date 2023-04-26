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
    public partial class Contact_Form : Form
    {
        public Contact_Form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu_Form frm = new Menu_Form();
            frm.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.facebook.com/sharer.php?u=http%3A%2F%2Fbooks.kg&t=%D0%A0%D0%90%D0%A0%D0%98%D0%A2%D0%95%D0%A2";
            Process.Start(url);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CompanyBranch_Form frm = new CompanyBranch_Form();
            frm.Show();
            this.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "http://twitter.com/share?text=%D0%9A%D0%BD%D0%B8%D0%B6%D0%BD%D1%8B%D0%B9%20%D0%BC%D0%B0%D0%B3%D0%B0%D0%B7%D0%B8%D0%BD%20%E2%80%9C%D0%A0%D0%B0%D1%80%D0%B8%D1%82%D0%B5%D1%82%E2%80%9D%20%D0%B3%D0%BE%D1%80%D0%BE%D0%B4%20%D0%91%D0%B8%D1%88%D0%BA%D0%B5%D0%BA&url=http%3A%2F%2Fbooks.kg%2F";
            Process.Start(url);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://mail.google.com/mail/u/0/?view=cm&fs=1&su=%D0%9A%D0%BD%D0%B8%D0%B6%D0%BD%D1%8B%D0%B9%20%D0%BC%D0%B0%D0%B3%D0%B0%D0%B7%D0%B8%D0%BD%20%E2%80%9C%D0%A0%D0%B0%D1%80%D0%B8%D1%82%D0%B5%D1%82%E2%80%9D%20%D0%B3%D0%BE%D1%80%D0%BE%D0%B4%20%D0%91%D0%B8%D1%88%D0%BA%D0%B5%D0%BA&body=http%3A%2F%2Fbooks.kg%2F&ui=2&tf=1";
            Process.Start(url);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "http://vk.com/share.php?url=http%3A%2F%2Fbooks.kg%2F";
            Process.Start(url);
        }
    }
}
