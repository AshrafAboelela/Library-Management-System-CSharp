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
    public partial class custdata : Form
    {
        public custdata()
        {
            InitializeComponent();
        }
        bool _addnew = false;
        cl_validate _Valid = new cl_validate();
        void bindcombo()
        {
            Retrivedata.fillcust(cmb_cust_search);

        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد اضافة عميل جديد", "جديد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _Valid.txtclear(this, pnl_custdata);
                _addnew = true;
                lbl_id.Text = "0";
                _Valid.txtclear(this, panel_custdata);  
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (_addnew == false)
            {
                MessageBox.Show("من فضلك اضغط على جديد");
                return;
            }
            if (MessageBox.Show("هل انت متاكد من حفظ عميل جديد", "حفظ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txt_custname.Text == "")
                {
                    MessageBox.Show("عفوا ادخل اسم العميل");
                    return;
                }
                if (txt_tel.Text == "")
                {
                    txt_tel.Text = "0";
                }

                if (txt_mob.Text == "")
                {
                    txt_mob.Text = "0";
                }
                Retrivedata.executenonquery("sp_customersinsert",
                    new Retrivedata.myParamter("@cust_name", SqlDbType.NVarChar, txt_custname.Text),
                    new Retrivedata.myParamter("@cust_address", SqlDbType.NVarChar, txt_address.Text),
                    new Retrivedata.myParamter("@cust_mobile", SqlDbType.Int, txt_mob.Text),
                    new Retrivedata.myParamter("@cust_phone", SqlDbType.Int, txt_tel.Text),
                    new Retrivedata.myParamter("@cust_notes", SqlDbType.NVarChar, txt_notes.Text),
                    new Retrivedata.myParamter("@user_id", SqlDbType.Int, login.userid));
                MessageBox.Show("تم الحفظ");
                _Valid.txtclear(this, pnl_custdata);
                _Valid.txtclear(this, panel_custdata);
                bindcombo();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (cmb_cust_search.Text != "")
            {
                DataTable dt = new DataTable();
                dt = new DataTable();
                dt = Retrivedata.executequery("sp_customersselectbyid", CommandType.StoredProcedure,
                    new Retrivedata.myParamter("@cust_id", SqlDbType.Int, int.Parse(cmb_cust_search.SelectedValue.ToString())));
                lbl_id.Text = dt.Rows[0]["cust_id"].ToString();
                txt_custname.Text = dt.Rows[0]["cust_name"].ToString();
                txt_address.Text = dt.Rows[0]["cust_address"].ToString();
                txt_mob.Text = dt.Rows[0]["cust_mobile"].ToString();
                txt_tel.Text = dt.Rows[0]["cust_phone"].ToString();
                txt_notes.Text = dt.Rows[0]["cust_notes"].ToString();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text != "0")
            {
                if (MessageBox.Show("هل انت متاكد من تعديل بيانات عميل", "تعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txt_custname.Text == "")
                    {
                        MessageBox.Show("عفوا ادخل اسم العميل");
                        return;
                    }
                    if (txt_tel.Text == "")
                    {
                        txt_tel.Text = "0";
                    }

                    if (txt_mob.Text == "")
                    {
                        txt_mob.Text = "0";
                    }
                    Retrivedata.executenonquery("sp_customersupdate",
                       new Retrivedata.myParamter("@cust_id", SqlDbType.Int, int.Parse(lbl_id.Text)),
                       new Retrivedata.myParamter("@cust_name", SqlDbType.NVarChar, txt_custname.Text),
                       new Retrivedata.myParamter("@cust_address", SqlDbType.NVarChar, txt_address.Text),
                       new Retrivedata.myParamter("@cust_mobile", SqlDbType.Int, txt_mob.Text),
                       new Retrivedata.myParamter("@cust_phone", SqlDbType.Int, txt_tel.Text),
                       new Retrivedata.myParamter("@cust_notes", SqlDbType.NVarChar, txt_notes.Text),
                       new Retrivedata.myParamter("@user_id", SqlDbType.Int, login.userid));
                    lbl_id.Text = "0";
                    MessageBox.Show("تم التعديل");
                    _Valid.txtclear(this, pnl_custdata);
                    _Valid.txtclear(this, panel_custdata);
                    bindcombo();
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text != "0")
            {
                if (MessageBox.Show("هل انت متاكد من حذف بيانات عميل", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Retrivedata.executenonquery("sp_customersdelete", new Retrivedata.myParamter("@cust_id", SqlDbType.Int, int.Parse(lbl_id.Text)));
                    lbl_id.Text = "0";
                    MessageBox.Show(" تم الحذف");
                    _Valid.txtclear(this, pnl_custdata);
                    _Valid.txtclear(this, panel_custdata);
                    bindcombo();
                }
            }
        }

        private void pnl_custdata_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmb_cust_search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void custdata_Load(object sender, EventArgs e)
        {
            bindcombo();
        }
    }
}