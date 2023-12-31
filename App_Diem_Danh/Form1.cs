using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Diem_Danh
{
    public partial class frmLogin : Form
    {
        #region Variables
        public static string ConnectionString = "Data Source = DESKTOP-UR8RRFE\\SQLEXPRESS; Initial Catalog = AppDiemDanh; User ID = sa; Password = 12345";
        #endregion
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kiểm tra textbox tài khoản mật khẩu đã nhập chưa
            if (txtTaikhoan.Text !=null && txtTaikhoan.Text.Trim( ) != "") { }
            else
            {
                MessageBox.Show("Chưa nhập tài khoản", "Thông báo");
                txtTaikhoan.Focus();
                return;
            }
            if (txtMatkhau.Text != null && txtMatkhau.Text.Trim() != "") { }
            else
            {
                MessageBox.Show("Chưa nhập mật khẩu", "Thông báo");
                txtMatkhau.Focus();
                return;
            }
            // Kiểm tra thông tin tài khoản
            SqlConnection conn = new SqlConnection(ConnectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string TaiKhoan = txtTaikhoan.Text.Trim();
            string MatKhau = txtMatkhau.Text.Trim();
            string query = "SELECT * FROM tblTaiKhoan WHERE Tai_Khoan = '" + TaiKhoan + "' AND Mat_Khau = '" + MatKhau + "' ";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(ds!=null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                frmMain _frmMain = new frmMain();
                _frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu chưa chính xác", "Thông báo");
                txtTaikhoan.Focus();
                return;
            }

            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            frmDangky _frmDangky = new frmDangky();
            _frmDangky.Show();
            this.Hide();
        }
    }
}
