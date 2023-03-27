using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab01
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, max, min;
            num1 = double.Parse(tb_st1.Text, CultureInfo.InvariantCulture);
            num2 = double.Parse(tb_st2.Text, CultureInfo.InvariantCulture);
            num3 = double.Parse(tb_st3.Text, CultureInfo.InvariantCulture);
            max = Math.Max(num1, Math.Max(num2, num3));
            min = Math.Min(num2, Math.Min(num1, num3));
            tb_sln.Text = max.ToString();
            tb_snn.Text = min.ToString();
        }

        private void tb_sln_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tb_sln.Text);
        }

        private void tb_snn_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tb_snn.Text);
        }

        private void tb_st1_TextChanged(object sender, EventArgs e)
        {
            double num1;
            double.TryParse(tb_st1.Text, out num1);
        }

        private void tb_st2_TextChanged(object sender, EventArgs e)
        {
            double num2;
            double.TryParse(tb_st2.Text, out num2);
        }

        private void tb_st3_TextChanged(object sender, EventArgs e)
        {
            double num3;
            double.TryParse(tb_st3.Text, out num3);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            tb_st1.Clear();
            tb_st2.Clear();
            tb_st3.Clear();
            tb_sln.Clear(); 
            tb_snn.Clear();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
