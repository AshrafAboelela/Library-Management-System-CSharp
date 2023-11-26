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
    public partial class cust_account_popup : Form
    {
        public cust_account_popup()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cust_account_popup_Load(object sender, EventArgs e)
        {
            dgv_search.DataSource = Retrivedata.executequery("sp_custaccountall",
                CommandType.StoredProcedure);
        }
    }
}
