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
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn thực sự muốn thoát?", "Thoát", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            string sql = "select * from  librarian where libUsername = '" + tbUsername.Text + "' and libPassword = '"+tbPassword.Text+"'";
            DataSet data = con.getData(sql);
            if (data.Tables[0].Rows.Count > 0)
            {
                fLibrarian librarian = new fLibrarian(tbUsername.Text);
                this.Hide();
                librarian.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật sai!");
            }
        }
    }
}
