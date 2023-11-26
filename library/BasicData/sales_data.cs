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
    public partial class sales_data : Form
    {
        public sales_data()
        {
            InitializeComponent();
        }
        bool _addnew = false;
        cl_validate _Valid = new cl_validate();
        DBconnect _con = new DBconnect();
        void bindcombo()
        {
            Retrivedata.fillcust(cmb_cust);
            Retrivedata.fillstore(cmb_store);
            Retrivedata.fillcategory(cmb_item_category);
            Retrivedata.fillitems(cmb_item);
        }
        void calcremain()
        {
            try
            {
                if (txt_payed.Text == "")
                {
                    txt_payed.Text = "0";
                }
                if (double.Parse(txt_payed.Text) > double.Parse(txt_total.Text))
                {
                    return;
                }
                txt_remain.Text = (double.Parse(txt_total.Text) - double.Parse(txt_payed.Text)).ToString();
            }
            catch (Exception) { }
        }
        void calcitemvalue()
        {
            try
            {
                if (txt_price.Text == "")
                {
                    txt_price.Text = "0";
                }
                if (txt_quantity.Text == "")
                {
                    txt_quantity.Text = "0";
                }
                txt_value.Text = (double.Parse(txt_price.Text) * double.Parse(txt_quantity.Text)).ToString();
            }
            catch (Exception) { }
        }
        void calctotalvalue()
        {
            try
            {
                if (txt_total.Text == "")
                {
                    txt_total.Text = "0";
                }
                double _total = 0;
                for (int i = 0; i < dgv_items.Rows.Count-1; i++)
                {
                    _total = (double.Parse(txt_total.Text) + double.Parse(dgv_items.Rows[i].Cells[6].Value.ToString()));
                }
                txt_total.Text = _total.ToString();
            }
            catch (Exception) { }
        }
        DataTable preparedatatable()
        {
            if (dgv_items.RowCount > 0)
            {
                DataTable dt = new DataTable();
                DataRow dr;
                dt.Columns.Add("category_id", typeof(int));
                dt.Columns.Add("item_id", typeof(int));
                dt.Columns.Add("price", typeof(decimal));
                dt.Columns.Add("quantity", typeof(int));
                dt.Columns.Add("value", typeof(decimal));
                for (int i = 0; i < dgv_items.Rows.Count-1; i++)
                {
                    dr = dt.NewRow();
                    dr[0] = dgv_items.Rows[i].Cells[0].Value.ToString();
                    dr[1] = dgv_items.Rows[i].Cells[1].Value.ToString();
                    dr[2] = dgv_items.Rows[i].Cells[4].Value.ToString();
                    dr[3] = dgv_items.Rows[i].Cells[5].Value.ToString();
                    dr[4] = dgv_items.Rows[i].Cells[6].Value.ToString();
                    dt.Rows.Add(dr);
                }
                return dt;
            }
            else
            {
                return null;
            }
        }
        private void sales_data_Load(object sender, EventArgs e)
        {
            bindcombo();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد اضافة حركة بيع", "جديد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _addnew = true;
                _Valid.txtclear(this, pnl_1);
                _Valid.txtclear(this, pnl_2);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cmb_item.Text == "")
            {
                MessageBox.Show("من فضلك اختر الصنف");
                return;
            }
            if (txt_value.Text == "")
            {
                MessageBox.Show("من فضلك ادخل السعر او الكمية");
                return;
            }
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewCell cel1 = new DataGridViewTextBoxCell();
            DataGridViewCell cel2 = new DataGridViewTextBoxCell();
            DataGridViewCell cel3 = new DataGridViewTextBoxCell();
            DataGridViewCell cel4 = new DataGridViewTextBoxCell();
            DataGridViewCell cel5 = new DataGridViewTextBoxCell();
            DataGridViewCell cel6 = new DataGridViewTextBoxCell();
            DataGridViewCell cel7 = new DataGridViewTextBoxCell();
            row.Cells.Add(cel1);
            row.Cells.Add(cel2);
            row.Cells.Add(cel3);
            row.Cells.Add(cel4);
            row.Cells.Add(cel5);
            row.Cells.Add(cel6);
            row.Cells.Add(cel7);
            row.Cells[0].Value = cmb_item_category.SelectedValue.ToString();
            row.Cells[1].Value = cmb_item.SelectedValue.ToString();
            row.Cells[2].Value = cmb_item_category.Text;
            row.Cells[3].Value = cmb_item.Text;
            row.Cells[4].Value = txt_price.Text;
            row.Cells[5].Value = txt_quantity.Text;
            row.Cells[6].Value = txt_value.Text;
            dgv_items.Rows.Add(row);
            calctotalvalue();
            calcremain();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (_addnew == true)
            {

                if (MessageBox.Show("هل انت متاكد من حفظ حركة البيع", "حفظ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (cmb_cust.Text == "")
                    {
                        MessageBox.Show("عفوا ادخل اسم العميل");
                        return;
                    }
                    if (date_sales.Text == "")
                    {
                        MessageBox.Show("عفوا اختر تاريخ البيع");
                        return;
                    }
                    if (cmb_store.Text == "")
                    {
                        MessageBox.Show("عفوا اختر المخزن");
                        return;
                    }
                    if (dgv_items.RowCount > 0)
                    {
                        DataTable dt = preparedatatable();
                        _con.cmd.Connection = DBconnect.conn;
                        _con.cmd.CommandType = CommandType.StoredProcedure;
                        _con.cmd.CommandText = "sp_main_salesinsert";
                        _con.cmd.Parameters.Clear();
                        _con.cmd.Parameters.AddWithValue("@cust_id", int.Parse(cmb_cust.SelectedValue.ToString()));
                        _con.cmd.Parameters.AddWithValue("@sales_date", date_sales.DateTime.Date);
                        _con.cmd.Parameters.AddWithValue("@total_value", txt_total.Text);
                        _con.cmd.Parameters.AddWithValue("@payed_value", txt_payed.Text);
                        _con.cmd.Parameters.AddWithValue("@remain_value", txt_remain.Text);
                        _con.cmd.Parameters.AddWithValue("@sales_notes", txt_notes.Text);
                        _con.cmd.Parameters.AddWithValue("@user_id", login.userid);
                        _con.cmd.Parameters.AddWithValue("@store_id", int.Parse(cmb_store.SelectedValue.ToString()));
                        _con.cmd.Parameters.AddWithValue("@salesdatatable", dt);
                        _con.cmd.ExecuteNonQuery();
                        MessageBox.Show("تم الحفظ");
                        _addnew = false;
                    }
                }
            }
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmb_item_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_item_category.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                cmb_item.DataSource = Retrivedata.executequery("sp_item_selectbycategory_id",
                    CommandType.StoredProcedure,
                    new Retrivedata.myParamter("@category_id", SqlDbType.Int, int.Parse(cmb_item_category.SelectedValue.ToString())));
                cmb_item.DisplayMember = "item_name";
                cmb_item.ValueMember = "item_id";
                cmb_item.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {
            calcitemvalue();
        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {
            calcitemvalue();
        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {
            calcremain();
        }

        private void txt_payed_TextChanged(object sender, EventArgs e)
        {
            calcremain();
        }
    }
}