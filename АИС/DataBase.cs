using System.Data.SqlClient;

namespace АИС
{
    public class DataBase
    {
        private SqlConnection con = new SqlConnection(@"Data Source=ONIGIRI;Initial Catalog=Book;Integrated Security=True");
        //Server=BEKZHAN\MURIM;Database=Book
        //Server=ONIGIRI;Database=Book
        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return con;
        }
    }
}
