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
    public partial class ven_account_data : Form
    {
        public ven_account_data()
        {
            InitializeComponent();
        }
        bool _addnew = false;
        cl_validate _Valid = new cl_validate();
        void bindcombo()
        {
            Retrivedata.fillvendors(cmb_search);
        }
private void btn_new_Click(object sender, EventArgs e)
        {
    if (MessageBox.Show("هل تريد سداد مبلغ مورد", "جديد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
        _addnew = true;
        _Valid.txtclear(this, pnl_1);
    }
}

 private void btn_save_Click(object sender, EventArgs e)
 {
            if (_addnew == true)
            {
                if (MessageBox.Show("هل انت متاكد من الحفظ", "حفظ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txt_payed.Text != "")
                    {
                        if (double.Parse(txt_payed.Text) > double.Parse(txt_remain.Text))
                        {
                            MessageBox.Show("عفوا المبلغ المدفوع اكبر من المبلغ المتبقى");
                            return;
                        }
                    }
                    if (txt_payed.Text == "")
                    {
                        MessageBox.Show("ادخل المبلغ المدفوع");
                        return;
                    }
                    if (txt_remain.Text == "0")
                    {
                        MessageBox.Show("لا يوجد مبلغ متبقى على المورد");
                        return;
                    }
                    if (date_convert.Text == "")
                    {
                        MessageBox.Show("من فضلك ادخل تاريخ السداد");
                        return;
                    }
                    Retrivedata.executenonquery("sp_ven_accountsinsert",
                       new Retrivedata.myParamter("@ven_id", SqlDbType.Int, int.Parse(cmb_search.SelectedValue.ToString())),
                       new Retrivedata.myParamter("@payed_value", SqlDbType.Decimal, txt_payed.Text),
                       new Retrivedata.myParamter("@payed_date", SqlDbType.Date, date_convert.DateTime.Date),
                       new Retrivedata.myParamter("@account_notes", SqlDbType.NVarChar, txt_notes.Text),
                       new Retrivedata.myParamter("@user_id", SqlDbType.Int, login.userid));
                    MessageBox.Show("تم الحفظ");
                    _Valid.txtclear(this, pnl_1);
                    _addnew = false;
                }
            }
        }
private void simpleButton1_Click(object sender, EventArgs e)
{

    if (cmb_search.Text != "")
    {
        DataTable dt = new DataTable();
        dt = Retrivedata.executequery("sp_vendorsselectallbyid", CommandType.StoredProcedure,
            new Retrivedata.myParamter("@ven_id", SqlDbType.Int, int.Parse(cmb_search.SelectedValue.ToString())));
        txt_remain.Text = dt.Rows[0]["ven_debit"].ToString();
    }
      
}

 private void ven_account_data_Load(object sender, EventArgs e)
{
    bindcombo();
}

 private void btn_close_Click(object sender, EventArgs e)
 {
     this.Dispose();
 }

   }
}

       

        
