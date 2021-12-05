using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace mp
{
    public class DB_Ops
    {
        private SqlConnection con = new SqlConnection("");
        public void open_connect()
        {
            con.Open();
        }

        public void close_connect()
        {
            con.Close();
        }


        public int Exec_Qry(string qry, bool check)
        {
            //1 = account exists
            //0 = account does not exist
            if (check)
            {
                var comm = new SqlCommand(qry, con);
                byte count = Convert.ToByte(comm.ExecuteScalar());
                if (count == 1)
                    return 1;
            }

            else
            {
                var comm = new SqlCommand(qry, con);
                comm.ExecuteNonQuery();
                return 0;
            }
            return 0;
        }

        public DateTime get_acc_creation(string username)
        {
            open_connect();
            var comm = new SqlCommand($"select account_created from Reg_Accounts where Borrower_Name = '{username}'", con);

            SqlDataReader dr;
            dr = comm.ExecuteReader();

            DateTime acc_date= new DateTime(2015, 12, 25);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    acc_date = Convert.ToDateTime(dr[0].ToString());
                }
            }
            return acc_date;
        }

        public bool check_if_borrowed(string username, int book_id)
        {
            open_connect();
            var comm = new SqlCommand($"select borrower_name, book_id from Borrow_List where Borrower_Name = '{username}' and Book_ID ={book_id}", con);
            SqlDataReader dr;
            dr = comm.ExecuteReader();

            if (dr.HasRows)
            {
                close_connect();
                return true;
            }
            else
            {
                close_connect();
                return false;
            }
        }
    }
}