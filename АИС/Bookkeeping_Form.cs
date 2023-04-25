using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АИС
{
    public partial class Bookkeeping_Form : Form
    {
        public Bookkeeping_Form()
        {
            InitializeComponent();
        }

        private void SetRound_pictureBox1(object sender, EventArgs e)
        {
            // Установить свойство SizeMode в значение StretchImage
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // Создать графический путь
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1);

            // Установить свойство Region pictureBox1 с использованием графического пути
            pictureBox1.Region = new Region(gp);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu_Form frm = new Menu_Form();
            frm.Show();
        }
    }
}
