namespace Lab01
{
    partial class Form3
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
            this.tb_snn = new System.Windows.Forms.TextBox();
            this.tb_sln = new System.Windows.Forms.TextBox();
            this.tb_st3 = new System.Windows.Forms.TextBox();
            this.tb_st2 = new System.Windows.Forms.TextBox();
            this.tb_st1 = new System.Windows.Forms.TextBox();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_tim = new System.Windows.Forms.Button();
            this.lb_snn = new System.Windows.Forms.Label();
            this.lb_sln = new System.Windows.Forms.Label();
            this.lb_st3 = new System.Windows.Forms.Label();
            this.lb_st2 = new System.Windows.Forms.Label();
            this.lb_stn = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_snn);
            this.groupBox1.Controls.Add(this.tb_sln);
            this.groupBox1.Controls.Add(this.tb_st3);
            this.groupBox1.Controls.Add(this.tb_st2);
            this.groupBox1.Controls.Add(this.tb_st1);
            this.groupBox1.Controls.Add(this.bt_thoat);
            this.groupBox1.Controls.Add(this.bt_xoa);
            this.groupBox1.Controls.Add(this.bt_tim);
            this.groupBox1.Controls.Add(this.lb_snn);
            this.groupBox1.Controls.Add(this.lb_sln);
            this.groupBox1.Controls.Add(this.lb_st3);
            this.groupBox1.Controls.Add(this.lb_st2);
            this.groupBox1.Controls.Add(this.lb_stn);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 445);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tb_snn
            // 
            this.tb_snn.Location = new System.Drawing.Point(564, 278);
            this.tb_snn.Name = "tb_snn";
            this.tb_snn.Size = new System.Drawing.Size(90, 22);
            this.tb_snn.TabIndex = 12;
            this.tb_snn.TextChanged += new System.EventHandler(this.tb_snn_TextChanged);
            // 
            // tb_sln
            // 
            this.tb_sln.Location = new System.Drawing.Point(206, 280);
            this.tb_sln.Name = "tb_sln";
            this.tb_sln.Size = new System.Drawing.Size(90, 22);
            this.tb_sln.TabIndex = 11;
            this.tb_sln.TextChanged += new System.EventHandler(this.tb_sln_TextChanged);
            // 
            // tb_st3
            // 
            this.tb_st3.Location = new System.Drawing.Point(660, 48);
            this.tb_st3.Name = "tb_st3";
            this.tb_st3.Size = new System.Drawing.Size(90, 22);
            this.tb_st3.TabIndex = 10;
            this.tb_st3.TextChanged += new System.EventHandler(this.tb_st3_TextChanged);
            // 
            // tb_st2
            // 
            this.tb_st2.Location = new System.Drawing.Point(400, 49);
            this.tb_st2.Name = "tb_st2";
            this.tb_st2.Size = new System.Drawing.Size(90, 22);
            this.tb_st2.TabIndex = 9;
            this.tb_st2.TextChanged += new System.EventHandler(this.tb_st2_TextChanged);
            // 
            // tb_st1
            // 
            this.tb_st1.Location = new System.Drawing.Point(125, 49);
            this.tb_st1.Name = "tb_st1";
            this.tb_st1.Size = new System.Drawing.Size(90, 22);
            this.tb_st1.TabIndex = 8;
            this.tb_st1.TextChanged += new System.EventHandler(this.tb_st1_TextChanged);
            // 
            // bt_thoat
            // 
            this.bt_thoat.AutoSize = true;
            this.bt_thoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Location = new System.Drawing.Point(566, 172);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 30);
            this.bt_thoat.TabIndex = 7;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.AutoSize = true;
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(366, 172);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 30);
            this.bt_xoa.TabIndex = 6;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_tim
            // 
            this.bt_tim.AutoSize = true;
            this.bt_tim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tim.Location = new System.Drawing.Point(173, 172);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(75, 30);
            this.bt_tim.TabIndex = 5;
            this.bt_tim.Text = "Tìm";
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // lb_snn
            // 
            this.lb_snn.AutoSize = true;
            this.lb_snn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_snn.Location = new System.Drawing.Point(451, 280);
            this.lb_snn.Name = "lb_snn";
            this.lb_snn.Size = new System.Drawing.Size(101, 20);
            this.lb_snn.TabIndex = 4;
            this.lb_snn.Text = "Số nhỏ nhất ";
            // 
            // lb_sln
            // 
            this.lb_sln.AutoSize = true;
            this.lb_sln.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sln.Location = new System.Drawing.Point(98, 280);
            this.lb_sln.Name = "lb_sln";
            this.lb_sln.Size = new System.Drawing.Size(92, 20);
            this.lb_sln.TabIndex = 3;
            this.lb_sln.Text = "Số lớn nhất";
            // 
            // lb_st3
            // 
            this.lb_st3.AutoSize = true;
            this.lb_st3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_st3.Location = new System.Drawing.Point(583, 48);
            this.lb_st3.Name = "lb_st3";
            this.lb_st3.Size = new System.Drawing.Size(71, 20);
            this.lb_st3.TabIndex = 2;
            this.lb_st3.Text = "Số thứ 3";
            // 
            // lb_st2
            // 
            this.lb_st2.AutoSize = true;
            this.lb_st2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_st2.Location = new System.Drawing.Point(301, 48);
            this.lb_st2.Name = "lb_st2";
            this.lb_st2.Size = new System.Drawing.Size(83, 20);
            this.lb_st2.TabIndex = 1;
            this.lb_st2.Text = "Số thứ hai";
            // 
            // lb_stn
            // 
            this.lb_stn.AutoSize = true;
            this.lb_stn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stn.Location = new System.Drawing.Point(22, 48);
            this.lb_stn.Name = "lb_stn";
            this.lb_stn.Size = new System.Drawing.Size(93, 20);
            this.lb_stn.TabIndex = 0;
            this.lb_stn.Text = "Số thứ nhất";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Bài 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_snn;
        private System.Windows.Forms.Label lb_sln;
        private System.Windows.Forms.Label lb_st3;
        private System.Windows.Forms.Label lb_st2;
        private System.Windows.Forms.Label lb_stn;
        private System.Windows.Forms.TextBox tb_snn;
        private System.Windows.Forms.TextBox tb_sln;
        private System.Windows.Forms.TextBox tb_st3;
        private System.Windows.Forms.TextBox tb_st2;
        private System.Windows.Forms.TextBox tb_st1;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_tim;
    }
}