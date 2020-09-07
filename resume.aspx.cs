using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class resume : System.Web.UI.Page
    {
        string username,username1;
        protected void Page_Load(object sender, EventArgs e)
        {
            string applid = Request.QueryString["applid"];
            username  = applid;
            Session["UserName"] = username;
            Label1.Text = Session["UserName"] as string;

            string candid = Request.QueryString["candid"];
            username1 = candid;
            Session["UserName1"] = username1;
            Label2.Text = Session["UserName1"] as string;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}