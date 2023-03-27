using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bt_tinh_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            num1 = Int32.Parse(tb_st1.Text.Trim());
            num2 = Int32.Parse(tb_st2.Text.Trim());
            sum = num1 + num2;
            tb_tong.Text = sum.ToString();
        }

        private void tb_st1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '\b')
            {
                MessageBox.Show("Vui lòng chỉ nhập số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void tb_st2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '\b')
            {
                MessageBox.Show("Vui lòng chỉ nhập số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void tb_tong_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tb_tong.Text);
        }
    }
}
