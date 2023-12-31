namespace App_Diem_Danh
{
    partial class frmDangky
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
            this.lblDKtaikhoan = new System.Windows.Forms.Label();
            this.lblDKmatkhau1 = new System.Windows.Forms.Label();
            this.lblDKmatkhau2 = new System.Windows.Forms.Label();
            this.txtDKtaikhoan = new System.Windows.Forms.TextBox();
            this.txtDKmatkhau1 = new System.Windows.Forms.TextBox();
            this.txtDKmatkhau2 = new System.Windows.Forms.TextBox();
            this.lblDKTK = new System.Windows.Forms.Label();
            this.btnDangkyTK = new System.Windows.Forms.Button();
            this.btnTrove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDKtaikhoan
            // 
            this.lblDKtaikhoan.AutoSize = true;
            this.lblDKtaikhoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDKtaikhoan.Location = new System.Drawing.Point(56, 103);
            this.lblDKtaikhoan.Name = "lblDKtaikhoan";
            this.lblDKtaikhoan.Size = new System.Drawing.Size(115, 21);
            this.lblDKtaikhoan.TabIndex = 0;
            this.lblDKtaikhoan.Text = "Tên tài khoản:";
            this.lblDKtaikhoan.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDKmatkhau1
            // 
            this.lblDKmatkhau1.AutoSize = true;
            this.lblDKmatkhau1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDKmatkhau1.Location = new System.Drawing.Point(56, 158);
            this.lblDKmatkhau1.Name = "lblDKmatkhau1";
            this.lblDKmatkhau1.Size = new System.Drawing.Size(83, 21);
            this.lblDKmatkhau1.TabIndex = 1;
            this.lblDKmatkhau1.Text = "Mật khẩu:";
            // 
            // lblDKmatkhau2
            // 
            this.lblDKmatkhau2.AutoSize = true;
            this.lblDKmatkhau2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDKmatkhau2.Location = new System.Drawing.Point(56, 217);
            this.lblDKmatkhau2.Name = "lblDKmatkhau2";
            this.lblDKmatkhau2.Size = new System.Drawing.Size(146, 21);
            this.lblDKmatkhau2.TabIndex = 2;
            this.lblDKmatkhau2.Text = "Nhắc lại mật khẩu:";
            // 
            // txtDKtaikhoan
            // 
            this.txtDKtaikhoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDKtaikhoan.Location = new System.Drawing.Point(215, 95);
            this.txtDKtaikhoan.Name = "txtDKtaikhoan";
            this.txtDKtaikhoan.Size = new System.Drawing.Size(289, 29);
            this.txtDKtaikhoan.TabIndex = 3;
            // 
            // txtDKmatkhau1
            // 
            this.txtDKmatkhau1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDKmatkhau1.Location = new System.Drawing.Point(215, 150);
            this.txtDKmatkhau1.Name = "txtDKmatkhau1";
            this.txtDKmatkhau1.Size = new System.Drawing.Size(289, 29);
            this.txtDKmatkhau1.TabIndex = 4;
            this.txtDKmatkhau1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDKmatkhau2
            // 
            this.txtDKmatkhau2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDKmatkhau2.Location = new System.Drawing.Point(215, 209);
            this.txtDKmatkhau2.Name = "txtDKmatkhau2";
            this.txtDKmatkhau2.Size = new System.Drawing.Size(289, 29);
            this.txtDKmatkhau2.TabIndex = 5;
            this.txtDKmatkhau2.TextChanged += new System.EventHandler(this.txtDKmatkhau2_TextChanged);
            // 
            // lblDKTK
            // 
            this.lblDKTK.AutoSize = true;
            this.lblDKTK.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDKTK.Location = new System.Drawing.Point(193, 28);
            this.lblDKTK.Name = "lblDKTK";
            this.lblDKTK.Size = new System.Drawing.Size(213, 31);
            this.lblDKTK.TabIndex = 6;
            this.lblDKTK.Text = "Đăng ký tài khoản";
            // 
            // btnDangkyTK
            // 
            this.btnDangkyTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangkyTK.Location = new System.Drawing.Point(237, 265);
            this.btnDangkyTK.Name = "btnDangkyTK";
            this.btnDangkyTK.Size = new System.Drawing.Size(94, 32);
            this.btnDangkyTK.TabIndex = 7;
            this.btnDangkyTK.Text = "Đăng ký";
            this.btnDangkyTK.UseVisualStyleBackColor = true;
            this.btnDangkyTK.Click += new System.EventHandler(this.btnDangkyTK_Click);
            // 
            // btnTrove
            // 
            this.btnTrove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrove.Location = new System.Drawing.Point(1, 2);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(83, 27);
            this.btnTrove.TabIndex = 8;
            this.btnTrove.Text = "Trở về";
            this.btnTrove.UseVisualStyleBackColor = true;
            this.btnTrove.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnTrove);
            this.Controls.Add(this.btnDangkyTK);
            this.Controls.Add(this.lblDKTK);
            this.Controls.Add(this.txtDKmatkhau2);
            this.Controls.Add(this.txtDKmatkhau1);
            this.Controls.Add(this.txtDKtaikhoan);
            this.Controls.Add(this.lblDKmatkhau2);
            this.Controls.Add(this.lblDKmatkhau1);
            this.Controls.Add(this.lblDKtaikhoan);
            this.Name = "frmDangky";
            this.Text = "Đăng ký";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDKtaikhoan;
        private System.Windows.Forms.Label lblDKmatkhau1;
        private System.Windows.Forms.Label lblDKmatkhau2;
        private System.Windows.Forms.TextBox txtDKtaikhoan;
        private System.Windows.Forms.TextBox txtDKmatkhau1;
        private System.Windows.Forms.TextBox txtDKmatkhau2;
        private System.Windows.Forms.Label lblDKTK;
        private System.Windows.Forms.Button btnDangkyTK;
        private System.Windows.Forms.Button btnTrove;
    }
}