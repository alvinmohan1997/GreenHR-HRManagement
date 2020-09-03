using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B0P46V9\SQLEXPRESS;Initial Catalog=greenhr;Integrated Security=True");
        string name;

        bal b = new bal();
        managerreq mgr;
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Request.QueryString["username"];
            name = username;
            Session["UserName"] =username;
            Label1.Text = Session["UserName"] as string;

            mgr = new managerreq();
            mgr.mgrname = Label1.Text;
            List<managerreq> ls = b.record(mgr.mgrname);
            
            GridView2.DataSource = ls;
            GridView2.DataBind();

           




        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("pdtmanagerreq.aspx?username=" + name);
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

           
            Response.Redirect("pdtmanager.aspx?username=" + name);
            mgr = new managerreq();
            mgr.mgrname = Label1.Text;
            List<managerreq> ls = b.record(mgr.mgrname);

            GridView2.DataSource = ls;
            GridView2.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           
        }

        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}