<%@ Page Title="Book Catalog" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="mp.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .img-responsive {
          max-width: 100%; 
          max-height:150px;
        }
        .container-fluid{
            background-color:rgba(255, 255, 255, 0.4);
            border-radius: 30px;
            margin-left:2%;
            margin-right:2%;
            width:95%;
        }
        .auto-style1 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <img src="pictures/bookscover.png" class="img-fluid" alt="Responsive image" />
    </div>
    <br>
    <br>
    <div class="container-fluid">

    &nbsp;<div class="auto-style1">
        <center>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" DataSourceID="SqlDataSource1" ForeColor="Black" AllowPaging="True" AllowSorting="True" Width="70%">
                <Columns>
                    <asp:BoundField DataField="Book_ID" HeaderText="Book_ID" SortExpression="Book_ID"/>
                    <asp:BoundField DataField="Book_Name" HeaderText="Book Name" SortExpression="Book_Name" />
                    <asp:BoundField DataField="Genre" HeaderText="Genre" SortExpression="Genre" />
                    <asp:BoundField DataField="Fee" HeaderText="Fee" SortExpression="Fee" />
                    <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="CancelButton" OnClick="CancelButton_Click" runat="server" Text="Borrow"></asp:LinkButton>
                            </ItemTemplate>
                    </asp:TemplateField>
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
<%--            SelectCommand="SELECT [Book_ID], [Book_Name], [Genre], [Fee] FROM [Books]"--%>
            </center>
        </div>
    </div>
    <br>
    <br>
        
</asp:Content>
