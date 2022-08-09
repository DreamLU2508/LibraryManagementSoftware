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
    public partial class fBook : Form
    {
        public fBook()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            Connection con = new Connection();
            string sql = "SELECT bookId AS [Mã], bookName AS Tên, bookAuthor AS [Tác giả], bookPublishing AS [Ngày xuất bản], bookAmount AS [Số lượng hiện có] FROM book";
            DataSet data = con.getData(sql);
            dgvBook.DataSource = data.Tables[0];
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {

            string sql = "INSERT INTO book VALUES(N'" + tbBookName.Text + "', N'" + tbBookAuthor.Text + "', '" + dtpBookPublishing.Value.ToString("yyyy-MM-dd") + "', " + (int)nrudBookAmount.Value + ")";
            Connection con = new Connection();
            if(con.executeSql(sql) > 0)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
            loadData();
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeleteBook.Enabled = true;
            btnEditBook.Enabled = true;

            tbBookId.Text = dgvBook.CurrentRow.Cells[0].Value.ToString();
            tbBookName.Text = dgvBook.CurrentRow.Cells[1].Value.ToString();
            tbBookAuthor.Text = dgvBook.CurrentRow.Cells[2].Value.ToString();
            dtpBookPublishing.Text = dgvBook.CurrentRow.Cells[3].Value.ToString();
            nrudBookAmount.Value = new Decimal(Convert.ToInt32(dgvBook.CurrentRow.Cells[4].Value));
        }

        private void btnEditReader_Click(object sender, EventArgs e)
        {
            
            string sql = "UPDATE book SET bookName = N'"+ tbBookName.Text + "', bookAuthor = N'"+ tbBookAuthor.Text + "', bookPublishing = '"+ dtpBookPublishing.Value.ToString("yyyy-MM-dd") + "', bookAmount = " + nrudBookAmount.Value + "where bookId = " + tbBookId.Text;
            Connection con = new Connection();
            if (con.executeSql(sql) > 0)
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
            loadData();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();

            if(MessageBox.Show("Bạn có chắc chắn muốn xóa quyển sách này không do có thể sẽ ảnh hưởng đến thông tin mượn trả", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // xóa thông tin mượn trả trước khi xóa sách
                string sql1 = "select * FROM infor WHERE(bookId = "+tbBookId.Text+")";
                string sql2 = "delete FROM infor WHERE(bookId = " + tbBookId.Text + ")";
                string sql3 = "DELETE FROM book WHERE(bookId = " + tbBookId.Text + ")";
                if (con.getData(sql1).Tables[0].Rows.Count > 0)
                {
                    if (con.executeSql(sql2) > 0)
                    {
                        if (con.executeSql(sql3) > 0)
                        {
                            MessageBox.Show("Xóa thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xóa không thành công");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
                else
                {
                    if (con.executeSql(sql3) > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
            }
            loadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
