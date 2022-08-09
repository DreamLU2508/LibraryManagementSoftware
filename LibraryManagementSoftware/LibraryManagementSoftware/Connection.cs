using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSoftware
{
    internal class Connection
    {
        SqlConnection connection = new SqlConnection("Data Source=DREAMLU;Initial Catalog=LibraryManagementSoftware;Integrated Security=True");

        public DataSet getData(string sqlQuery)
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            connection.Close();
            return ds;
        }

        public int executeSql(string sqlQuery)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            int rows = command.ExecuteNonQuery();
            connection.Close();
            return rows;
        }
    }
}
