using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace АИС
{
    public partial class Bookkeeping_Form : Form
    {
        public Bookkeeping_Form()
        {
            InitializeComponent();
        }
        private DataBase dataBase = new DataBase();
        private DataTable Table, Table1 = null;
        private SqlDataAdapter adapter, adapter1 = null;
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

        private void Search_button_Click(object sender, EventArgs e)
        {
            SqlParameter sqlParameter = new SqlParameter("@NBook", textBox1.Text);
            string _query = "Search_SP";
            using(SqlCommand cmd = new SqlCommand(_query, dataBase.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(sqlParameter);
                Table = new DataTable();

                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(Table);
                dataGridView1.DataSource = Table;
                dataGridView1.Columns["ID"].Visible = false;
                dataGridView1.Columns["ID"].ReadOnly = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu_Form frm = new Menu_Form();
            frm.Show();
            this.Close();
        }

        private void Bookkeeping_Form_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Book_tab";
            using (SqlCommand cmd = new SqlCommand(sql, dataBase.getConnection()))
            {
                cmd.CommandType = CommandType.Text;
                Table = new DataTable();
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(Table);
                dataGridView1.DataSource = Table;
                dataGridView1.Columns["ID"].Visible = false;
                dataGridView1.Columns["ID"].ReadOnly = true;
                // привязываем DataTable к DataGridView

            }
        }
    }
}
