using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Diem_Danh
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            frmDiemDanh _frmDiemDanh = new frmDiemDanh();
            _frmDiemDanh.Show();
            this.Hide();
        }
    }
}
