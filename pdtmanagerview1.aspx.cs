using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace WebApplication1
{
    public partial class pdtmanagerview1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = (DataSet)Session["req"];
            Label1.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            Label2.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            Label3.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            Label4.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            Label5.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            Label6.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
            Label7.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
            Label8.Text = ds.Tables[0].Rows[0].ItemArray[7].ToString();
            Label9.Text = ds.Tables[0].Rows[0].ItemArray[8].ToString();
            Label10.Text = ds.Tables[0].Rows[0].ItemArray[9].ToString();
            Label11.Text = ds.Tables[0].Rows[0].ItemArray[10].ToString();
            Label12.Text = ds.Tables[0].Rows[0].ItemArray[11].ToString();
        }
    }
}