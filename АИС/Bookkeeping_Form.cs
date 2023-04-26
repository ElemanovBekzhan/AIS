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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Данные не выбраны");
            }
            else
            {
                try
                {
                    dataBase.openConnection();
                    string quary = "UPDATE Book_tab SET Наименование = '" + textBox4.Text + "',Издательство = '" +
                                   textBox2.Text + "',Цена = '" +
                                   textBox3.Text + "' WHERE ID = '" + label5.Text + "';";
                    SqlCommand cmd = new SqlCommand(quary, dataBase.getConnection());
                    cmd.ExecuteNonQuery();
                    Table.Clear();
                    adapter.Fill(Table);
                    dataGridView1.DataSource = Table;
                    

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
                finally
                {
                    dataBase.closeConnection();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Данные не выбраны");
                }
                else
                {
                    try
                    {
                        dataBase.openConnection();
                        string quary = "DELETE FROM Book_tab WHERE ID ='" + label5.Text + "';";

                        SqlCommand cmd = new SqlCommand(quary, dataBase.getConnection());
                        cmd.ExecuteNonQuery();
                        Table.Clear();
                        adapter.Fill(Table);
                        dataGridView1.DataSource = Table;
                        
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                        throw;
                    }
                    finally
                    {
                        dataBase.closeConnection();
                    }
                }
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Данные не введены");
            }
            else
            {
                try
                {
                    dataBase.openConnection();

                    string quary = "INSERT INTO Book_tab (Наименование, Издательство, Цена) VALUES('" + textBox4.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                    SqlCommand cmd = new SqlCommand(quary, dataBase.getConnection());
                    cmd.ExecuteNonQuery();
                    Table.Clear();
                    adapter.Fill(Table);
                    dataGridView1.DataSource = Table;
                    
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
                finally
                {
                    dataBase.closeConnection();
                }
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
