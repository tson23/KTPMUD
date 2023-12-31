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
using System.Xml.Linq;

namespace App_Diem_Danh
{
    public partial class frmDangky : Form
    {
        #region Variables
        public static string ConnectionString = "Data Source = DESKTOP-UR8RRFE\\SQLEXPRESS; Initial Catalog = AppDiemDanh; User ID = sa; Password = 12345";
        #endregion
        public frmDangky()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangkyTK_Click(object sender, EventArgs e)
        {
            // Kiểm tra textbox tài khoản mật khẩu đã nhập chưa
            if (txtDKtaikhoan.Text != null && txtDKtaikhoan.Text.Trim() != "") { }
            else
            {
                MessageBox.Show("Chưa nhập tài khoản", "Thông báo");
                txtDKtaikhoan.Focus();
                return;
            }
            if (txtDKmatkhau1.Text != null && txtDKmatkhau1.Text.Trim() != "") { }
            else
            {
                MessageBox.Show("Chưa nhập mật khẩu", "Thông báo");
                txtDKmatkhau1.Focus();
                return;
            }
            if (txtDKmatkhau2.Text != null && txtDKmatkhau2.Text.Trim() != "") { }
            else
            {
                MessageBox.Show("Chưa nhắc lại mật khẩu", "Thông báo");
                txtDKmatkhau2.Focus();
                return;
            }
            if (txtDKmatkhau1.Text != txtDKmatkhau2.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu chưa chính xác", "Thông báo");
                txtDKmatkhau1.Focus();
                return;
            }
            // Kiểm tra thông tin tài khoản
            else
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string TaiKhoan = txtDKtaikhoan.Text.Trim();
                string MatKhau = txtDKmatkhau1.Text.Trim();
                string query = "INSERT INTO tblTaiKhoan (Tai_Khoan, Mat_Khau) VALUES ('"+TaiKhoan+"','"+MatKhau+"')";

                SqlCommand cmd = new SqlCommand(query, conn);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0 )
                {
                    MessageBox.Show("Đăng ký thành công.", "Thông báo");
                    // Xóa dữ liệu sau khi thêm thành công
                    txtDKtaikhoan.Text = "";
                    txtDKmatkhau1.Text = "";
                    txtDKmatkhau2.Text = "";
                }
                else
                {
                    MessageBox.Show("Không thể thêm dữ liệu.");
                }
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin _frmLogin = new frmLogin();
            _frmLogin.Show();
            this.Hide();
        }

        private void txtDKmatkhau2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
