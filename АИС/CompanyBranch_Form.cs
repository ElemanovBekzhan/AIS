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
            string url = "https://www.google.com/maps/place/%D0%A0%D0%B0%D1%80%D0%B8%D1%82%D0%B5%D1%82/@42.87669,74.60535,19z/data=!4m6!3m5!1s0x389eb7c32e8e75c9:0x2361c8239bb812a5!8m2!3d42.8766543!4d74.604942!16s%2Fg%2F1tk6t8nt?hl=ru-RU";
            Process.Start(url);
        }
    }
}
