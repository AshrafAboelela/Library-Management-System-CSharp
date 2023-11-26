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
    public partial class empdata : Form
    {
        bool _addnew = false;
        cl_validate _Valid = new cl_validate();
        void bindcombo()
        {
            cmb_emp_search.DataSource = Retrivedata.executequery("sp_employeesselectall",
                CommandType.StoredProcedure);
            cmb_emp_search.DisplayMember = "emp_name";
            cmb_emp_search.ValueMember = "emp_id";
            cmb_emp_search.Text = "";
        }
        void bindcombo1()
        {
            cmb_emptype.DataSource = Retrivedata.executequery("sp_job_typeselectall",
                CommandType.StoredProcedure);
            cmb_emptype.DisplayMember = "job_name";
            cmb_emptype.ValueMember = "job_id";
            cmb_emptype.Text = "";
        }
        public empdata()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد اضافة موظف جديد", "جديد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _Valid.txtclear(this, pnl_empdata);
                _addnew = true;
                lbl_id.Text = "0";
                _Valid.txtclear(this, panel_emp_data); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_addnew == false)
            {
                MessageBox.Show("من فضلك اضغط على جديد");
                return;
            }

            if (MessageBox.Show("هل انت متاكد من حفظ موظف جديد", "حفظ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txt_empname.Text == "")
                {
                    MessageBox.Show("عفوا ادخل اسم الموظف");
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
                Retrivedata.executenonquery("sp_employeesinsert",
                   new Retrivedata.myParamter("@emp_name", SqlDbType.NVarChar, txt_empname.Text),
                   new Retrivedata.myParamter("@job_id", SqlDbType.Int, int.Parse(cmb_emptype.SelectedValue.ToString())),
                   new Retrivedata.myParamter("@emp_address", SqlDbType.NVarChar, txt_address.Text),
                   new Retrivedata.myParamter("@emp_mobile", SqlDbType.Int, txt_mob.Text),
                   new Retrivedata.myParamter("@emp_phone", SqlDbType.Int, txt_tel.Text),
                   new Retrivedata.myParamter("@emp_personal_id", SqlDbType.NVarChar, txt_idno.Text),
                   new Retrivedata.myParamter("@emp_salary", SqlDbType.NVarChar, txt_salary.Text),
                   new Retrivedata.myParamter("@user_id", SqlDbType.Int, login.userid));
                  MessageBox.Show("تم الحفظ");
                _Valid.txtclear(this, pnl_empdata);
                _Valid.txtclear(this, panel_emp_data);
                bindcombo();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (cmb_emp_search.Text != "")
            {
                DataTable dt = new DataTable();
                dt = new DataTable();
                dt = Retrivedata.executequery("sp_employeesselectbyid", CommandType.StoredProcedure,
                    new Retrivedata.myParamter("@emp_id", SqlDbType.Int, int.Parse(cmb_emp_search.SelectedValue.ToString())));
                lbl_id.Text = dt.Rows[0]["emp_id"].ToString();
                txt_empname.Text = dt.Rows[0]["emp_name"].ToString();
                txt_address.Text = dt.Rows[0]["emp_address"].ToString();
                txt_mob.Text = dt.Rows[0]["emp_mobile"].ToString();
                txt_tel.Text = dt.Rows[0]["emp_phone"].ToString();
                txt_idno.Text = dt.Rows[0]["personal_id"].ToString();
                txt_salary.Text = dt.Rows[0]["basic_salary"].ToString();
                cmb_emptype.SelectedValue = dt.Rows[0]["job_id"];
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text != "0")
            {
                if (MessageBox.Show("هل انت متاكد من تعديل بيانات الموظف", "تعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txt_empname.Text == "")
                    {
                        MessageBox.Show("عفوا ادخل اسم الموظف");
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
                    Retrivedata.executenonquery("sp_employeesupdate",
                       new Retrivedata.myParamter("@emp_id", SqlDbType.Int, int.Parse(lbl_id.Text)),
                       new Retrivedata.myParamter("@job_id", SqlDbType.Int, int.Parse(cmb_emptype.SelectedValue.ToString())),
                       new Retrivedata.myParamter("@emp_name", SqlDbType.NVarChar, txt_empname.Text),
                       new Retrivedata.myParamter("@emp_address", SqlDbType.NVarChar, txt_address.Text),
                       new Retrivedata.myParamter("@emp_mobile", SqlDbType.Int, txt_mob.Text),
                       new Retrivedata.myParamter("@emp_phone", SqlDbType.Int, txt_tel.Text),
                       new Retrivedata.myParamter("@emp_personal_id", SqlDbType.NVarChar, txt_idno.Text),
                       new Retrivedata.myParamter("@emp_salary", SqlDbType.NVarChar, txt_salary.Text),
                       new Retrivedata.myParamter("@user_id", SqlDbType.Int, login.userid));
                    txt_tel.Text = "0";
                    MessageBox.Show("تم التعديل");
                    _Valid.txtclear(this, pnl_empdata);
                    _Valid.txtclear(this, panel_emp_data);
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
                if (MessageBox.Show("هل انت متاكد من حذف بيانات الموظف", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Retrivedata.executenonquery("sp_employeesdelete", new Retrivedata.myParamter("@emp_id", SqlDbType.Int, int.Parse(lbl_id.Text)));
                    lbl_id.Text = "0";
                    MessageBox.Show(" تم الحذف");
                    _Valid.txtclear(this, pnl_empdata);
                    _Valid.txtclear(this, panel_emp_data);
                    bindcombo();
                }
            }
        }

        private void empdata_Load(object sender, EventArgs e)
        {
            bindcombo();
            bindcombo1();
        }
    }
}
