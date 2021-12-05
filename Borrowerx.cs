using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace mp
{
    public class Borrowerx
    {
        public string username { get; set; }
        public string phone_no { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        //Constructor for register page
        public Borrowerx(string name, string number, string Email, string Password)
        {
            username = name;
            phone_no = number;
            email = Email;
            password = Password;
        }

        //Constructor for login page
        public Borrowerx(string name, string Password)
        {
            username = name;
            password = Password;
        }

        //Constructor for changing of account details
        public Borrowerx(string name)
        {
            username = name;
        }


        //public string Username
        //{
        //    get { return username; }
        //    set { username = value; }
        //}

        //public string Phone
        //{
        //    get { return phone_no; }
        //    set { phone_no = value; }
        //}

        //public string Email
        //{
        //    get { return email; }
        //    set { email = value; }
        //}

        //public string Password
        //{
        //    get { return password; }
        //    set { password = value; }
        //}

    }

    class Operationx : DB_Ops
    {
        public void Register(Borrowerx borrower)
        {
            open_connect();
            Exec_Qry("INSERT INTO Reg_Accounts VALUES('" + borrower.username + "','" + borrower.phone_no + "','" + borrower.email + "','" +
                        borrower.password + "','" + DateTime.Now + "')", false);
            close_connect();
        }
        
        public bool Login(Borrowerx borrowerz)
        {
            int result = 0;
            open_connect();
            result=Exec_Qry("SELECT COUNT(1) FROM Reg_Accounts WHERE Borrower_Name='" + borrowerz.username + "' AND" +
            " Borrower_Password='" + borrowerz.password+"'", true);
            close_connect();
            if (result == 1)
                return true;
            else
                return false;
        }

        public void changeEmail(Borrowerx borrower, string new_email)
        {
            open_connect();
            Exec_Qry($"update Reg_Accounts set borrower_email = '{new_email}' where borrower_name='{borrower.username}'", false);
            close_connect();
        }

        public void changePass(Borrowerx borrower, string new_pass)
        {
            open_connect();
            Exec_Qry($"update Reg_Accounts set borrower_password = '{new_pass}' where borrower_name='{borrower.username}'", false);
            close_connect();
        }

        public void changeNumber(Borrowerx borrower, string new_number)
        {
            open_connect();
            Exec_Qry($"update Reg_Accounts set phone_number = '{new_number}' where borrower_name = '{borrower.username}'", false);
            close_connect();
        }

        public void Deactivate(Borrowerx borrower)
        {
            open_connect();
            Exec_Qry($"Delete from borrow_list where borrower_name ='{borrower.username}'", false);
            Exec_Qry($"Delete from reg_accounts where borrower_name ='{borrower.username}'", false);
            close_connect();
        }
    }
}