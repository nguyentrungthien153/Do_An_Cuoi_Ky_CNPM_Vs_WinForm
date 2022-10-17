using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DXApplication1
{
    public partial class DatabaseConfigurationGUI : DevExpress.XtraEditors.XtraForm
    {
        public DatabaseConfigurationGUI()
        {
            InitializeComponent();
        }

        SqlConnection cnn = null;
        String stcnn = @"Data Source=LAPTOP-CLBQB420\SQLEXPRESS;Initial Catalog=QuanLyPhongNet;Integrated Security=True";

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát không?",
                 "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                cnn = new SqlConnection(stcnn);
                cnn.Open();
                MessageBox.Show("kết nối thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoginGUI loginGUI = new LoginGUI();
            this.Hide();
            loginGUI.ShowDialog();
        }

        private void DatabaseConfigurationGUI_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
