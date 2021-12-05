<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="mp.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: larger;
        }
        .carousel-item{
            width:100%;
            top:20px;
            margin-bottom:10%;
        }
        .d-block w-100{
            bottom:10px;
            top:10px;
        }
        .container{
            background-color: rgba(255, 255, 255, 0);
            border-radius: 30px;
            margin-left:2%;
            width:60%;
        }
        .carousel-inner > .item {
            height: 400px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div style="background-image: url('pictures/pic.jpg');background-size: cover;width: 100%; height: 250px; color: #FFFFFF; font-weight: bold; font-size: xx-large; font-family: 'Britannic Bold'; text-align: center; vertical-align: inherit;">
        <br />
        <asp:Label ID="Label1" runat="server" Text="University Library" CssClass="auto-style1" Font-Size="XX-Large"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Open Weekdays 9:00 am - 6:00 pm" Font-Size="Large"></asp:Label>
    </div>
   <div>
       <br />
   </div>
    <div class="container float-left" style="bottom:10%;" >
        <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel" style="width: 100%; height: 400px">
      <ol class="carousel-indicators">
        <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
        <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
        <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
      </ol>
      <div class="carousel-inner">
        <div class="carousel-item active">
          <img class="d-block w-100 img-fluid " src="pictures/c6.jpg" alt="First slide" style="height:350px">
        </div>
        <div class="carousel-item">
          <img class="d-block w-100 img-fluid " src="pictures/c7.jpg" alt="Second slide" style="height:350px">
        </div>
        <div class="carousel-item">
          <img class="d-block w-100 img-fluid" src="pictures/c5.jpg" alt="Third slide" style="height:350px">
        </div>
      </div>
      <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
        <span class="sr-only">Previous</span>
      </a>
      <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
        <span class="carousel-control-next-icon" aria-hidden="true"></span>
        <span class="sr-only">Next</span>
      </a>
    </div>
    </div>

    <div class="container float-right " style="width: 30% ;margin-right:2%; background-color:rgba(17, 150, 95,  0.5)" >
        <div id="carouselExampleIndicators2" class="carousel slide" data-ride="carousel" style="width: 100%; height: 400px">
      <ol class="carousel-indicators">
        <li data-target="#carouselExampleIndicators2" data-slide-to="0" class="active"></li>
        <li data-target="#carouselExampleIndicators2" data-slide-to="1"></li>
        <li data-target="#carouselExampleIndicators2" data-slide-to="2"></li>
      </ol>
      <div class="carousel-inner">
        <div class="carousel-item active">
          <img class="d-block w-100 img-fluid " src="pictures/c4.jpg" alt="First slide" style="height:350px">
        </div>
        <div class="carousel-item">
          <img class="d-block w-100 img-fluid "src="pictures/c8.jpg" alt="Second slide" style="height:350px">
        </div>
        <div class="carousel-item">
          <img class="d-block w-100 img-fluid " src="pictures/c3.png" alt="Third slide" style="height:350px">
        </div>
      </div>
      <a class="carousel-control-prev" href="#carouselExampleIndicators2" role="button" data-slide="prev">
        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
        <span class="sr-only">Previous</span>
      </a>
      <a class="carousel-control-next" href="#carouselExampleIndicators2" role="button" data-slide="next">
        <span class="carousel-control-next-icon" aria-hidden="true"></span>
        <span class="sr-only">Next</span>
      </a>
    </div>
    </div>
</asp:Content>
