using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АИС
{
    public partial class InfoSt : Form
    {
        public InfoSt()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu_Form frm = new Menu_Form();
            frm.Show();
            this.Close();
        }
    }
}
