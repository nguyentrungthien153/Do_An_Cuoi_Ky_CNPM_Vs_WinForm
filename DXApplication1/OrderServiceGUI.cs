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
    public partial class OrderServiceGUI : DevExpress.XtraEditors.XtraForm
    {
        public OrderServiceGUI()
        {
            InitializeComponent();
        }

        private void OrderServiceGUI_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //HomeGUI frmHome = new HomeGUI();
            this.Close();
            //frmHome.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            HomeGUI frmHome = new HomeGUI();
            this.Close();
            frmHome.ShowDialog();
        }
    }
}