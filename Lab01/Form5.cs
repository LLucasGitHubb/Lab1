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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void tb_stcd_TextChanged(object sender, EventArgs e)
        {
            double number;
            if (!double.TryParse(tb_stcd.Text, out number))
            {
                MessageBox.Show("Bạn cần nhập số tiền cần đổi. Vui lòng nhập lại!");
                tb_stcd.Clear();
            }
        }

        private void cbb_menhgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cbb_menhgia.SelectedItem.ToString();
            double exchangeRate = 0;

            switch (selectedItem)
            {
                case "USD(Đô - la Mỹ)":
                    exchangeRate = 22772;
                    break;
                case "EUR(Đồng Euro)":
                    exchangeRate = 28132;
                    break;
                case "GBP(Bảng Anh)":
                    exchangeRate = 31538;
                    break;
                case "SGD(Đô - la Singapore)":
                    exchangeRate = 17286;
                    break;
                case "JPY(Yên Nhật)":
                    exchangeRate = 214;
                    break;
                default:
                    break;
            }

            tb_tgqd.Text = $"1 {selectedItem} = {exchangeRate} VND";
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            cbb_menhgia.Items.Add("USD(Đô - la Mỹ)");
            cbb_menhgia.Items.Add("EUR(Đồng Euro)");
            cbb_menhgia.Items.Add("GBP(Bảng Anh)");
            cbb_menhgia.Items.Add("SGD(Đô - la Singapore)");
            cbb_menhgia.Items.Add("JPY(Yên Nhật)");
        }

        private void bt_cd_Click(object sender, EventArgs e)
        {
            double exchangeRate = 0;
            string selectedItem = cbb_menhgia.SelectedItem.ToString();

            switch (selectedItem)
            {
                case "USD(Đô - la Mỹ)":
                    exchangeRate = 22772;
                    break;
                case "EUR(Đồng Euro)":
                    exchangeRate = 28132;
                    break;
                case "GBP(Bảng Anh)":
                    exchangeRate = 31538;
                    break;
                case "SGD(Đô - la Singapore)":
                    exchangeRate = 17286;
                    break;
                case "JPY(Yên Nhật)":
                    exchangeRate = 214;
                    break;
                default:
                    break;
            }

            if (double.TryParse(tb_stcd.Text, out double inputAmount))
            {
                double convertedAmount = inputAmount * exchangeRate;
                tb_stqd.Text = convertedAmount.ToString();
            }
        }
    }
}


