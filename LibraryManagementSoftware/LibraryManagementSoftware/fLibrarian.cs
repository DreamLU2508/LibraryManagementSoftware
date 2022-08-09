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
    public partial class fLibrarian : Form
    {
        string username;
        public fLibrarian(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void thôngTinTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fInforAccount inforAccount = new fInforAccount(username);
            inforAccount.ShowDialog();
        }

        private void đôiMâtKhâuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChangePassword changePassword = new fChangePassword(username);
            changePassword.ShowDialog();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void quanLySachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBook book = new fBook();
            book.ShowDialog();
        }

        private void quanLyBanĐocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fReader reader = new fReader();
            reader.ShowDialog();
        }

        private void quanLyMươnTraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fInfor infor = new fInfor();
            infor.ShowDialog();
        }
    }
}
