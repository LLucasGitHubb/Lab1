using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void tb_nhapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '\b')
            {
                MessageBox.Show("Vui lòng chỉ nhập số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void tb_nhapb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '\b')
            {
                MessageBox.Show("Vui lòng chỉ nhập số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void bt_tinh_Click(object sender, EventArgs e)
        {
            int a = int.Parse(tb_nhapa.Text);
            int b = int.Parse(tb_nhapb.Text);
            
            long giaiThuaA = 1;
            for (int i = 2; i <= a; i++)
            {
                giaiThuaA *= i;
            }

            long giaiThuaB = 1;
            for (int i = 2; i <= b; i++)
            {
                giaiThuaB *= i;
            }

            long tongS1 = 0;
            for (int i = 1; i <= a; i++)
            {
                tongS1 += i;
            }

            long tongS2 = 0;
            for (int i = 1; i <= b; i++)
            {
                tongS2 += i;
            }

            long tongS3 = 0;
            for (int i = 1; i <= b; i++)
            {
                tongS3 += (long)Math.Pow(a, i);
            }
            tb_kq.Text = string.Format("A! = {0}\t\tB! = {1}\r\nS1 = 1+ 2 + 3 + 4 + ... + A = {2}\r\nS2 = 1+ 2 + 3 + 4 + ... + B = {3}\r\nS3 = A^1 + A^2 + A^3 + A^4 + ... + A^B = {4}",
                giaiThuaA, giaiThuaB, tongS1, tongS2, tongS3);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            tb_nhapa.Clear();
            tb_nhapb.Clear();
            tb_kq.Clear();
        }
        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
