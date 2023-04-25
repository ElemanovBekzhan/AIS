﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

        }

        private void InfoCompony_button_Click(object sender, EventArgs e)
        {
            Company_Form frm = new Company_Form();
            frm.Show();
            this.Close();
        }

        private void InfoShop_button_Click(object sender, EventArgs e)
        {
            CompanyBranch_Form frm = new CompanyBranch_Form();
            frm.Show();
            this.Close();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            Bookkeeping_Form frm = new Bookkeeping_Form();
            frm.Show();
        }
    }
}