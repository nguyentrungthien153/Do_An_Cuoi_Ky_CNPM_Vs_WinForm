using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{

    
    public partial class HomeGUI : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection cnn = null;
        String stcnn = @"Data Source=LAPTOP-CLBQB420\SQLEXPRESS;Initial Catalog=QuanLyPhongNet;Integrated Security=True";
        SqlDataAdapter dta = null;
        DataSet ds = null;
        DataTable dt = null;

        public HomeGUI()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OptionGUIcs frmOption = new OptionGUIcs();
            this.Hide();
            frmOption.ShowDialog();
        }

        private void picAddMember_Click(object sender, EventArgs e)
        {
            AddMemberGUI frmAddMember = new AddMemberGUI();
            frmAddMember.ShowDialog();
        }

        private void picDeleteMember_Click(object sender, EventArgs e)
        {

        }

        private void picUpdateMember_Click(object sender, EventArgs e)
        {
            AddTimeMemberGUI frmAddTime = new AddTimeMemberGUI();
            frmAddTime.ShowDialog();
        }

        private void picOrder_Click(object sender, EventArgs e)
        {
            OrderServiceGUI frmOrder = new OrderServiceGUI();
            frmOrder.ShowDialog();
        }

        private void HomeGUI_Load(object sender, EventArgs e)
        {
            if (cnn == null)
                cnn = new SqlConnection(stcnn);
            dta = new SqlDataAdapter("select *from Member " , cnn);
            ds = new DataSet();
            SqlCommandBuilder buider = new SqlCommandBuilder(dta);
            dta.Fill(ds, "Member");
            drgvMember.DataSource = ds.Tables["Member"];
            dta = new SqlDataAdapter("select *from TheUser ", cnn);
            dta.Fill(ds, "TheUser");
            drgvStaff.DataSource = ds.Tables["TheUser"];
            dta = new SqlDataAdapter("select *from TheCard ", cnn);
            dta.Fill(ds, "TheCard");
            drgvCard.DataSource = ds.Tables["TheCard"];
            dta = new SqlDataAdapter("select *from Drink ", cnn);
            dta.Fill(ds, "Drink");
            drgvDrink.DataSource = ds.Tables["Drink"];
            dta = new SqlDataAdapter("select *from Food ", cnn);
            dta.Fill(ds, "Food");
            drgvFood.DataSource = ds.Tables["Food"];
            dta = new SqlDataAdapter("select *from Client ", cnn);
            dta.Fill(ds, "Client");
            drgvClient.DataSource = ds.Tables["Client"];
            dta = new SqlDataAdapter("select *from GroupUser ", cnn);
            dta.Fill(ds, "GroupUser");
            drgvUserGroup.DataSource = ds.Tables["GroupUser"];
            dta = new SqlDataAdapter("select *from GroupClient ", cnn);
            dta.Fill(ds, "GroupClient");
            drgvGroupClient.DataSource = ds.Tables["GroupClient"];
        }

        private void drgvDrink_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderServiceGUI frmOrder = new OrderServiceGUI();
            frmOrder.ShowDialog();
        }

        private void drgvCard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderServiceGUI frmOrder = new OrderServiceGUI();
            frmOrder.ShowDialog();
        }

        private void TimKiemMember_Click(object sender, EventArgs e)
        {
            dta = new SqlDataAdapter("select *from Member ", cnn);
            ds = new DataSet();
            SqlCommandBuilder buider = new SqlCommandBuilder(dta);
            dta.Fill(ds, "Member");
            drgvMember.DataSource = ds.Tables["Member"];
            
        }
        private void drgvClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {
                    for (int i = 0; i < drgvClient.Rows.Count; i++)
                    {
                        drgvClient.Rows[i].Selected = false;
                    }

                    if (e.RowIndex >= 0 && drgvClient.Rows[e.RowIndex] != null)
                    {
                        drgvClient.Rows[e.RowIndex].Selected = true;
                    }
                }
        private void picOpenClient_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < drgvClient.Rows.Count; i++)
            {
                if (drgvClient.Rows[i].Selected)
                {
                    drgvClient.Rows[i].Cells["StatusClient"].Value = "CONNECT";
                }
            }
        }
        private void picLockClient_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < drgvClient.Rows.Count; i++)
            {
                if (drgvClient.Rows[i].Selected)
                {
                    drgvClient.Rows[i].Cells["ActiveStatusClient"].Value = "LOCK";
                }
            }
        }

        private void picShutdownClient_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < drgvClient.Rows.Count; i++)
            {
                if (drgvClient.Rows[i].Selected)
                {
                    drgvClient.Rows[i].Cells["ActiveStatusClient"].Value = "OFFLINE";
                }
            }
        }
    }
}