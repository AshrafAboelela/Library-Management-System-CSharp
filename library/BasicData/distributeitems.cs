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
    public partial class distributeitems : Form
    {
        public distributeitems()
        {
            InitializeComponent();
        }
        cl_validate _Valid = new cl_validate();
        DBconnect _con = new DBconnect();
        void bindcombo()
        {
            cmb_store.DataSource = Retrivedata.executequery("sp_store_dataselectall",
                CommandType.StoredProcedure);
            cmb_store.DisplayMember = "store_name";
            cmb_store.ValueMember = "store_id";
            cmb_store.Text = "";
            cmb_item.DataSource = Retrivedata.executequery("sp_itemsselectall",
               CommandType.StoredProcedure);
            cmb_item.DisplayMember = "item_name";
            cmb_item.ValueMember = "item_id";
            cmb_item.Text = "";
        }
        DataTable preparedatatable()
        {
            if(dgv_items.RowCount > 0)
            {
                DataTable dt = new DataTable();
                DataRow dr;
                dt.Columns.Add("store_id", typeof(int));
                dt.Columns.Add("item_id", typeof(int));
                for (int i=0; i<dgv_items.Rows.Count-1; i++)
                {
                    dr = dt.NewRow();
                    dr[0] = dgv_items.Rows[i].Cells[0].Value.ToString();
                    dr[1] = dgv_items.Rows[i].Cells[1].Value.ToString();
                    dt.Rows.Add(dr);
                }
                return dt;
            }
            else
            {
                return null;
            }
        }
        private void distributeitems_Load(object sender, EventArgs e)
        {
            bindcombo();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cmb_item.Text == "")
            {
                MessageBox.Show("من فضلك اختر الصنف");
                return;
            }
            if (cmb_store.Text == "")
            {
                MessageBox.Show("من فضلك اختر المخزن");
                return;
            }
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewCell cel1 = new DataGridViewTextBoxCell();
            DataGridViewCell cel2 = new DataGridViewTextBoxCell();
            DataGridViewCell cel3 = new DataGridViewTextBoxCell();
            DataGridViewCell cel4 = new DataGridViewTextBoxCell();
            row.Cells.Add(cel1);
            row.Cells.Add(cel2);
            row.Cells.Add(cel3);
            row.Cells.Add(cel4);
            row.Cells[0].Value = cmb_store.SelectedValue.ToString();
            row.Cells[1].Value = cmb_item.SelectedValue.ToString();
            row.Cells[2].Value = cmb_store.Text;
            row.Cells[3].Value = cmb_item.Text;
            dgv_items.Rows.Add(row);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DataTable dt = preparedatatable();
            _con.cmd.Connection = DBconnect.conn;
            _con.cmd.CommandType = CommandType.StoredProcedure;
            _con.cmd.CommandText = "sp_store_quantityinsert";
            _con.cmd.Parameters.AddWithValue("@user_id", login.userid);
            _con.cmd.Parameters.AddWithValue("@distributeitems", dt);
            _con.cmd.ExecuteNonQuery();
            MessageBox.Show("تم الحفظ");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_distribute_Click(object sender, EventArgs e)
        {
            Retrivedata.executenonquery("sp_distributeitems_auto",
            new Retrivedata.myParamter("@user_id", SqlDbType.Int,login.userid));
              MessageBox.Show("تم التوزيع بنجاح");
        }
    }
}
