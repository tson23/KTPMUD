namespace App_Diem_Danh
{
    partial class frmDiemDanh
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
            this.components = new System.ComponentModel.Container();
            this.cboMalop = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.dataSet2 = new App_Diem_Danh.DataSet2();
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLopTableAdapter = new App_Diem_Danh.DataSet2TableAdapters.tblLopTableAdapter();
            this.tblLopBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.MSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ho_Ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLopBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMalop
            // 
            this.cboMalop.DataSource = this.tblLopBindingSource1;
            this.cboMalop.DisplayMember = "Ma_lop";
            this.cboMalop.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMalop.FormattingEnabled = true;
            this.cboMalop.Location = new System.Drawing.Point(41, 2);
            this.cboMalop.Name = "cboMalop";
            this.cboMalop.Size = new System.Drawing.Size(121, 22);
            this.cboMalop.TabIndex = 0;
            this.cboMalop.Text = "Mã Lớp";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLop.Location = new System.Drawing.Point(1, 1);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(34, 19);
            this.lblLop.TabIndex = 1;
            this.lblLop.Text = "Lớp";
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet2BindingSource
            // 
            this.dataSet2BindingSource.DataSource = this.dataSet2;
            this.dataSet2BindingSource.Position = 0;
            // 
            // tblLopBindingSource
            // 
            this.tblLopBindingSource.DataMember = "tblLop";
            this.tblLopBindingSource.DataSource = this.dataSet2;
            // 
            // tblLopTableAdapter
            // 
            this.tblLopTableAdapter.ClearBeforeFill = true;
            // 
            // tblLopBindingSource1
            // 
            this.tblLopBindingSource1.DataMember = "tblLop";
            this.tblLopBindingSource1.DataSource = this.dataSet2BindingSource;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MSSV,
            this.Ho_Ten,
            this.Vang});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 55);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(791, 260);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // MSSV
            // 
            this.MSSV.Text = "MSSV";
            // 
            // Ho_Ten
            // 
            this.Ho_Ten.Text = "Họ Tên";
            this.Ho_Ten.Width = 150;
            // 
            // Vang
            // 
            this.Vang.Text = "Vắng";
            // 
            // frmDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.cboMalop);
            this.Name = "frmDiemDanh";
            this.Text = "Điểm Danh";
            this.Load += new System.EventHandler(this.frmDiemDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLopBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMalop;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.BindingSource dataSet2BindingSource;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource tblLopBindingSource;
        private DataSet2TableAdapters.tblLopTableAdapter tblLopTableAdapter;
        private System.Windows.Forms.BindingSource tblLopBindingSource1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader MSSV;
        private System.Windows.Forms.ColumnHeader Ho_Ten;
        private System.Windows.Forms.ColumnHeader Vang;
    }
}