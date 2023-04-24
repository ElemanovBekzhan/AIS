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
    public partial class Authorization_Form : Form
    {
        public Authorization_Form()
        {
            InitializeComponent();
        }

        private void Authoriz_button_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
