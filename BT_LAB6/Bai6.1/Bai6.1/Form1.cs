using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6._1
{
    public partial class Form1 : Form
    {
        short a, b;
        public Form1()
        {
            InitializeComponent();
        }
        //Khi rời textbox số b, kiểm tra không đúng định dạng thì hiện hộp thông báo
        private void txtSoa_Leave(object sender, EventArgs e)
        {
            bool chk = Int16.TryParse(txtSoa.Text, out a);
            if (chk == false)//số nhập không đúng định dạng
                if (MessageBox.Show("Lỗi định dạng\nBạn có nhập lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    txtSoa.Clear();
                    txtSoa.Focus();
                }
        }

        //Khi rời textbox số b, kiểm tra không đúng định dạng thì hiện hộp thông báo

        private void txtSob_Leave(object sender, EventArgs e)
        {
            bool chk = Int16.TryParse(txtSob.Text, out b);
            if (chk == false)//số nhập không đúng định dạng
                if (MessageBox.Show("Lỗi định dạng\nBạn có nhập lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    txtSob.Clear();
                    txtSob.Focus();
                }
        }

        //Nút lệnh “Close” để đóng form
        private void bntDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Nút lệnh “C” để xóa dữ liệu trong các textbox trên form, đưa con trỏ tới textbox số a
        private void bntXoa_Click(object sender, EventArgs e)
        {
            txtSoa.Text = "";
            txtSob.Clear();
            txtKetqua.Clear();
            txtSoa.Focus();
        }
        //Nút lệnh “+”
        private void bntCong_Click(object sender, EventArgs e)
        {
            txtKetqua.Text = (a + b).ToString();//chuyển giá trị a+b qua kiểu chuỗi
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
