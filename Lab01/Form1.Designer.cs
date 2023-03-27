namespace Lab01
{
    partial class Form1
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
            this.bt_bai1 = new System.Windows.Forms.Button();
            this.bt_bai2 = new System.Windows.Forms.Button();
            this.bt_bai3 = new System.Windows.Forms.Button();
            this.bt_bai4 = new System.Windows.Forms.Button();
            this.bt_bai5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_bai5);
            this.groupBox1.Controls.Add(this.bt_bai4);
            this.groupBox1.Controls.Add(this.bt_bai3);
            this.groupBox1.Controls.Add(this.bt_bai2);
            this.groupBox1.Controls.Add(this.bt_bai1);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bt_bai1
            // 
            this.bt_bai1.Location = new System.Drawing.Point(40, 56);
            this.bt_bai1.Name = "bt_bai1";
            this.bt_bai1.Size = new System.Drawing.Size(312, 64);
            this.bt_bai1.TabIndex = 0;
            this.bt_bai1.Text = "Bài 1";
            this.bt_bai1.UseVisualStyleBackColor = true;
            this.bt_bai1.Click += new System.EventHandler(this.bt_bai1_Click);
            // 
            // bt_bai2
            // 
            this.bt_bai2.Location = new System.Drawing.Point(448, 56);
            this.bt_bai2.Name = "bt_bai2";
            this.bt_bai2.Size = new System.Drawing.Size(312, 64);
            this.bt_bai2.TabIndex = 1;
            this.bt_bai2.Text = "Bài 2";
            this.bt_bai2.UseVisualStyleBackColor = true;
            this.bt_bai2.Click += new System.EventHandler(this.bt_bai2_Click);
            // 
            // bt_bai3
            // 
            this.bt_bai3.Location = new System.Drawing.Point(40, 197);
            this.bt_bai3.Name = "bt_bai3";
            this.bt_bai3.Size = new System.Drawing.Size(312, 64);
            this.bt_bai3.TabIndex = 2;
            this.bt_bai3.Text = "Bài 3";
            this.bt_bai3.UseVisualStyleBackColor = true;
            this.bt_bai3.Click += new System.EventHandler(this.bt_bai3_Click);
            // 
            // bt_bai4
            // 
            this.bt_bai4.Location = new System.Drawing.Point(448, 197);
            this.bt_bai4.Name = "bt_bai4";
            this.bt_bai4.Size = new System.Drawing.Size(312, 64);
            this.bt_bai4.TabIndex = 3;
            this.bt_bai4.Text = "Bài 4";
            this.bt_bai4.UseVisualStyleBackColor = true;
            this.bt_bai4.Click += new System.EventHandler(this.bt_bai4_Click);
            // 
            // bt_bai5
            // 
            this.bt_bai5.Location = new System.Drawing.Point(40, 342);
            this.bt_bai5.Name = "bt_bai5";
            this.bt_bai5.Size = new System.Drawing.Size(312, 64);
            this.bt_bai5.TabIndex = 4;
            this.bt_bai5.Text = "Bài 5";
            this.bt_bai5.UseVisualStyleBackColor = true;
            this.bt_bai5.Click += new System.EventHandler(this.bt_bai5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_bai5;
        private System.Windows.Forms.Button bt_bai4;
        private System.Windows.Forms.Button bt_bai3;
        private System.Windows.Forms.Button bt_bai2;
        private System.Windows.Forms.Button bt_bai1;
    }
}

