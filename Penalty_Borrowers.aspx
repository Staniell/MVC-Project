<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Penalty_Borrowers.aspx.cs" Inherits="mp.Penalty_Borrowers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Borrowers with penalty</title>
    <link rel="stylesheet" href="~/styles/backend_design.css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
            <div class="rectangle container-fluid">
        <img src="pictures/BookLogo.png" class="bookLogo" />
        <img src="pictures/Library_Management_System.png" class="logo" />
    </div>
        <div class="sidebar">
        <a href="Books/Index">Back</a>
    </div>
        <center>
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Account_Created" HeaderText="Account_Created" SortExpression="Account_Created" />
                    <asp:BoundField DataField="Borrower_Name" HeaderText="Borrower_Name" SortExpression="Borrower_Name" />
                    <asp:BoundField DataField="Book_ID" HeaderText="Book_ID" SortExpression="Book_ID" />
                    <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                    <asp:BoundField DataField="Date_Borrowed" HeaderText="Date_Borrowed" SortExpression="Date_Borrowed" />
                    <asp:BoundField DataField="Date_Return" HeaderText="Date_Return" SortExpression="Date_Return" />
                    <asp:BoundField DataField="Date_Paid" HeaderText="Date_Paid" SortExpression="Date_Paid" />
                    <asp:BoundField DataField="Fee" HeaderText="Fee" SortExpression="Fee" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Book_LoanConnectionString2 %>" SelectCommand="select *
from borrow_list
where Date_Borrowed &lt; DATEADD(week, -1, getdate()) and status ='borrowed';"></asp:SqlDataSource>
        </div>
            </center>
    </form>
</body>
</html>
