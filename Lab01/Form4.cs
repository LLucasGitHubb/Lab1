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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void tb_nhap_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(tb_nhap.Text, out number) && number >= 0 && number <= 9)
            {

            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên từ 0 đến 9.");
                tb_nhap.Text = ""; 
            }
        }

        private void bt_doc_Click(object sender, EventArgs e)
        {
            int number = int.Parse(tb_nhap.Text);
            string result = "";

            switch (number)
            {
                case 0:
                    result = "Không";
                    break;
                case 1:
                    result = "Một";
                    break;
                case 2:
                    result = "Hai";
                    break;
                case 3:
                    result = "Ba";
                    break;
                case 4:
                    result = "Bốn";
                    break;
                case 5:
                    result = "Năm";
                    break;
                case 6:
                    result = "Sáu";
                    break;
                case 7:
                    result = "Bảy";
                    break;
                case 8:
                    result = "Tám";
                    break;
                case 9:
                    result = "Chín";
                    break;
                default:
                    result = "Số nhập vào không hợp lệ";
                    break;
            }

            tb_kq.Text = result.ToString();
        }
        private void tb_kq_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tb_kq.Text);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            tb_nhap.Clear(); 
            tb_kq.Text = ""; 
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
