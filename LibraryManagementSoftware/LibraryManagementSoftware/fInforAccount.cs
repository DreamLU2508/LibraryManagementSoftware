using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSoftware
{
    public partial class fInforAccount : Form
    {
        public fInforAccount(string username)
        {
            InitializeComponent();
            loadData(username);
        }

        private void loadData(string username)
        {
            string sql = "select * from  librarian where libUsername = '" + username + "' ";
            Connection con = new Connection();
            DataSet data = con.getData(sql);

            tbName.Text = data.Tables[0].Rows[0]["libName"].ToString();
            tbUsername.Text = data.Tables[0].Rows[0]["libUsername"].ToString();
            tbEmail.Text = data.Tables[0].Rows[0]["libEmail"].ToString();
            tbPhone.Text = data.Tables[0].Rows[0]["libPhone"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE librarian SET libName = N'" + tbName.Text + "', libEmail = '" + tbEmail.Text + "', libPhone = '" + tbPhone.Text + "' where libUsername = '" + tbUsername.Text + "'";
            Connection con = new Connection();
            if(con.executeSql(sql) > 0)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công");
            }
            loadData(tbUsername.Text);
        }
    }
}
