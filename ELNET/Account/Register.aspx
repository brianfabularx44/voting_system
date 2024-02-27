<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Account_Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal row justify-content-center">
        <h4>Create a new account.</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group border p-4 w-75 ">
            <asp:Label runat="server" AssociatedControlID="IDNumber" CssClass=" control-label">ID Number</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="IDNumber" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="IDNumber"
                    CssClass="text-danger" ErrorMessage="The user name field is required." />
            </div>

            <div class="row">
                <div class="col-sm-6">
                    <asp:Label runat="server" AssociatedControlID="FirstName" CssClass="control-label">First Name</asp:Label>
                    <div class="">
                        <asp:TextBox runat="server" ID="FirstName" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="FirstName"
                            CssClass="text-danger" ErrorMessage="The user name field is required." />
                    </div>
                </div>

                <div class="col-sm-6">
                    <asp:Label runat="server" AssociatedControlID="LastName" CssClass="control-label">Last Name</asp:Label>
                    <div class="">
                        <asp:TextBox runat="server" ID="LastName" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="LastName"
                            CssClass="text-danger" ErrorMessage="The user name field is required." />
                    </div>
                </div>
            </div>

            <asp:Label runat="server" AssociatedControlID="Password" CssClass="control-label">Password</asp:Label>
            <div class="col-sm-12 ">
                <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                    CssClass="text-danger" ErrorMessage="The password field is required." />
            </div>

            <div class="row">
                <div class="col-sm-12 col-md-4">
                    <asp:Label runat="server" AssociatedControlID="CollegeDropdown" CssClass="control-label">Choose College</asp:Label>
                    <asp:DropDownList ID="CollegeDropdown" runat="server" AutoPostBack="true" OnSelectedIndexChanged="CollegeSelectionChange" CssClass="dropdown form-control">
                    </asp:DropDownList>
                </div>

                <div class="col-sm-12 col-md-4">
                    <asp:Label runat="server" CssClass="control-label">Choose Program</asp:Label>

                    <asp:DropDownList ID="ProgramDropdown" runat="server" CssClass="dropdown form-control">
                    </asp:DropDownList>
                </div>

                <div class="col-sm-12 col-md-4">
                <asp:Label runat="server" CssClass="control-label">Year Level</asp:Label>

                <asp:DropDownList ID="YearLevelDropDown" runat="server" CssClass="dropdown form-control">
                    <asp:ListItem Value= “-1”>Year Level</asp:ListItem>
                    <asp:ListItem Value=”1”>1</asp:ListItem>
                    <asp:ListItem Value=”2”>2</asp:ListItem>
                    <asp:ListItem Value=”3”>3</asp:ListItem>
                    <asp:ListItem Value=”4”>4</asp:ListItem>
                </asp:DropDownList>
            </div>
            </div>

            <div class="form-group mt-5">
                <div class="">
                    <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn-primary" />
                </div>
            </div>
            <div>
        </div>
            <asp:Literal runat="server" ID="FailureText" />

        </div>
    </div>
</asp:Content>

