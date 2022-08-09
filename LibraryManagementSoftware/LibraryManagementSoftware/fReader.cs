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
    public partial class fReader : Form
    {
        public fReader()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            Connection con = new Connection();
            string sql = "SELECT readerID AS [Mã], readerName AS Tên, readerSex AS [Giới tính], readerBirthday AS [Ngày sinh], readerPhone AS [Số điện thoại], readerAddress AS [Địa chỉ], readerCreatedAt AS [Ngày tạo], readErexpirationAt AS[Ngày hết hạn] FROM reader";
            DataSet data = con.getData(sql);
            dgvReader.DataSource = data.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sex = "Giới tính thứ 3";

            if (rbReaderMale.Checked)
            {
                sex = rbReaderMale.Text;
            }

            if (rbReaderFemale.Checked)
            {
                sex = rbReaderFemale.Text;
            }

            string sql = "INSERT INTO reader VALUES(N'" + tbReaderName.Text + "', N'" + sex + "', '"+dtpReaderBirthday.Value.ToString("yyyy-MM-dd")+"', '"+ tbReaderPhone.Text +"', N'"+ tbReaderAddress.Text +"', '"+ dtpReaderCreatedAt.Value.ToString("yyyy-MM-dd") +"', '"+ dtpReadErexpirationAt.Value.ToString("yyyy-MM-dd") + "')";
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

        private void dgvReader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeleteReader.Enabled = true;
            btnEditReader.Enabled = true;

            tbReaderId.Text = dgvReader.CurrentRow.Cells[0].Value.ToString();
            tbReaderName.Text = dgvReader.CurrentRow.Cells[1].Value.ToString();
            if(dgvReader.CurrentRow.Cells[2].Value.ToString() == "Nam")
            {
                rbReaderMale.Checked = true;
            }
            if (dgvReader.CurrentRow.Cells[2].Value.ToString() == "Nữ")
            {
                rbReaderFemale.Checked = true;
            }
            dtpReaderBirthday.Text = dgvReader.CurrentRow.Cells[3].Value.ToString();
            tbReaderPhone.Text = dgvReader.CurrentRow.Cells[4].Value.ToString();
            tbReaderAddress.Text = dgvReader.CurrentRow.Cells[5].Value.ToString();
            dtpReaderCreatedAt.Text = dgvReader.CurrentRow.Cells[6].Value.ToString();
            dtpReadErexpirationAt.Text = dgvReader.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnEditReader_Click(object sender, EventArgs e)
        {
            string sex = "";

            if (rbReaderMale.Checked)
            {
                sex = rbReaderMale.Text;
            }

            if (rbReaderFemale.Checked)
            {
                sex = rbReaderFemale.Text;
            }
            string sql = "UPDATE reader SET readerName = N'"+ tbReaderName.Text +"', readerBirthday = '"+ dtpReaderBirthday.Value.ToString("yyyy-MM-dd") +"', readerSex = N'"+ sex +"', readerPhone = '"+ tbReaderPhone.Text +"', readerAddress = N'"+ tbReaderAddress.Text +"', readerCreatedAt = '"+ dtpReaderCreatedAt.Value.ToString("yyyy-MM-dd") +"', readErexpirationAt = '"+ dtpReadErexpirationAt.Value.ToString("yyyy-MM-dd") + "' WHERE (readerID = "+ tbReaderId.Text +")";
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

        private void btnDeleteReader_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa quyển sách này không do có thể sẽ ảnh hưởng đến thông tin mượn trả", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // xóa thông tin mượn trả trước khi xóa sách
                string sql1 = "select * FROM infor WHERE(readerId = " + tbReaderId.Text + ")";
                string sql2 = "delete FROM infor WHERE(readerId = " + tbReaderId.Text + ")";
                string sql3 = "DELETE FROM reader WHERE(readerId = " + tbReaderId.Text + ")";
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
