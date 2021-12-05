using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mp
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["search_book"] != null)
            {
                SqlDataSource1.SelectCommand = $"select * from books where Book_Name like '{Session["search_book"].ToString()}'";
            }
            else
                SqlDataSource1.SelectCommand = "SELECT[Book_ID], [Book_Name], [Genre], [Fee] FROM[Books]";
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            if (Session["Login_Name"] != null)
            {
                DateTime acc_created;
                int indexrow = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;

                DB_Ops dbp = new DB_Ops();
                acc_created = dbp.get_acc_creation(Session["Login_Name"].ToString());

                book_borrow borrow = new book_borrow();
                borrow.Borrower_creation = acc_created;
                borrow.Book_id = Convert.ToInt32(GridView1.Rows[indexrow].Cells[0].Text);
                //borrow.Book_name = GridView1.Rows[indexrow].Cells[1].Text;

                borrow.Book_fee = Int32.Parse(GridView1.Rows[indexrow].Cells[3].Text);
                borrow.Borrower_name = Session["Login_Name"].ToString();



                borrow_Ops b_op = new borrow_Ops();
                if(b_op.check_if_borrowed(borrow.Borrower_name, borrow.Book_id))
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('This item is already borrowed.');", true);
                else
                    b_op.borrow_book(borrow);
            }
            else
                Response.Redirect("LogIn.aspx");

        }


    }
}