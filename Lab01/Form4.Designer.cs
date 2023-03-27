namespace Lab01
{
    partial class Form4
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
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_doc = new System.Windows.Forms.Button();
            this.tb_nhap = new System.Windows.Forms.TextBox();
            this.lb_ketqua = new System.Windows.Forms.Label();
            this.lb_nhap = new System.Windows.Forms.Label();
            this.tb_kq = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_kq);
            this.groupBox1.Controls.Add(this.bt_thoat);
            this.groupBox1.Controls.Add(this.bt_xoa);
            this.groupBox1.Controls.Add(this.bt_doc);
            this.groupBox1.Controls.Add(this.tb_nhap);
            this.groupBox1.Controls.Add(this.lb_ketqua);
            this.groupBox1.Controls.Add(this.lb_nhap);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 448);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bt_thoat
            // 
            this.bt_thoat.AutoSize = true;
            this.bt_thoat.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Location = new System.Drawing.Point(602, 247);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 35);
            this.bt_thoat.TabIndex = 6;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.AutoSize = true;
            this.bt_xoa.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(602, 168);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 35);
            this.bt_xoa.TabIndex = 5;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_doc
            // 
            this.bt_doc.AutoSize = true;
            this.bt_doc.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_doc.Location = new System.Drawing.Point(602, 98);
            this.bt_doc.Name = "bt_doc";
            this.bt_doc.Size = new System.Drawing.Size(75, 35);
            this.bt_doc.TabIndex = 4;
            this.bt_doc.Text = "Đọc";
            this.bt_doc.UseVisualStyleBackColor = false;
            this.bt_doc.Click += new System.EventHandler(this.bt_doc_Click);
            // 
            // tb_nhap
            // 
            this.tb_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nhap.Location = new System.Drawing.Point(359, 97);
            this.tb_nhap.Name = "tb_nhap";
            this.tb_nhap.Size = new System.Drawing.Size(131, 30);
            this.tb_nhap.TabIndex = 3;
            this.tb_nhap.TextChanged += new System.EventHandler(this.tb_nhap_TextChanged);
            // 
            // lb_ketqua
            // 
            this.lb_ketqua.AutoSize = true;
            this.lb_ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ketqua.Location = new System.Drawing.Point(50, 258);
            this.lb_ketqua.Name = "lb_ketqua";
            this.lb_ketqua.Size = new System.Drawing.Size(85, 25);
            this.lb_ketqua.TabIndex = 1;
            this.lb_ketqua.Text = "Kết Quả";
            // 
            // lb_nhap
            // 
            this.lb_nhap.AutoSize = true;
            this.lb_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nhap.Location = new System.Drawing.Point(50, 94);
            this.lb_nhap.Name = "lb_nhap";
            this.lb_nhap.Size = new System.Drawing.Size(283, 25);
            this.lb_nhap.TabIndex = 0;
            this.lb_nhap.Text = "Nhập vào số nguyên từ 0 đến 9";
            // 
            // tb_kq
            // 
            this.tb_kq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kq.Location = new System.Drawing.Point(55, 318);
            this.tb_kq.Name = "tb_kq";
            this.tb_kq.Size = new System.Drawing.Size(100, 30);
            this.tb_kq.TabIndex = 7;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Bài 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_doc;
        private System.Windows.Forms.TextBox tb_nhap;
        private System.Windows.Forms.Label lb_ketqua;
        private System.Windows.Forms.Label lb_nhap;
        private System.Windows.Forms.TextBox tb_kq;
    }
}