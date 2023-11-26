using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using library.BasicData;
namespace library
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            custdata cust = new custdata();
            cust.MdiParent = this;
            cust.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            empdata emp = new empdata();
            emp.MdiParent = this;
            emp.Show();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            distributeitems dis = new distributeitems();
            dis.MdiParent = this;
            dis.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            jobtype jobt = new jobtype();
            jobt.MdiParent = this;
            jobt.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            itemcategory itemcat = new itemcategory();
            itemcat.MdiParent = this;
            itemcat.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            itemdata itemd = new itemdata();
            itemd.MdiParent = this;
            itemd.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            storedata sdata = new storedata();
            sdata.MdiParent = this;
            sdata.Show();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            storeconvert scon = new storeconvert();
            scon.MdiParent = this;
            scon.Show();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            purchases_data purch = new purchases_data();
            purch.MdiParent = this;
            purch.Show();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            sales_data sal = new sales_data();
            sal.MdiParent = this;
            sal.Show();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            cust_account_data cust_ac = new cust_account_data();
            cust_ac.MdiParent = this;
            cust_ac.Show();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            ven_account_data ven_ac = new ven_account_data();
            ven_ac.MdiParent = this;
            ven_ac.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            cust_account_popup cust_ac_pop = new cust_account_popup();
            cust_ac_pop.MdiParent = this;
            cust_ac_pop.Show();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            ven_account_popup ven_ac_pop = new ven_account_popup();
            ven_ac_pop.MdiParent = this;
            ven_ac_pop.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            vendata ven = new vendata();
            ven.MdiParent = this;
            ven.Show();
        }
    }
}