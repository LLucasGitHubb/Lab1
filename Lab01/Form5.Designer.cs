namespace Lab01
{
    partial class Form5
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
            this.tb_tgqd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_stqd = new System.Windows.Forms.TextBox();
            this.lb_stdd = new System.Windows.Forms.Label();
            this.bt_cd = new System.Windows.Forms.Button();
            this.cbb_menhgia = new System.Windows.Forms.ComboBox();
            this.tb_stcd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_cdtt = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_tgqd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_stqd);
            this.groupBox1.Controls.Add(this.lb_stdd);
            this.groupBox1.Controls.Add(this.bt_cd);
            this.groupBox1.Controls.Add(this.cbb_menhgia);
            this.groupBox1.Controls.Add(this.tb_stcd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb_cdtt);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 438);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tb_tgqd
            // 
            this.tb_tgqd.Location = new System.Drawing.Point(189, 378);
            this.tb_tgqd.Name = "tb_tgqd";
            this.tb_tgqd.Size = new System.Drawing.Size(229, 22);
            this.tb_tgqd.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tỷ giá quy đổi ";
            // 
            // tb_stqd
            // 
            this.tb_stqd.Location = new System.Drawing.Point(189, 298);
            this.tb_stqd.Name = "tb_stqd";
            this.tb_stqd.Size = new System.Drawing.Size(229, 22);
            this.tb_stqd.TabIndex = 6;
            // 
            // lb_stdd
            // 
            this.lb_stdd.AutoSize = true;
            this.lb_stdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stdd.Location = new System.Drawing.Point(30, 297);
            this.lb_stdd.Name = "lb_stdd";
            this.lb_stdd.Size = new System.Drawing.Size(120, 22);
            this.lb_stdd.TabIndex = 5;
            this.lb_stdd.Text = "Số tiền đã đổi";
            // 
            // bt_cd
            // 
            this.bt_cd.AutoSize = true;
            this.bt_cd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_cd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cd.Location = new System.Drawing.Point(33, 194);
            this.bt_cd.Name = "bt_cd";
            this.bt_cd.Size = new System.Drawing.Size(278, 35);
            this.bt_cd.TabIndex = 4;
            this.bt_cd.Text = "Chuyển đổi";
            this.bt_cd.UseVisualStyleBackColor = false;
            this.bt_cd.Click += new System.EventHandler(this.bt_cd_Click);
            // 
            // cbb_menhgia
            // 
            this.cbb_menhgia.FormattingEnabled = true;
            this.cbb_menhgia.Location = new System.Drawing.Point(449, 112);
            this.cbb_menhgia.Name = "cbb_menhgia";
            this.cbb_menhgia.Size = new System.Drawing.Size(160, 24);
            this.cbb_menhgia.TabIndex = 3;
            this.cbb_menhgia.SelectedIndexChanged += new System.EventHandler(this.cbb_menhgia_SelectedIndexChanged);
            // 
            // tb_stcd
            // 
            this.tb_stcd.Location = new System.Drawing.Point(189, 112);
            this.tb_stcd.Name = "tb_stcd";
            this.tb_stcd.Size = new System.Drawing.Size(229, 22);
            this.tb_stcd.TabIndex = 2;
            this.tb_stcd.TextChanged += new System.EventHandler(this.tb_stcd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số tiền cần đổi ";
            // 
            // lb_cdtt
            // 
            this.lb_cdtt.AutoSize = true;
            this.lb_cdtt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cdtt.Location = new System.Drawing.Point(28, 38);
            this.lb_cdtt.Name = "lb_cdtt";
            this.lb_cdtt.Size = new System.Drawing.Size(163, 23);
            this.lb_cdtt.TabIndex = 0;
            this.lb_cdtt.Text = "Chuyển đổi tiền tệ";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Text = "Bài 4";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_tgqd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_stqd;
        private System.Windows.Forms.Label lb_stdd;
        private System.Windows.Forms.Button bt_cd;
        private System.Windows.Forms.ComboBox cbb_menhgia;
        private System.Windows.Forms.TextBox tb_stcd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_cdtt;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}