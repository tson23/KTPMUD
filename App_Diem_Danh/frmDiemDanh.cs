using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace App_Diem_Danh
{
    public partial class frmDiemDanh : Form
    {
        #region Variables
        public static string ConnectionString = "Data Source = DESKTOP-UR8RRFE\\SQLEXPRESS; Initial Catalog = AppDiemDanh; User ID = sa; Password = 12345";
        #endregion
        public frmDiemDanh()
        {
            InitializeComponent();
        }

        private void frmDiemDanh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.tblLop' table. You can move, or remove it, as needed.
            this.tblLopTableAdapter.Fill(this.dataSet2.tblLop);
            // TODO: This line of code loads data into the 'dataSet2.tblLop' table. You can move, or remove it, as needed.
            this.tblLopTableAdapter.Fill(this.dataSet2.tblLop);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            display();
        }
        public void display()
        {
            listView1.Items.Clear();
            SqlConnection conn = new SqlConnection(ConnectionString);
           
            conn.Open();
            
            string query = "SELECT tblSinhVien.MSSV, tblLop.Ma_lop FROM tblSinhVien INNER JOIN tblLop ON tblSinhVien.Ma_lop = tblLop.Ma_lop WHERE tblLop.Ma_lop = '" + cboMalop.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                listView1.Items.Add((i + 1).ToString());
                listView1.Items[i].SubItems.Add(dr[0].ToString());
                i++;
            }
            conn.Close();
        }
    }
}
