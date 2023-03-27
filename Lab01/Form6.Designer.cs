namespace Lab01
{
    partial class Form6
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
            this.lb_nhapa = new System.Windows.Forms.Label();
            this.lb_nhapb = new System.Windows.Forms.Label();
            this.tb_nhapa = new System.Windows.Forms.TextBox();
            this.tb_nhapb = new System.Windows.Forms.TextBox();
            this.bt_tinh = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_kq = new System.Windows.Forms.Label();
            this.tb_kq = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_nhapa
            // 
            this.lb_nhapa.AutoSize = true;
            this.lb_nhapa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nhapa.Location = new System.Drawing.Point(71, 84);
            this.lb_nhapa.Name = "lb_nhapa";
            this.lb_nhapa.Size = new System.Drawing.Size(70, 22);
            this.lb_nhapa.TabIndex = 0;
            this.lb_nhapa.Text = "Nhập A";
            // 
            // lb_nhapb
            // 
            this.lb_nhapb.AutoSize = true;
            this.lb_nhapb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nhapb.Location = new System.Drawing.Point(449, 84);
            this.lb_nhapb.Name = "lb_nhapb";
            this.lb_nhapb.Size = new System.Drawing.Size(70, 22);
            this.lb_nhapb.TabIndex = 1;
            this.lb_nhapb.Text = "Nhập B";
            // 
            // tb_nhapa
            // 
            this.tb_nhapa.Location = new System.Drawing.Point(159, 84);
            this.tb_nhapa.Name = "tb_nhapa";
            this.tb_nhapa.Size = new System.Drawing.Size(162, 22);
            this.tb_nhapa.TabIndex = 2;
            this.tb_nhapa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nhapa_KeyPress);
            // 
            // tb_nhapb
            // 
            this.tb_nhapb.Location = new System.Drawing.Point(535, 85);
            this.tb_nhapb.Name = "tb_nhapb";
            this.tb_nhapb.Size = new System.Drawing.Size(162, 22);
            this.tb_nhapb.TabIndex = 3;
            this.tb_nhapb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nhapb_KeyPress);
            // 
            // bt_tinh
            // 
            this.bt_tinh.AutoSize = true;
            this.bt_tinh.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_tinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_tinh.Location = new System.Drawing.Point(75, 183);
            this.bt_tinh.Name = "bt_tinh";
            this.bt_tinh.Size = new System.Drawing.Size(246, 32);
            this.bt_tinh.TabIndex = 4;
            this.bt_tinh.Text = "Tính các giá trị";
            this.bt_tinh.UseVisualStyleBackColor = false;
            this.bt_tinh.Click += new System.EventHandler(this.bt_tinh_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.AutoSize = true;
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(535, 183);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(78, 32);
            this.bt_xoa.TabIndex = 5;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.AutoSize = true;
            this.bt_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Location = new System.Drawing.Point(622, 183);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(78, 32);
            this.bt_thoat.TabIndex = 6;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_kq);
            this.groupBox1.Controls.Add(this.tb_kq);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 450);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lb_kq
            // 
            this.lb_kq.AutoSize = true;
            this.lb_kq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kq.Location = new System.Drawing.Point(71, 240);
            this.lb_kq.Name = "lb_kq";
            this.lb_kq.Size = new System.Drawing.Size(75, 22);
            this.lb_kq.TabIndex = 1;
            this.lb_kq.Text = "Kết Quả";
            // 
            // tb_kq
            // 
            this.tb_kq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kq.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tb_kq.Location = new System.Drawing.Point(75, 265);
            this.tb_kq.Multiline = true;
            this.tb_kq.Name = "tb_kq";
            this.tb_kq.Size = new System.Drawing.Size(625, 162);
            this.tb_kq.TabIndex = 0;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_nhapa);
            this.Controls.Add(this.lb_nhapa);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_tinh);
            this.Controls.Add(this.tb_nhapb);
            this.Controls.Add(this.lb_nhapb);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.Text = "Bài 5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nhapa;
        private System.Windows.Forms.Label lb_nhapb;
        private System.Windows.Forms.TextBox tb_nhapa;
        private System.Windows.Forms.TextBox tb_nhapb;
        private System.Windows.Forms.Button bt_tinh;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_kq;
        private System.Windows.Forms.TextBox tb_kq;
    }
}