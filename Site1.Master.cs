using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mp
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login_Name"] != null)
                Logz.Text = "Log Out";
            else
            {
                acc.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["search_book"] = search_txt.Text;
            Response.Redirect("Books.aspx");
            
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            Session.Remove("search_book");
            Response.Redirect("Books.aspx");
        }
    }
}