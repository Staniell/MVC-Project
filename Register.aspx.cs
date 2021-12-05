using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace mp
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        //SqlConnection con = new SqlConnection("Data Source=SQL5104.site4now.net;Initial Catalog=db_a74732_anthropology;User Id=db_a74732_anthropology_admin;Password=nargacuga5");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(username.Text == "" || phone_no.Text == "" || email.Text == "" || passcode.Text == "")
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Please fill out every information needed');", true);
            else
            {
                if (username.Text.StartsWith("admin_"))
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('The username admin_ is exclusive for employees. Please enter another username');", true);
                else
                {
                    try
                    {
                        Borrowerx borrower = new Borrowerx(username.Text, phone_no.Text, email.Text, passcode.Text);
                        Operationx operationz = new Operationx();
                        operationz.Register(borrower);

                        ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Account logged in and registered!');", true);
                        Session["Login_Name"] = username.Text;
                        Response.Redirect("MainPage.aspx");
                    }
                    catch
                    {
                        ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Username is already taken. Please enter another username');", true);
                    }
                }
            }
        }
    }
}