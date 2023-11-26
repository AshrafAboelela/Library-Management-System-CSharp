using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace library.DAL
{
    class Retrivedata
    {
    public static SqlConnection con = new SqlConnection(DBconnect.connection);
    public static DataTable executequery(string text,CommandType com)
    {
        SqlCommand cmd=new SqlCommand ();
        cmd.Connection=con;
        cmd.CommandType=com;
        cmd.CommandText=text;
        SqlDataAdapter da =new SqlDataAdapter(cmd);
        DataSet dt=new DataSet();
        da.Fill(dt);
      return dt.Tables[0];
    }
    public static DataTable executequery(string text, CommandType com, params myParamter[] paramarr)
    {
        SqlCommand cmd=new SqlCommand ();
        cmd.Connection=con;
        cmd.CommandType=com;
        cmd.CommandText=text;
        foreach (myParamter prm in paramarr)
    {
    	cmd.Parameters.Add(prm.pname,prm.pdtype).Value=prm.pvalue;
    }
        SqlDataAdapter da =new SqlDataAdapter(cmd);
        DataSet dt=new DataSet();
        da.Fill(dt);
      return dt.Tables[0];
    }
    public static void executenonquery(string text, CommandType com, params myParamter[] paramarr)
    {
        SqlCommand cmd=new SqlCommand ();
        cmd.Connection=con;
        cmd.CommandType=com;
        cmd.CommandText=text;
        foreach (myParamter prm in paramarr)
    {
    	cmd.Parameters.Add(prm.pname,prm.pdtype).Value=prm.pvalue;
    }
   cmd.ExecuteNonQuery();
    }
    public static  void executenonquery(string text, params myParamter[] paramarr)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = text;
        foreach (myParamter prm in paramarr)
        {
            cmd.Parameters.Add(prm.pname, prm.pdtype).Value = prm.pvalue;
        }
        try
        {
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
        }
        catch
        {
            con.Close();
        }
        
    }
    public static void fillvendors(ComboBox cmb)
    {
        cmb.DataSource = Retrivedata.executequery("sp_vendorsselectall",
              CommandType.StoredProcedure);
        cmb.DisplayMember = "ven_name";
        cmb.ValueMember = "ven_id";
        cmb.Text = "";
    }
    public static void fillstore(ComboBox cmb)
    {
        cmb.DataSource = Retrivedata.executequery("sp_store_dataselectall",
              CommandType.StoredProcedure);
        cmb.DisplayMember = "store_name";
        cmb.ValueMember = "store_id";
        cmb.Text = "";
    }
    public static void fillcust(ComboBox cmb)
    {
        cmb.DataSource = Retrivedata.executequery("sp_customersselectall",
              CommandType.StoredProcedure);
        cmb.DisplayMember = "cust_name";
        cmb.ValueMember = "cust_id";
        cmb.Text = "";
    }
    public static void fillcategory(ComboBox cmb)
    {
        cmb.DataSource = Retrivedata.executequery("sp_item_categoryselectall",
              CommandType.StoredProcedure);
        cmb.DisplayMember = "category_name";
        cmb.ValueMember = "category_id";
        cmb.Text = "";
    }
    public static void fillitems(ComboBox cmb)
    {
        cmb.DataSource = Retrivedata.executequery("sp_itemsselectall",
                CommandType.StoredProcedure);
        cmb.DisplayMember = "item_name";
        cmb.ValueMember = "item_id";
        cmb.Text = "";
    }
    public class myParamter
        {
            public string pname;
            public SqlDbType pdtype;
            public object pvalue;
            public myParamter(string pname, SqlDbType pdtype, object pvalue)
            {
                this.pname=pname;
                this.pdtype=pdtype;
                this.pvalue=pvalue;
            }
        }
    }
}
