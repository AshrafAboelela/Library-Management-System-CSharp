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
    public partial class storedata : Form
    {
        public storedata()
        {
            InitializeComponent();
        }
        bool _addnew = false;
        cl_validate _Valid = new cl_validate();
        void bindempcombo()
        {
            cmb_emp.DataSource = Retrivedata.executequery("sp_employeesselectall",
                CommandType.StoredProcedure);
            cmb_emp.DisplayMember = "emp_name";
            cmb_emp.ValueMember = "emp_id";
            cmb_emp.Text = "";
        }
        void bindstorecombo()
        {
            cmb_store_search.DataSource = Retrivedata.executequery("sp_store_dataselectall",
                CommandType.StoredProcedure);
            cmb_store_search.DisplayMember = "store_name";
            cmb_store_search.ValueMember = "store_id";
            cmb_store_search.Text = "";
        }
        void bindgrid()
        {
            dgv_store.DataSource = Retrivedata.executequery("sp_store_dataselectall",
                CommandType.StoredProcedure);
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد اضافة مخزن جديد", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _addnew = true;
                _Valid.txtclear(this, pnl_data);
                lbl_id.Text = "0";
            }
           
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (_addnew == true)
            {
                if (MessageBox.Show("هل انت متاكد من حفظ بيانات مخزن جديد", "حفظ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txt_store_name.Text == "")
                    {
                        MessageBox.Show("عفوا ادخل اسم المخزن");
                        return;
                    }
                    if (txt_store_address.Text == "")
                    {
                        MessageBox.Show("عفوا ادخل عنوان المخزن");
                        return;
                    }
                    if (cmb_emp.Text == "")
                    {
                        MessageBox.Show("عفوا اختر اسم الموظف");
                        return;
                    }
                    Retrivedata.executenonquery("sp_store_datainsert",
                      new Retrivedata.myParamter("@store_name", SqlDbType.NVarChar, txt_store_name.Text),
                      new Retrivedata.myParamter("@store_address", SqlDbType.NVarChar, txt_store_address.Text),
                      new Retrivedata.myParamter("@store_notes", SqlDbType.NVarChar, txt_store_notes.Text),
                      new Retrivedata.myParamter("@emp_id", SqlDbType.Int, int.Parse(cmb_emp.SelectedValue.ToString())),
                      new Retrivedata.myParamter("@user_id", SqlDbType.Int, login.userid));
                    MessageBox.Show("تم الحفظ");
                    _Valid.txtclear(this, pnl_data);
                    _addnew = true;
                    bindgrid();
                    bindstorecombo();
                }
            }
        }

        private void storedata_Load(object sender, EventArgs e)
        {
            bindempcombo();
            bindgrid();
            bindstorecombo();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text != "0")
            {
                if (MessageBox.Show("هل انت متاكد من تعديل مخزن", "تعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txt_store_name.Text == "")
                    {
                        MessageBox.Show("عفوا ادخل اسم المخزن");
                        return;
                    }
                    if (txt_store_address.Text == "")
                    {
                        MessageBox.Show("عفوا ادخل عنوان المخزن");
                        return;
                    }
                    if (cmb_emp.Text == "")
                    {
                        MessageBox.Show("عفوا اختر اسم الموظف");
                        return;
                    }
                    Retrivedata.executenonquery("sp_store_dataupdate",
                      new Retrivedata.myParamter("@store_id", SqlDbType.Int, int.Parse(lbl_id.Text)),
                      new Retrivedata.myParamter("@store_name", SqlDbType.NVarChar, txt_store_name.Text),
                      new Retrivedata.myParamter("@store_address", SqlDbType.NVarChar, txt_store_address.Text),
                      new Retrivedata.myParamter("@store_notes", SqlDbType.NVarChar, txt_store_notes.Text),
                      new Retrivedata.myParamter("@emp_id", SqlDbType.Int, int.Parse(cmb_emp.SelectedValue.ToString())),
                      new Retrivedata.myParamter("@user_id", SqlDbType.Int, login.userid));
                    lbl_id.Text = "0";
                    MessageBox.Show("تم التعديل");
                    _addnew = false;
                    _Valid.txtclear(this, pnl_data);
                    bindgrid();
                    bindstorecombo();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text != "0")
            {
                if (MessageBox.Show("هل انت متاكد من حذف المخزن", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Retrivedata.executenonquery("sp_store_datadelete", new Retrivedata.myParamter("@store_id", SqlDbType.Int, int.Parse(lbl_id.Text)));
                    lbl_id.Text = "0";
                    MessageBox.Show(" تم الحذف");
                    _addnew = false;
                    lbl_id.Text = "0";
                    _Valid.txtclear(this, pnl_data);
                    bindgrid();
                    bindstorecombo();
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (cmb_store_search.Text != "")
            {
                DataTable dt = new DataTable();
                dt = new DataTable();
                dt = Retrivedata.executequery("sp_store_dataselectallbyid", CommandType.StoredProcedure,
                    new Retrivedata.myParamter("@store_id", SqlDbType.Int, int.Parse(cmb_store_search.SelectedValue.ToString())));
                lbl_id.Text = dt.Rows[0]["store_id"].ToString();
                txt_store_name.Text = dt.Rows[0]["store_name"].ToString();
                txt_store_address.Text = dt.Rows[0]["store_address"].ToString();
                txt_store_notes.Text = dt.Rows[0]["store_notes"].ToString();
                cmb_emp.SelectedValue = dt.Rows[0]["emp_id"];
            }

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
