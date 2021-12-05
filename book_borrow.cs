using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mp
{
    public class book_borrow
    {
        private DateTime b_creation;
        private int b_id;
        private int b_fee;
        private string borrow_name;
        private DateTime b_pay_time;
        private DateTime b_return_time;
        private DateTime b_borrow_time;

        public DateTime Borrow_time
        {
            get { return b_borrow_time; }
            set { b_borrow_time = value; }
        }
        public DateTime Pay_time
        {
            get { return b_pay_time; }
            set { b_pay_time = value; }
        }
        public DateTime Return_time
        {
            get { return b_return_time; }
            set { b_return_time = value; }
        }
        public string Borrower_name
        {
            get { return borrow_name; }
            set { borrow_name = value; }
        }
        public DateTime Borrower_creation
        {
            get { return b_creation; }
            set { b_creation=value; }
        }
        public int Book_id
        {
            get{ return b_id; }
            set{ b_id = value; }
        }


        public int Book_fee
        {
            get { return b_fee; }
            set { b_fee = value; }
        }

    }
    class borrow_Ops : DB_Ops
    {
        public void borrow_book(book_borrow bb)
        {
            open_connect();
            Exec_Qry("INSERT INTO Borrow_List VALUES('" + bb.Borrower_creation +"','" + bb.Borrower_name+"','"+bb.Book_id+"','"+"pending"+"','"+DateTime.Now
                +"','"+ DBNull.Value + "','"+ DBNull.Value +"','"+ bb.Book_fee + "')" ,false);
            close_connect();
        }

        public void return_book(book_borrow bb)
        {
            open_connect();
            Exec_Qry($"update Borrow_List set Date_return = '{bb.Return_time}', status ='returned' where Borrower_Name='{bb.Borrower_name}' and book_id ={bb.Book_id}", false);
            close_connect();
        }

        public void pay_book(book_borrow bb)
        {
            open_connect();
            Exec_Qry($"update Borrow_List set Date_Paid = '{bb.Pay_time}', status='paid' where Borrower_Name ='{bb.Borrower_name}' and book_id ={bb.Book_id}", false);
            close_connect();
        }

    }
}