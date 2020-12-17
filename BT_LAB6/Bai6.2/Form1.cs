using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6._2
{
    public partial class Form1 : Form
    {
        short a, b, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void bntDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdpt1.Checked = true;
        }
        private void rdpt2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdpt2.Checked)
            {
                txtsoc.Enabled = true;
                txtkqua.Clear();
            }

        }

        void GiaiPT1(short a1, short b1)
        {
            if (a1 == 0)
                if (b1 == 0)
                    txtkqua.Text = "PTVSN!";
                else
                    txtkqua.Text = "PTVN!";
            else
                txtkqua.Text = "PT co nghiem x=" + ((float)-b / a).ToString();
        }

        private void rdpt1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdpt1.Checked)
            {
                txtsoc.Enabled = false;
                txtsoc.Clear();
                txtkqua.Clear();
            }

        }

        private void bntThuchien_Click(object sender, EventArgs e)
        {
            //kiểm tra định dạng của số a
            bool chk = Int16.TryParse(txtsoa.Text, out a);
            if (chk == false)
            {
                MessageBox.Show("Lỗi định dạng!\nNhập lại!", "Thông báo", MessageBoxButtons.OK);
                txtsoa.Text = "";
                txtsoa.Focus();
            }
            //kiểm tra định dạng của số b
            bool chkb = Int16.TryParse(txtsob.Text, out b);
            if (chkb == false)
            {
                MessageBox.Show("Lỗi định dạng!\nNhập lại!", "Thông báo", MessageBoxButtons.OK);
                txtsob.Text = "";
                txtsob.Focus();
            }
            if (rdpt1.Checked)//giải pt bậc 1           
                GiaiPT1(a, b);

            if (rdpt2.Checked)//giải pt bậc 2
            {
                //kiểm tra định dạng của số c  
                bool chkc = Int16.TryParse(txtsoc.Text, out c);
                if (chkc == false)
                {
                    MessageBox.Show("Lỗi định dạng!\nNhập lại!", "Thông báo", MessageBoxButtons.OK);
                    txtsoc.Text = "";
                    txtsoc.Focus();
                }
                //giải ptb2
                if (a == 0)
                    GiaiPT1(b, c);
                else
                {
                    double del = b * b - 4 * a * c;
                    if (del < 0)
                        txtkqua.Text = "PTVN!";
                    else if (del == 0)
                        txtkqua.Text = "PT co nghiem kep x1= x2= " + (-b / (2 * a)).ToString();
                    else
                    {
                        double x1 = (-b + Math.Sqrt(del)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(del)) / (2 * a);
                        txtkqua.Text = "PT co 2 nghiem x1= " + x1.ToString() + " x2= " + x2.ToString();
                    }


                }
            }
        }
    }
}