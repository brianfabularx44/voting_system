<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Account_Login" Async="true" %>
<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="LogInContent">
    <div class="row vh-100 align-items-center">
            <div class="col-sm-6">
                <div class="gy-4">
                    <h4>Welcome Student!</h4>
                    <h3>Login to your account</h3>
                    <div class="mb-3">
                      <label for="idnumber" class="form-label">ID Number</label>
                       <asp:TextBox CssClass="form-control" id="idnumber" type="text" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                      <label for="password" class="form-label">Password</label>
                      <asp:TextBox CssClass="form-control" id="password" type="text" runat="server"></asp:TextBox>
                    </div>
                    <asp:Button ID="aspButton" runat="server" Text="Login" OnClick="Login_Click" CssClass="btn btn-success" />
                    <div>
                        <asp:Literal runat="server" ID="FailureText" />
                    </div>

                </div>
            </div>
            <div class="col-sm-6">
                <div>
                    <asp:Image ID="imgDisplay" Width="300" runat="server" ImageUrl="~/assets/uccp_logo.jpg" />
                </div>
            </div>

    </div>
</asp:Content>

