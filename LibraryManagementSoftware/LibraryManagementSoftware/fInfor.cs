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
    public partial class fInfor : Form
    {
        public fInfor()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            string sql = "SELECT book.bookName as [Tên sách], reader.readerName as [Người mượn], infor.borrowingDate as [Ngày mượn], infor.returnDate as [Ngày trả], infor.expirationDate as [Hạn trả] FROM book INNER JOIN infor ON book.bookId = infor.bookId INNER JOIN reader ON infor.readerId = reader.readerID";
            Connection con = new Connection();
            DataSet data = con.getData(sql);
            dgvInfor.DataSource = data.Tables[0];
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string sql = "SELECT book.bookName as [Tên sách], reader.readerName as [Người mượn], infor.borrowingDate as [Ngày mượn], infor.returnDate as [Ngày trả], infor.expirationDate as [Hạn trả] FROM book INNER JOIN infor ON book.bookId = infor.bookId INNER JOIN reader ON infor.readerId = reader.readerID ";
            Connection con = new Connection();
            
            switch (cbFilter.SelectedItem.ToString())
            {

                case "Đã trả":
                    sql = sql + "WHERE  NOT(infor.returnDate IS NULL)";
                    break;
                case "Chưa trả":
                    sql = sql + " WHERE  (infor.returnDate IS NULL)";
                    break;
            }
            DataSet data = con.getData(sql);
            dgvInfor.DataSource = data.Tables[0];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
