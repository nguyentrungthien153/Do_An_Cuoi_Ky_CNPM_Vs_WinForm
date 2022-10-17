using DevExpress.Data.Async;
using DevExpress.XtraEditors;
using DXApplication1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
   
    public partial class AddMemberGUI : DevExpress.XtraEditors.XtraForm
    {
        public AddMemberGUI()
        {
            InitializeComponent();
        }

        private void grbTimeManager_Enter(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtName.Text == "" || txtPass.Text == "" || txtAddMoney.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                Model1 context = new Model1();
                Member s = new Member() { AccountName = txtName.Text, Password = txtPass.Text, CurrentMoney = float.Parse(txtAddMoney.Text + "") };
                Member db = context.Members.FirstOrDefault(p => p.AccountName == "");
                context.Members.Add(s);
                MessageBox.Show("đã thêm thành công!", "Thông Báo", MessageBoxButtons.OK);
                context.SaveChanges();
                List<Member> listMember = context.Members.ToList();
                //drgvMember.dataSource = listMember; 


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR");
            }
           
            
        


        }

        private void AddMemberGUI_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát chương trình?", "Tiêu đề",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}