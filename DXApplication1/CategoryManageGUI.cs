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
    public partial class CategoryManageGUI : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection cnn = null;
        String stcnn = @"Data Source=LAPTOP-CLBQB420\SQLEXPRESS;Initial Catalog=QuanLyPhongNet;Integrated Security=True";
        SqlDataAdapter dta = null;
        DataSet ds = null;
        DataTable dt = null;
        SqlCommand cmd = null;
        public CategoryManageGUI()
        {
            InitializeComponent();
        }
        public bool KTThongTin()
        {
            if (txtFoodName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFoodName.Focus();
                return false;
            }
            if (cboFoodCategory.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thuộc loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboFoodCategory.Focus();
                return false;
            }
            if (txtPriceUnitOfFood.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPriceUnitOfFood.Focus();
                return false;
            }
            if (txtInventoryNumberOfFood.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng tồn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInventoryNumberOfFood.Focus();
                return false;
            }
            if (txtUnitLotOfFood.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUnitLotOfFood.Focus();
                return false;
            }
            ///
            if (txtCardName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên loại card", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCardName.Focus();
                return false;
            }
            if (cboCardCategory.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thuộc loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboCardCategory.Focus();
                return false;
            }
            if (txtPriceUnitOfCard.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPriceUnitOfCard.Focus();
                return false;
            }
            if (txtInventoryNumberOfCard.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng tồn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInventoryNumberOfCard.Focus();
                return false;
            }
            if (txtUnitLotOfCard.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUnitLotOfCard.Focus();
                return false;
            }
            //////////////////////////////////////////
            if (txtDrinkName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên loại nước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDrinkName.Focus();
                return false;
            }
            if (cboDrinkCategory.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thuộc loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboDrinkCategory.Focus();
                return false;
            }
            if (txtPriceUnitOfDrink.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPriceUnitOfDrink.Focus();
                return false;
            }
            if (txtInventoryNumberOfDrink.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng tồn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInventoryNumberOfDrink.Focus();
                return false;
            }
            if (txtUnitLotOfDrink.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUnitLotOfDrink.Focus();
                return false;
            }
            return true;
        }
        private void CategoryManageGUI_Load(object sender, EventArgs e)
        {
            if (cnn == null)
                cnn = new SqlConnection(stcnn);
            dta = new SqlDataAdapter("Select *from Category ", cnn);


            SqlCommandBuilder builder = new SqlCommandBuilder(dta);
            ds = new DataSet();
            dta.Fill(ds, "CategoryFood");
            this.cboFoodCategory.DataSource = ds.Tables["CategoryFood"];
            this.cboFoodCategory.DisplayMember = "CategoryName";
            // this.cboFoodCategory.ValueMember = "FoodID";
            dta = new SqlDataAdapter("Select *from Drink ", cnn);
            dta.Fill(ds, "CategoryDrink");
            this.cboDrinkCategory.DataSource = ds.Tables["CategoryDrink"];
            this.cboDrinkCategory.DisplayMember = "CategoryName";
            this.cboDrinkCategory.ValueMember = "DrinkID";
            dta = new SqlDataAdapter("Select *from TheCard ", cnn);
            dta.Fill(ds, "CategoryCard");
            this.cboCardCategory.DataSource = ds.Tables["CategoryCard"];
            this.cboCardCategory.DisplayMember = "CategoryName";
            this.cboCardCategory.ValueMember = "CardID";
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                try
                {

                    cmd.CommandText = "Food";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@FoodName", SqlDbType.NVarChar).Value = txtFoodName.Text;
                    cmd.Parameters.Add("@CategoryName", SqlDbType.NVarChar).Value = cboFoodCategory.Text;
                    cmd.Parameters.Add("@PriceUnit", SqlDbType.NVarChar).Value = txtPriceUnitOfFood.Text;
                    cmd.Parameters.Add("@UnitLot", SqlDbType.NVarChar).Value = txtUnitLotOfFood.Text;
                    cmd.Parameters.Add("@InventoryNumber", SqlDbType.NVarChar).Value = txtInventoryNumberOfFood.Text;

                    cmd.Connection = cnn;
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();


                    MessageBox.Show("Đã thêm món mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát chương trình?", "Tiêu đề",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            OptionGUIcs frmOption = new OptionGUIcs();
            this.Hide();
            frmOption.ShowDialog();
        }
    }
}