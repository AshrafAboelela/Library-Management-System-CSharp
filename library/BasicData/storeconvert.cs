using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using library.DAL;
namespace library.BasicData
{
    public partial class storeconvert : Form
    {
        public storeconvert()
        {
            InitializeComponent();
        }
        bool _addnew = false;
        cl_validate _Valid = new cl_validate();
        void bindcombo()
        {
            Retrivedata.fillcategory(cmb_item_category);
            Retrivedata.fillstore(cmb_store_from);
            Retrivedata.fillstore(cmb_store_to);
            Retrivedata.fillitems(cmb_item_name);
        }
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmb_item_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_item_category.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                cmb_item_name.DataSource = Retrivedata.executequery("sp_item_selectbycategory_id",
                    CommandType.StoredProcedure,
                    new Retrivedata.myParamter("@category_id", SqlDbType.Int, int.Parse(cmb_item_category.SelectedValue.ToString())));
                cmb_item_name.DisplayMember = "item_name";
                cmb_item_name.ValueMember = "item_id";
                cmb_item_name.Text = "";
            }
        }

        private void cmb_item_category_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_store_from_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_item_name.Text != "" && cmb_store_from.Text != "")
            {
                DataTable dt = new DataTable();
                dt = new DataTable();
                //MessageBox.Show(cmb_item_name.SelectedValue.ToString());
                //MessageBox.Show(cmb_store_from.SelectedValue.ToString());
                //return;
                dt = Retrivedata.executequery("sp_store_quantityselectquantity", CommandType.StoredProcedure,
                    new Retrivedata.myParamter("@store_id", SqlDbType.Int, int.Parse(cmb_store_from.SelectedValue.ToString())),
                    new Retrivedata.myParamter("@item_id", SqlDbType.Int, int.Parse(cmb_item_name.SelectedValue.ToString())));
                txt_quantityfrom.Text = dt.Rows[0]["item_quantity"].ToString();

            }

        }

        private void txt_quantityto_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_store_to_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_item_name.Text != "" && cmb_store_to.Text != "")
            {
                DataTable dt = new DataTable();
                dt = new DataTable();
                dt = Retrivedata.executequery("sp_store_quantityselectquantity", CommandType.StoredProcedure,
                    new Retrivedata.myParamter("@item_id", SqlDbType.Int, int.Parse(cmb_item_name.SelectedValue.ToString())),
                    new Retrivedata.myParamter("@store_id", SqlDbType.Int, int.Parse(cmb_store_to.SelectedValue.ToString())));
                txt_quantityto.Text = dt.Rows[0]["item_quantity"].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           if((double.Parse(txt_quantity_convert.Text)+double.Parse(txt_quantity_converted.Text)) > double.Parse(txt_quantityfrom.Text))
           {
               MessageBox.Show(" عفوا الكمية لا تسمح");
               return;
           }
           txt_quantity_converted.Text = (double.Parse(txt_quantityto.Text) + double.Parse(txt_quantity_convert.Text)).ToString();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد اضافة سجل جديدة", "جديد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _addnew = true;
                _Valid.txtclear(this, panelControl2);
                txt_quantity_convert.Text = "0";
                txt_quantity_converted.Text = "0";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (_addnew == true)
            {
                if (MessageBox.Show("هل تريد تحويل الكمية", "تحويل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txt_quantity_converted.Text == "")
                    {
                        MessageBox.Show("عفوا اكمل البيانات");
                        return;
                    }
                    if (date_convert.Text == "")
                    {
                        MessageBox.Show("عفوا ادخل التاريخ");
                        return;
                    }
                    Retrivedata.executenonquery("sp_storeconvertinsert",
                      new Retrivedata.myParamter("@storefrom_id", SqlDbType.Int, int.Parse(cmb_store_from.SelectedValue.ToString())),
                      new Retrivedata.myParamter("@storeto_id", SqlDbType.Int, int.Parse(cmb_store_to.SelectedValue.ToString())),
                      new Retrivedata.myParamter("@item_id", SqlDbType.Int, int.Parse(cmb_item_name.SelectedValue.ToString())),
                      new Retrivedata.myParamter("@item_quantity", SqlDbType.Int, int.Parse(txt_quantity_convert.Text)),
                      new Retrivedata.myParamter("@con_date", SqlDbType.Date,date_convert.DateTime.Date),
                      new Retrivedata.myParamter("@con_notes", SqlDbType.NVarChar,txt_notes.Text),
                      new Retrivedata.myParamter("@user_id", SqlDbType.Int, login.userid));
                    MessageBox.Show("تم التحويل بنجاح");
                    _Valid.txtclear(this, panelControl2);
                    dgv_convert.Rows.Clear();
                }
            }
        }

        private void storeconvert_Load(object sender, EventArgs e)
        {
            bindcombo();
        }

        private void txt_quantityfrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_store_to_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_store_from_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void cmb_item_name_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cmb_item_category.Text == "")
            {
                MessageBox.Show("من فضلك اختر فئة الصنف");
                return;
            }
            if (cmb_item_name.Text == "")
            {
                MessageBox.Show("من فضلك اختر اسم الصنف");
                return;
            }
            if (cmb_store_from.Text == "")
            {
                MessageBox.Show("من فضلك اختر المخزن المحول منه");
                return;
            }
            if (cmb_store_to.Text == "")
            {
                MessageBox.Show("من فضلك اختر المخزن المحول اليه");
                return;
            }
            if (txt_quantity_convert.Text == "0")
            {
                MessageBox.Show("من فضلك اكتب الكمية المحولة");
                return;
            }
            if (txt_quantity_converted.Text == "0")
            {
                MessageBox.Show("من فضلك اضغط على مفتاح تحويل ");
                return;
            }
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewCell cel1 = new DataGridViewTextBoxCell();
            DataGridViewCell cel2 = new DataGridViewTextBoxCell();
            DataGridViewCell cel3 = new DataGridViewTextBoxCell();
            DataGridViewCell cel4 = new DataGridViewTextBoxCell();
            DataGridViewCell cel5 = new DataGridViewTextBoxCell();
            DataGridViewCell cel6 = new DataGridViewTextBoxCell();
            row.Cells.Add(cel1);
            row.Cells.Add(cel2);
            row.Cells.Add(cel3);
            row.Cells.Add(cel4);
            row.Cells.Add(cel5);
            row.Cells.Add(cel6);
            row.Cells[0].Value = cmb_item_name.Text;
            row.Cells[1].Value = cmb_item_category.Text;
            row.Cells[2].Value = txt_quantity_convert.Text;
            row.Cells[3].Value = cmb_store_from.Text;
            row.Cells[4].Value = cmb_store_to.Text;
            row.Cells[5].Value = date_convert.DateTime.Date;
            dgv_convert.Rows.Add(row);
        }


    }
}
