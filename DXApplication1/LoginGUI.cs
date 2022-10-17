using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;
using DevExpress.Xpo.DB.Helpers;
using System.Data.SqlClient;
using DXApplication1.Models;
using ComboBox = System.Windows.Forms.ComboBox;

namespace DXApplication1
{
    public partial class LoginGUI : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection cnn = null;
        String stcnn = @"Data Source=LAPTOP-CLBQB420\SQLEXPRESS;Initial Catalog=QuanLyPhongNet;Integrated Security=True";
        SqlDataAdapter dta = null;
        DataSet ds = null;
        DataTable dt = null;
        public LoginGUI()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tentk = cboUser.Text;
            string matkhau = txtPassword.Text;
            string loaitaikhoan;
            if (tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản !"); return; }
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu"); return; }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '" + tentk + "' and MatKhau = '" + matkhau + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OptionGUIcs frmOption = new OptionGUIcs();
                    this.Hide();
                    frmOption.ShowDialog();
                }
               // string query1 = "Select * from TaiKhoan where TenTaiKhoan = '" + tentk + "' and MatKhau = '" + matkhau + "' and LoaiTk ='" + 1 + "'";
                else if(modify.TaiKhoans(query).Count != 0 )
                {
                   
                        MessageBox.Show("Đăng nhập thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HomeGUI frmOption = new HomeGUI();
                        this.Hide();
                        frmOption.ShowDialog();
                    
                }


                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            var selectedValue = (DataRowView)cmb.SelectedItem;
            var type = int.Parse(selectedValue[2].ToString());
            Authorization.Instance.UserType = type;

        }

        private void LoginGUI_Load(object sender, EventArgs e)
        {
            if (cnn == null)
                cnn = new SqlConnection(stcnn);
            dta = new SqlDataAdapter("Select *from TaiKhoan ", cnn);
            SqlCommandBuilder builder =new SqlCommandBuilder(dta);
            ds = new DataSet();
            dta.Fill(ds, "User");
            this.cboUser.DataSource = ds.Tables["User"];
            this.cboUser.DisplayMember = "TenTaiKhoan";
            this.cboUser.ValueMember = "LoaiTk";
        }
    }
}