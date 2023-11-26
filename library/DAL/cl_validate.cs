using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace library.DAL
{
    class cl_validate
    {
        public void txtclear(Form frm,DevExpress.XtraEditors.PanelControl pnl)
        {
            foreach (Control item in frm.Controls)
            {
                if(item is DevExpress.XtraEditors.PanelControl)
                {
                    foreach (Control itemgroup in pnl.Controls)
                    {
                        if(itemgroup is DevExpress.XtraEditors.TextEdit)
                        {
                            itemgroup.Text = "";
                        }
                        if (itemgroup is TextBox)
                        {
                            itemgroup.Text = "";
                        }
                        if (itemgroup is ComboBox)
                        {
                            itemgroup.Text = "";
                        }
                    }
                }
            }
        }
    }
}
