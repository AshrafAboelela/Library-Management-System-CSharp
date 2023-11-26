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
    public partial class vendata : Form
    {
        public vendata()
        {
            InitializeComponent();
        }

        bool _addnew = false;
        cl_validate _Valid = new cl_validate();
        void bindcombo()
        {
            Retrivedata.fillvendors(cmb_ven_search);
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد اضافة مورد جديد", "جديد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _addnew = true;
                lbl_id.Text = "0";
                _Valid.txtclear(this, panel_vendata);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (_addnew == false)
            {
                MessageBox.Show("من فضلك اضغط على جديد");
                return;
            }
            if (MessageBox.Show("هل انت متاكد من حفظ مورد جديد", "حفظ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txt_venname.Text == "")
                {
                    MessageBox.Show("عفوا ادخل اسم المورد");
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
                Retrivedata.executenonquery("sp_vendorsinsert",
                    new Retrivedata.myParamter("@ven_name", SqlDbType.NVarChar, txt_venname.Text),
                    new Retrivedata.myParamter("@ven_address", SqlDbType.NVarChar, txt_address.Text),
                    new Retrivedata.myParamter("@ven_mobile", SqlDbType.Int, txt_mob.Text),
                    new Retrivedata.myParamter("@ven_phone", SqlDbType.Int, txt_tel.Text),
                    new Retrivedata.myParamter("@ven_notes", SqlDbType.NVarChar, txt_notes.Text),
                    new Retrivedata.myParamter("@user_id", SqlDbType.Int, login.userid));
                MessageBox.Show("تم الحفظ");
                _Valid.txtclear(this, panel_vendata);
                bindcombo();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (cmb_ven_search.Text != "")
            {
                DataTable dt = new DataTable();
                dt = new DataTable();
                dt = Retrivedata.executequery("sp_vendorsselectallbyid", CommandType.StoredProcedure,
                new Retrivedata.myParamter("@ven_id", SqlDbType.Int, int.Parse(cmb_ven_search.SelectedValue.ToString())));
                lbl_id.Text = dt.Rows[0]["ven_id"].ToString();
                txt_venname.Text = dt.Rows[0]["ven_name"].ToString();
                txt_address.Text = dt.Rows[0]["ven_address"].ToString();
                txt_mob.Text = dt.Rows[0]["ven_mobile"].ToString();
                txt_tel.Text = dt.Rows[0]["ven_phone"].ToString();
                txt_notes.Text = dt.Rows[0]["ven_notes"].ToString();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text != "0")
            {
                if (MessageBox.Show("هل انت متاكد من تعديل بيانات مورد", "تعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txt_venname.Text == "")
                    {
                        MessageBox.Show("عفوا ادخل اسم المورد");
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
                    Retrivedata.executenonquery("sp_vendorsupdate",
                    new Retrivedata.myParamter("@ven_id", SqlDbType.Int, int.Parse(lbl_id.Text)),
                    new Retrivedata.myParamter("@ven_name", SqlDbType.NVarChar, txt_venname.Text),
                    new Retrivedata.myParamter("@ven_address", SqlDbType.NVarChar, txt_address.Text),
                    new Retrivedata.myParamter("@ven_mobile", SqlDbType.Int, txt_mob.Text),
                    new Retrivedata.myParamter("@ven_phone", SqlDbType.Int, txt_tel.Text),
                    new Retrivedata.myParamter("@ven_notes", SqlDbType.NVarChar, txt_notes.Text),
                    new Retrivedata.myParamter("@user_id", SqlDbType.Int, login.userid));
                    lbl_id.Text = "0";
                    MessageBox.Show("تم التعديل");
                    _Valid.txtclear(this, panel_vendata);
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
                if (MessageBox.Show("هل انت متاكد من حذف بيانات مورد", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Retrivedata.executenonquery("sp_vendorsdelete", new Retrivedata.myParamter("@ven_id", SqlDbType.Int, int.Parse(lbl_id.Text)));
                    lbl_id.Text = "0";
                    MessageBox.Show(" تم الحذف");
                    _Valid.txtclear(this, panel_vendata);
                    bindcombo();
                }
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vendata_Load(object sender, EventArgs e)
        {
            bindcombo();
        }
    }
}
