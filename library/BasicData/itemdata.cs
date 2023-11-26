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
    public partial class itemdata : Form
    {
        public itemdata()
        {
            InitializeComponent();
        }
        bool _addnew = false;
        cl_validate _Valid = new cl_validate();
        void bindcombo()
        {
            cmb_item_category.DataSource = Retrivedata.executequery("sp_item_categoryselectall",
                CommandType.StoredProcedure);
            cmb_item_category.DisplayMember = "category_name";
            cmb_item_category.ValueMember = "category_id";
            cmb_item_category.Text = "";
        }
        void binditemcombo()
        {
            cmb_item_search.DataSource = Retrivedata.executequery("sp_itemsselectall",
                CommandType.StoredProcedure);
            cmb_item_search.DisplayMember = "item_name";
            cmb_item_search.ValueMember = "item_id";
            cmb_item_search.Text = "";
        }
        void bindgrid()
        {
            dgv_item_category.DataSource = Retrivedata.executequery("sp_itemsselectallbycategory_id",
                CommandType.StoredProcedure);
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (_addnew == true)
            {
                if (MessageBox.Show("هل انت متاكد من حفظ صنف جديد", "حفظ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txt_mini.Text == "")
                    {
                        MessageBox.Show("عفوا ادخل الحد الادنى");
                        return;
                    }
                    if (txt_name_item.Text == "")
                    {
                        MessageBox.Show("عفوا ادخل اسم الصنف");
                        return;
                    }
                    if (cmb_item_category.Text == "")
                    {
                        MessageBox.Show("عفوا اختر فئة الصنف");
                        return;
                    }
                    Retrivedata.executenonquery("sp_itemsinsert",
                      new Retrivedata.myParamter("@item_name", SqlDbType.NVarChar, txt_name_item.Text),
                      new Retrivedata.myParamter("@category_id", SqlDbType.Int,int.Parse(cmb_item_category.SelectedValue.ToString())),
                      new Retrivedata.myParamter("@item_mini", SqlDbType.Int,int.Parse(txt_mini.Text)),
                      new Retrivedata.myParamter("@user_id", SqlDbType.Int, login.userid));
                    MessageBox.Show("تم الحفظ");
                    _Valid.txtclear(this, panelControl1);
                    _Valid.txtclear(this, panelControl2);
                    _addnew = true;
                    bindcombo();
                    bindgrid();
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text != "0")
            {
                if (MessageBox.Show("هل انت متاكد من تعديل صنف", "تعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txt_name_item.Text == "")
                    {
                        MessageBox.Show("من فضلك ادخل اسم الصنف");
                        return;
                    }
                    if (txt_mini.Text == "")
                    {
                        MessageBox.Show("من فضلك ادخل الحد الادنى الصنف");
                        return;
                    }

                    if (cmb_item_category.Text == "")
                    {
                        MessageBox.Show("من فضلك اختر فئة الصنف");
                        return;
                    }

                    Retrivedata.executenonquery("sp_itemssupdate",
                      new Retrivedata.myParamter("@item_id", SqlDbType.Int,int.Parse(lbl_id.Text)),
                       new Retrivedata.myParamter("@item_name", SqlDbType.NVarChar, txt_name_item.Text),
                       new Retrivedata.myParamter("@category_id", SqlDbType.Int,int.Parse(cmb_item_category.SelectedValue.ToString())),
                      new Retrivedata.myParamter("@item_mini", SqlDbType.Int,int.Parse(txt_mini.Text)),
                      new Retrivedata.myParamter("@user_id", SqlDbType.Int, login.userid));
                    lbl_id.Text = "0";
                    MessageBox.Show("تم التعديل");
                      _addnew = false;
                    _Valid.txtclear(this, panelControl1);
                    _Valid.txtclear(this, panelControl2);
                    bindcombo();
                    bindgrid();
        }
     }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text != "0")
            {
                if (MessageBox.Show("هل انت متاكد من حذف الصنف", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Retrivedata.executenonquery("sp_itemsdelete", new Retrivedata.myParamter("@item_id", SqlDbType.Int, int.Parse(lbl_id.Text)));
                    lbl_id.Text = "0";
                    MessageBox.Show(" تم الحذف");
                     _addnew = false;
                     lbl_id.Text = "0";
                    _Valid.txtclear(this, panelControl1);
                    _Valid.txtclear(this, panelControl2);
                    bindcombo();
                    bindgrid();
                    binditemcombo();
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد اضافة صنف جديدة", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _addnew = true;
                lbl_id.Text = "0";
                _Valid.txtclear(this, panelControl1);
                _Valid.txtclear(this, panelControl2);
            }
        }

        private void dgv_item_category_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void itemdata_Load(object sender, EventArgs e)
        {
            bindcombo();
            bindgrid();
            binditemcombo();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (cmb_item_search.Text != "")
            {
                DataTable dt = new DataTable();
                dt = new DataTable();
                dt = Retrivedata.executequery("sp_itemsselectallbyid", CommandType.StoredProcedure,
                    new Retrivedata.myParamter("@item_id", SqlDbType.Int, int.Parse(cmb_item_search.SelectedValue.ToString())));
                lbl_id.Text = dt.Rows[0]["item_id"].ToString();
                txt_name_item.Text = dt.Rows[0]["item_name"].ToString();
                txt_mini.Text = dt.Rows[0]["item_mini"].ToString();
                cmb_item_category.SelectedValue = dt.Rows[0]["category_id"];
            }
        }
    }
}
