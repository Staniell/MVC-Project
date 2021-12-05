using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace mp
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=SQL5104.site4now.net;Initial Catalog=db_a74732_anthropology;User Id=db_a74732_anthropology_admin;Password=nargacuga5");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (t_username.Text == "" || t_password.Text == "")
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Please enter a username or password');", true);

            else
            {
                bool correct_name = false;

                Borrowerx borrowerz = new Borrowerx(t_username.Text, t_password.Text);
                Operationx operation = new Operationx();
                correct_name = operation.Login(borrowerz);

                if (correct_name)
                { 
                    Session["Login_Name"] = t_username.Text;
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Logged in!');", true);
                    Response.Redirect("MainPage.aspx");
                }
                else
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Invalid username or password.');", true);
            }
        }
    }
}