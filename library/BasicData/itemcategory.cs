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
    public partial class itemcategory : Form
    {
        public itemcategory()
        {
            InitializeComponent();
        }
        bool _addnew = false;
        cl_validate _Valid = new cl_validate();
        void bindgrid()
        {
            dgv_search.DataSource = Retrivedata.executequery("sp_item_categoryselectall",
                CommandType.StoredProcedure);
        }
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد اضافة فئة جديدة", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txt_name.Text = "";
                _addnew = true;
                lbl_id.Text = "0";
                _Valid.txtclear(this, panelControl1);
                _Valid.txtclear(this, panelControl2);
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (_addnew == true)
            {
            if (MessageBox.Show("هل انت متاكد من حفظ فئة جديدة", "حفظ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txt_name.Text == "")
                {
                    MessageBox.Show("عفوا ادخل اسم الفئة");
                    return;
                }
                Retrivedata.executenonquery("sp_item_categoryinsert",
                  new Retrivedata.myParamter("@category_name", SqlDbType.NVarChar, txt_name.Text),
                  new Retrivedata.myParamter("@user_id", SqlDbType.Int, login.userid));
                MessageBox.Show("تم الحفظ");
                _Valid.txtclear(this, panelControl1);
                _Valid.txtclear(this, panelControl2);
                bindgrid();
            }
            }
        }

        private void itemcategory_Load(object sender, EventArgs e)
        {
            bindgrid();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text != "0")
            {
                if (MessageBox.Show("هل انت متاكد من تعديل بيانات الفئة", "تعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txt_name.Text == "")
                    {
                        MessageBox.Show("عفوا ادخل اسم الفئة");
                        return;
                    }
                    Retrivedata.executenonquery("sp_item_categoryupdate",
                   new Retrivedata.myParamter("@category_id", SqlDbType.Int, int.Parse(lbl_id.Text)),
                   new Retrivedata.myParamter("@category_name", SqlDbType.NVarChar, txt_name.Text),
                   new Retrivedata.myParamter("@user_id", SqlDbType.Int, login.userid));
                    MessageBox.Show("تم التعديل");
                    lbl_id.Text = "0";
                    _Valid.txtclear(this, panelControl1);
                    _Valid.txtclear(this, panelControl2);
                    bindgrid();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text != "0")
            {
                if (MessageBox.Show("هل انت متاكد من حذف بيانات الفئة", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Retrivedata.executenonquery("sp_item_categorydelete", new Retrivedata.myParamter("@category_id", SqlDbType.Int, int.Parse(lbl_id.Text)));
                    lbl_id.Text = "0";
                    MessageBox.Show(" تم الحذف");
                    _Valid.txtclear(this, panelControl1);
                    _Valid.txtclear(this, panelControl2);
                    bindgrid();
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgv_search_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                lbl_id.Text = gridView1.GetFocusedRowCellValue("category_id").ToString();
                txt_name.Text = gridView1.GetFocusedRowCellValue("category_name").ToString();
            }
        }
    }
}
