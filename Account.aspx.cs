using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace mp
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login_Name"] == null)
            {
                Response.Redirect("LogIn.aspx");
            }
            else
            {
                DataShow();
            }

            foreach (GridViewRow G_Item in GridView1.Rows)
            {
                if (G_Item.Cells[4].Text == "1/1/1900 12:00:00 AM")
                    G_Item.Cells[4].Text = "";
                if (G_Item.Cells[5].Text == "1/1/1900 12:00:00 AM")
                    G_Item.Cells[5].Text = "";

            }

        }

        //protected void return_button_Click(object sender, EventArgs e)
        //{
        //    int indexrow = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
        //    if (GridView1.Rows[indexrow].Cells[2].Text == "pending")
        //        ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('This item is still on pending status.');", true);
        //    else if (GridView1.Rows[indexrow].Cells[2].Text == "returned" || GridView1.Rows[indexrow].Cells[2].Text == "paid")
        //        ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('This item is already returned.');", true);
        //    else
        //    {
        //        book_borrow borrow = new book_borrow();
        //        borrow.Borrower_name = Session["Login_Name"].ToString();
        //        borrow.Return_time = DateTime.Now;
        //        borrow.Book_id = Int32.Parse(GridView1.Rows[indexrow].Cells[0].Text);

        //        borrow_Ops bo = new borrow_Ops();
        //        bo.return_book(borrow);
        //        DataShow();
        //    }

        //}

        //protected void pay_button_Click(object sender, EventArgs e)
        //{
        //    int indexrow = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
        //    if (GridView1.Rows[indexrow].Cells[2].Text == "pending")
        //        ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('This item is still on pending status.');", true);
        //    else if (GridView1.Rows[indexrow].Cells[2].Text == "paid")
        //        ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('This item is already paid.');", true);
        //    else
        //    {
        //        book_borrow borrow = new book_borrow();
        //        borrow.Borrower_name = Session["Login_Name"].ToString();
        //        borrow.Pay_time = DateTime.Now;
        //        borrow.Book_id = Int32.Parse(GridView1.Rows[indexrow].Cells[0].Text);

        //        borrow_Ops bo = new borrow_Ops();
        //        bo.pay_book(borrow);
        //        DataShow();
        //    }
        //}

        protected void emailbutton_Click(object sender, EventArgs e)
        {
            if (emailtext.Text == "")
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Please enter a new email.');", true);
            else
            {
                Borrowerx borrower = new Borrowerx(Session["Login_Name"].ToString());
                Operationx ops = new Operationx();
                ops.changeEmail(borrower, emailtext.Text.ToString());
                DataShow();
            }
        }

        protected void phone_button_Click(object sender, EventArgs e)
        {
            if (phonetext.Text == "")
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Please enter a new phone number.');", true);
            else
            {
                Borrowerx borrower = new Borrowerx(Session["Login_Name"].ToString());
                Operationx ops = new Operationx();
                ops.changeNumber(borrower, phonetext.Text.ToString());
                DataShow();
            }
        }

        protected void passbutton_Click(object sender, EventArgs e)
        {
            if (passtext.Text == "")
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('Please enter a new password.');", true);
            else
            {
                Borrowerx borrower = new Borrowerx(Session["Login_Name"].ToString());
                Operationx ops = new Operationx();
                ops.changePass(borrower, passtext.Text.ToString());
                DataShow();
            }
        }

        protected void deactivate_button_Click(object sender, EventArgs e)
        {
            Borrowerx borrower = new Borrowerx(Session["Login_Name"].ToString());
            Operationx ops = new Operationx();
            ops.Deactivate(borrower);
            DataShow();
        }

        void DataShow()
        {
            SqlDataSource2.SelectCommand = "select Account_Created, borrower_name, phone_number, Borrower_Email, Borrower_Password from Reg_Accounts where borrower_name = '" + Session["Login_Name"].ToString() + "'";
            SqlDataSource1.SelectCommand = "select book_name,books.book_id, borrower_name, date_borrowed, date_return, status, date_paid, books.fee from borrow_list inner join books on borrow_list.book_id = books.book_id where borrower_name = '" + Session["Login_Name"].ToString() + "'";
        }
    }
}