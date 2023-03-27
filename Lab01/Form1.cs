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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_bai1_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            myForm.ShowDialog();
        }

        private void bt_bai2_Click(object sender, EventArgs e)
        {
            Form3 myForm = new Form3();
            myForm.ShowDialog();
        }

        private void bt_bai3_Click(object sender, EventArgs e)
        {
            Form4 myForm = new Form4();
            myForm.ShowDialog();
        }

        private void bt_bai4_Click(object sender, EventArgs e)
        {
            Form5 myForm = new Form5();
            myForm.ShowDialog();
        }

        private void bt_bai5_Click(object sender, EventArgs e)
        {
            Form6 myForm = new Form6();
            myForm.ShowDialog();
        }
    }
}
