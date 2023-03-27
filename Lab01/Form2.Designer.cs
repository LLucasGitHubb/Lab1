namespace Lab01
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_tinh = new System.Windows.Forms.Button();
            this.tb_tong = new System.Windows.Forms.TextBox();
            this.tb_st2 = new System.Windows.Forms.TextBox();
            this.tb_st1 = new System.Windows.Forms.TextBox();
            this.lb_tong = new System.Windows.Forms.Label();
            this.lb_st2 = new System.Windows.Forms.Label();
            this.lb_stn = new System.Windows.Forms.Label();
            this.lb_bai1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_tinh);
            this.groupBox1.Controls.Add(this.tb_tong);
            this.groupBox1.Controls.Add(this.tb_st2);
            this.groupBox1.Controls.Add(this.tb_st1);
            this.groupBox1.Controls.Add(this.lb_tong);
            this.groupBox1.Controls.Add(this.lb_st2);
            this.groupBox1.Controls.Add(this.lb_stn);
            this.groupBox1.Controls.Add(this.lb_bai1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bt_tinh
            // 
            this.bt_tinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tinh.Location = new System.Drawing.Point(250, 300);
            this.bt_tinh.Name = "bt_tinh";
            this.bt_tinh.Size = new System.Drawing.Size(287, 29);
            this.bt_tinh.TabIndex = 7;
            this.bt_tinh.Text = "Tính";
            this.bt_tinh.UseVisualStyleBackColor = true;
            this.bt_tinh.Click += new System.EventHandler(this.bt_tinh_Click);
            // 
            // tb_tong
            // 
            this.tb_tong.Location = new System.Drawing.Point(377, 349);
            this.tb_tong.Name = "tb_tong";
            this.tb_tong.Size = new System.Drawing.Size(160, 22);
            this.tb_tong.TabIndex = 6;
            this.tb_tong.TextChanged += new System.EventHandler(this.tb_tong_TextChanged);
            // 
            // tb_st2
            // 
            this.tb_st2.Location = new System.Drawing.Point(377, 242);
            this.tb_st2.Name = "tb_st2";
            this.tb_st2.Size = new System.Drawing.Size(160, 22);
            this.tb_st2.TabIndex = 5;
            this.tb_st2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_st2_KeyPress);
            // 
            // tb_st1
            // 
            this.tb_st1.Location = new System.Drawing.Point(377, 164);
            this.tb_st1.Name = "tb_st1";
            this.tb_st1.Size = new System.Drawing.Size(160, 22);
            this.tb_st1.TabIndex = 4;
            this.tb_st1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_st1_KeyPress);
            // 
            // lb_tong
            // 
            this.lb_tong.AutoSize = true;
            this.lb_tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tong.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_tong.Location = new System.Drawing.Point(245, 349);
            this.lb_tong.Name = "lb_tong";
            this.lb_tong.Size = new System.Drawing.Size(70, 25);
            this.lb_tong.TabIndex = 3;
            this.lb_tong.Text = "TỔNG";
            // 
            // lb_st2
            // 
            this.lb_st2.AutoSize = true;
            this.lb_st2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_st2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_st2.Location = new System.Drawing.Point(245, 242);
            this.lb_st2.Name = "lb_st2";
            this.lb_st2.Size = new System.Drawing.Size(100, 25);
            this.lb_st2.TabIndex = 2;
            this.lb_st2.Text = "Số thứ hai";
            // 
            // lb_stn
            // 
            this.lb_stn.AutoSize = true;
            this.lb_stn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_stn.Location = new System.Drawing.Point(245, 164);
            this.lb_stn.Name = "lb_stn";
            this.lb_stn.Size = new System.Drawing.Size(112, 25);
            this.lb_stn.TabIndex = 1;
            this.lb_stn.Text = "Số thứ nhất";
            // 
            // lb_bai1
            // 
            this.lb_bai1.AutoSize = true;
            this.lb_bai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bai1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_bai1.Location = new System.Drawing.Point(232, 75);
            this.lb_bai1.Name = "lb_bai1";
            this.lb_bai1.Size = new System.Drawing.Size(305, 25);
            this.lb_bai1.TabIndex = 0;
            this.lb_bai1.Text = "TÍNH TỔNG HAI SỐ NGUYÊN";
            this.lb_bai1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Bài 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_bai1;
        private System.Windows.Forms.Label lb_tong;
        private System.Windows.Forms.Label lb_st2;
        private System.Windows.Forms.Label lb_stn;
        private System.Windows.Forms.TextBox tb_st2;
        private System.Windows.Forms.TextBox tb_st1;
        private System.Windows.Forms.Button bt_tinh;
        private System.Windows.Forms.TextBox tb_tong;
    }
}