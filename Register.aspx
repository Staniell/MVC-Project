<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="mp.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<style type="text/css">
		@import url('https://fonts.googleapis.com/css?family=Numans');

		.container{
		height: 100%;
		align-content: center;
		}

		.card{
		height: 370px;
		margin-top: auto;
		margin-bottom: auto;
		width: 400px;
		background-color: rgba(0,0,0,0.5) !important;
		}

		.card-header h3{
		color: white;
		}

		.social_icon{
		position: absolute;
		right: 20px;
		top: -45px;
		}

		.input-group-prepend span{
		width: 50px;
		background-color: #FFC312;
		color: black;
		border:0 !important;
		}

		input:focus{
		outline: 0 0 0 0  !important;
		box-shadow: 0 0 0 0 !important;

		}

		.remember{
		color: white;
		}

		.remember input
		{
		width: 20px;
		height: 20px;
		margin-left: 15px;
		margin-right: 5px;
		}

		.login_btn{
		color: black;
		background-color: #FFC312;
		width: 100px;
		}

		.login_btn:hover{
		color: black;
		background-color: white;
		}

		.links{
		color: white;
		}

		.links a{
		margin-left: 4px;
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin-top:25px">
		<div class="d-flex justify-content-center h-100">
			<div class="card">
				<div class="card-header">
					<h3>Register</h3>
				</div>
				<div class="card-body">
					<div>
						<div class="input-group form-group">
							<div class="input-group-prepend">
								<span class="input-group-text"><i class="fas fa-user"></i></span>
							</div>
<asp:TextBox ID="username" class="form-control" placeholder="username" type="text" runat="server"></asp:TextBox>
						</div>
						<div class="input-group form-group">
							<div class="input-group-prepend">
								<span class="input-group-text"><i class="fas fa-key"></i></span>
							</div>
<asp:TextBox ID="email" type="email" runat="server" class="form-control" placeholder="email"></asp:TextBox>
						</div>
												<div class="input-group form-group">
							<div class="input-group-prepend">
								<span class="input-group-text"><i class="fas fa-key"></i></span>
							</div>
<asp:TextBox ID="phone_no" type="text" runat="server" class="form-control" placeholder="phone number"></asp:TextBox>
						</div>

												<div class="input-group form-group">
							<div class="input-group-prepend">
								<span class="input-group-text"><i class="fas fa-key"></i></span>
							</div>
<asp:TextBox ID="passcode" type="password" runat="server" class="form-control" placeholder="password"></asp:TextBox>
						</div>

						<div class="form-group">
						<asp:Button class="btn float-right login_btn" ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
						</div>
					</div>
				</div>
				<div class="card-footer">
					<div class="d-flex justify-content-center links">
						Already have an account?<a href="LogIn.aspx">Login</a>
					</div>
				</div>
			</div>
		</div>
	</div>
</asp:Content>
