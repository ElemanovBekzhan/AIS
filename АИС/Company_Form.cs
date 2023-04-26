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
    public partial class Company_Form : Form
    {
        public Company_Form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu_Form frm = new Menu_Form();
            frm.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            string url = "http://books.kg/about/";
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

        private void УчётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bookkeeping_Form frm = new Bookkeeping_Form();
            frm.Show();
            this.Close();
        }

        private void справочникToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
