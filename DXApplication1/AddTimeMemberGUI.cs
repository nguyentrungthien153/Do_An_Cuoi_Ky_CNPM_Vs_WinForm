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

namespace DXApplication1
{
    public partial class AddTimeMemberGUI : DevExpress.XtraEditors.XtraForm
    {
        public AddTimeMemberGUI()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát chương trình?", "Tiêu đề",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void AddTimeMemberGUI_Load(object sender, EventArgs e)
        {

        }
    }
}