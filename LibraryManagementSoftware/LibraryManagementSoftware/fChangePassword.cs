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
    public partial class fChangePassword : Form
    {
        string username;
        public fChangePassword(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            if(MessageBox.Show("Bạn có chắc chắn muốn thay đổi mật khẩu?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string sql = "select * from  librarian where libUsername = '" + username + "' and libPassword = '" + tbPasswordOld.Text + "'";
                DataSet ds = con.getData(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (tbPasswordNew.Text == tbRetypePassword.Text)
                    {
                        sql = "UPDATE librarian SET  libPassword = '" + tbPasswordNew.Text + "' where libUsername = '" + username + "'";
                        if(con.executeSql(sql) > 0)
                        {
                            MessageBox.Show("Cập nhật mật khẩu thành công");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật mật khẩu không thành công");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xác nhận mật khẩu mới không đúng");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác");
                    return;
                }
            }
        }
    }
}
