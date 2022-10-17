using DevExpress.XtraEditors;
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

namespace DXApplication1
{
    public partial class OptionGUIcs : DevExpress.XtraEditors.XtraForm
    {
        String TenTaiKhoan = "", MatKhau = "", LoaiTk = "";
        SqlConnection cnn = null;
        String stcnn = @"Data Source=LAPTOP-CLBQB420\SQLEXPRESS;Initial Catalog=QuanLyPhongNet;Integrated Security=True";
        Modify modify = new Modify();
        public OptionGUIcs()
        {
            InitializeComponent();
            if (Authorization.Instance.UserType == 1)
            {
                picCategory.Visible = false;
                txtCategory.Visible = false;
            }
        }
        public OptionGUIcs(string TenTaiKhoan, string MatKhau, string LoaiTk)
        {
            this.TenTaiKhoan = TenTaiKhoan;
            this.MatKhau = MatKhau;
            this.LoaiTk = LoaiTk;
        }
        private void picHome_Click(object sender, EventArgs e)
        {
            HomeGUI frmHome = new HomeGUI();
            this.Hide();
            frmHome.ShowDialog();
        }

        private void picCategory_Click(object sender, EventArgs e)
        {
            CategoryManageGUI frmCategory = new CategoryManageGUI();
            this.Hide();
            frmCategory.ShowDialog();
        }

        

        private void llblSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginGUI frmLogin = new LoginGUI();
            this.Hide();
            frmLogin.ShowDialog();
        }
    }
}