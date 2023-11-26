using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using library.DAL;
namespace library.BasicData
{
    public partial class jobtype : Form
    {
        public jobtype()
        {
            InitializeComponent();
        }
        bool _addnew = false;
        cl_validate _Valid = new cl_validate();
        void bindcombo()
        {
            cmb_job_type_search.DataSource = Retrivedata.executequery("sp_job_typeselectall",
                CommandType.StoredProcedure);
            cmb_job_type_search.DisplayMember = "job_name";
            cmb_job_type_search.ValueMember = "job_id";
            cmb_job_type_search.Text = "";
        }
        void bindgrid()
        {
            dgv_jobtype.DataSource = Retrivedata.executequery("sp_job_typeselectall",
                CommandType.StoredProcedure);
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد اضافة نوع وظيفة جديد", "جديد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _Valid.txtclear(this, panel_job);
                _addnew = true;
                lbl_id.Text = "0";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (_addnew == false)
            {
                MessageBox.Show("من فضلك اضغط على جديد");
                return;
            }
            if (MessageBox.Show("هل انت متاكد من حفظ نوع الوظيفة جديد", "حفظ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txt_job_type.Text == "")
                {
                    MessageBox.Show("عفوا ادخل نوع الوظيفة");
                    return;
                }
                Retrivedata.executenonquery("sp_job_typeinsert",
                    new Retrivedata.myParamter("@job_name", SqlDbType.NVarChar, txt_job_type.Text),
                    new Retrivedata.myParamter("@user_id", SqlDbType.Int, login.userid));
                MessageBox.Show("تم الحفظ");
                bindcombo();
                _Valid.txtclear(this, panel_job);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (lbl_id.Text != "0")
            {
                if (MessageBox.Show("هل انت متاكد من تعديل بيانات نوع الوظيفة ", "تعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txt_job_type.Text == "")
                    {
                        MessageBox.Show("عفوا ادخل نوع الوظيفة");
                        return;
                    }
                    Retrivedata.executenonquery("sp_job_typeupdate",
                    new Retrivedata.myParamter("@job_id", SqlDbType.Int, int.Parse(lbl_id.Text)),
                    new Retrivedata.myParamter("@job_name", SqlDbType.NVarChar, txt_job_type.Text),
                    new Retrivedata.myParamter("@user_id", SqlDbType.Int, login.userid));
                    lbl_id.Text = "0";
                    MessageBox.Show("تم التعديل");
                    bindcombo();
                    _Valid.txtclear(this, panel_job);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text != "0")
            {
                if (MessageBox.Show("هل انت متاكد من حذف نوع الوظائف", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Retrivedata.executenonquery("sp_job_typedelete", new Retrivedata.myParamter("@job_id", SqlDbType.Int, int.Parse(lbl_id.Text)));
                    lbl_id.Text = "0";
                    MessageBox.Show(" تم الحذف");
                    bindcombo();
                    _Valid.txtclear(this, panel_job);
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (cmb_job_type_search.Text != "")
            {
                DataTable dt = new DataTable();
                dt = new DataTable();
                dt = Retrivedata.executequery("sp_job_typeselectallbyid", CommandType.StoredProcedure,
                new Retrivedata.myParamter("@job_id", SqlDbType.Int, int.Parse(cmb_job_type_search.SelectedValue.ToString())));
                lbl_id.Text = dt.Rows[0]["job_id"].ToString();
                txt_job_type.Text = dt.Rows[0]["job_name"].ToString();
            }
        }

        private void jobtype_Load(object sender, EventArgs e)
        {
            bindcombo();
            bindgrid();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
