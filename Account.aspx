<%@ Page Title="Account Information" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="mp.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type= "text/css">
        .table-hover tbody tr:hover td, .table-hover tbody tr:hover th {
          background-color:#f5bd0e;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="height:300px;width:75%;background-size:cover;background-image:url('/pictures/paper3.png');margin-left:12%;margin-right:10%;font-family:Arial, Helvetica, sans-serif";>
        <div class="text-left">
            <br />
            <br />
            <br />
            <center>
        <asp:DataList ID="DataList2" runat="server" DataKeyField="borrower_name" DataSourceID="SqlDataSource2">
            <ItemTemplate>
                <table>
                    <tr>
                        <td>
                Account_Created:
                <asp:Label ID="Account_CreatedLabel" runat="server" Text='<%# Eval("Account_Created") %>' />
                            </td>
                        </tr>
   <tr>
                        <td>
                Borrower Name:
                <asp:Label ID="borrower_nameLabel" runat="server" Text='<%# Eval("borrower_name") %>' />
                            </td>
                </tr>
                    <tr>
                        <td>
                Phone Number:
                <asp:Label ID="phone_numberLabel" runat="server" Text='<%# Eval("phone_number") %>' />
                </td>
<%--                        <td>
<asp:TextBox ID="phonetext" placeholder="New Phone Number" runat="server"></asp:TextBox><asp:Button ID="phone_button" OnClick="phone_button_Click" runat="server" Text="Change Number"></asp:Button>
                        </td>--%>
                        </tr>
                    <tr>
                        <td>
                Borrower Email:
                <asp:Label ID="Borrower_EmailLabel" runat="server" Text='<%# Eval("Borrower_Email") %>' />
                </td>
<%--                        <td>
<asp:TextBox ID="emailtext" placeholder="New Email" runat="server"></asp:TextBox><asp:Button ID="emailbutton" OnClick="emailbutton_Click" runat="server" Text="Change Email"></asp:Button>
                        </td>--%>
                        </tr>
                        <tr>
                        <td>
                Borrower Password:
                <asp:Label ID="Borrower_PasswordLabel" runat="server" Text='<%# Eval("Borrower_Password") %>' />
                            </td>
<%--                            <td>
<asp:TextBox ID="passtext" placeholder="New Password" runat="server"></asp:TextBox><asp:Button ID="passbutton" OnClick="passbutton_Click" runat="server" Text="Change Passsword"></asp:Button>
                            </td>--%>
                </tr>
                    
                    <tr>
<%--                        <td>
<asp:Button ID="deactivate_button" runat="server" Text="Deactivate Account" OnClick="deactivate_button_Click" BackColor="Red" ForeColor="Black"></asp:Button>
                            </td>--%>
                    </tr>
                </table>
            </ItemTemplate>
            </asp:DataList>
                <table>
                    <tr>
                        <td>
<asp:TextBox ID="phonetext" placeholder="New Phone Number" runat="server"></asp:TextBox><asp:Button ID="phone_button" OnClick="phone_button_Click" runat="server" Text="Change Number"></asp:Button>
                        </td>
                    </tr>
                    <tr>
                                                    <td>
<asp:TextBox ID="passtext" placeholder="New Password" runat="server"></asp:TextBox><asp:Button ID="passbutton" OnClick="passbutton_Click" runat="server" Text="Change Passsword"></asp:Button>
                            </td>
                    </tr>
                    <tr>
                                                <td>
<asp:TextBox ID="emailtext" placeholder="New Email" runat="server"></asp:TextBox><asp:Button ID="emailbutton" OnClick="emailbutton_Click" runat="server" Text="Change Email"></asp:Button>
                        </td>
                        <td></td>
                                                                        <td>
<asp:Button ID="deactivate_button" runat="server" Text="Deactivate Account" OnClick="deactivate_button_Click" BackColor="Red" ForeColor="Black"></asp:Button>
                            </td>
                    </tr>
                    </table>
                </center>
        </div>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Book_LoanConnectionString3 %>"></asp:SqlDataSource>
    </div>
    <div class="container">
         <table class="table table" style="color: #FFFFFF">
<%--            <thead>
                <tr>
                    <th>Row</th>
                    <th>Book</th>
                    <th>Date Borrowed</th>
                    <th>Return Date</th>
                </tr>
            </thead>
            <tbody>--%>
                <tr>
<td>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" DataSourceID="SqlDataSource1" ForeColor="Black" Width="80%">
        <Columns>
            <asp:BoundField DataField="book_id" HeaderText="Book ID" SortExpression="book_id" />
            <asp:BoundField DataField="book_name" HeaderText="Book Name" SortExpression="book_name" />
            <asp:BoundField DataField="status" HeaderText="Status" SortExpression="status" />
            <asp:BoundField DataField="date_borrowed" HeaderText="Date Borrowed" SortExpression="date_borrowed" />
            <asp:BoundField DataField="date_return" HeaderText="Date Returned" SortExpression="date_return" />
            <asp:BoundField DataField="date_paid" HeaderText="Date Paid" SortExpression="date_paid" />
            <asp:BoundField DataField="fee" HeaderText="Fee" SortExpression="fee" />
<%--            <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="return_button" OnClick="return_button_Click" runat="server" Text="Return"></asp:Button>
                    </ItemTemplate>
            </asp:TemplateField>
                        <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="pay_button" OnClick="pay_button_Click" runat="server" Text="Pay"></asp:Button>
                    </ItemTemplate>
            </asp:TemplateField>--%>
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Book_LoanConnectionString2 %>"></asp:SqlDataSource>
</td>
                </tr>
        </table>
    </div>
</asp:Content>







<%--
<asp:DataList ID="DataList2" runat="server" DataKeyField="borrower_name" DataSourceID="SqlDataSource2">
            <ItemTemplate>
                <table>
                    <tr>
                        <td>
                Account_Created:
                <asp:Label ID="Account_CreatedLabel" runat="server" Text='<%# Eval("Account_Created") %>' />
                <br />
                            </td>
                        <td>
                borrower_name:
                <asp:Label ID="borrower_nameLabel" runat="server" Text='<%# Eval("borrower_name") %>' />
                <br />
                            </td>
                        <td>
                phone_number:
                <asp:Label ID="phone_numberLabel" runat="server" Text='<%# Eval("phone_number") %>' />
                <br />
                            </td>
                        <td>
                Borrower_Email:
                <asp:Label ID="Borrower_EmailLabel" runat="server" Text='<%# Eval("Borrower_Email") %>' />
                <br />
                            </td>
                        <td>
                Borrower_Password:
                <asp:Label ID="Borrower_PasswordLabel" runat="server" Text='<%# Eval("Borrower_Password") %>' />
                <br />
                            </td>
                <br />
                                                </tr>
                    </table>
            </ItemTemplate>
            
            </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Book_LoanConnectionString %>" SelectCommand="select Account_Created, borrower_name, phone_number, Borrower_Email, Borrower_Password from Reg_Accounts where borrower_name = 'Joyce'"></asp:SqlDataSource>--%>