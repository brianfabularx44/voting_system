<%@ Page Title="" Language="C#" MasterPageFile="~/AdminSite.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="mt-5">
        <div class="row mb-3">
            <div class="col-md-4">
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-select">
                    <asp:ListItem Text="All" Value="All"></asp:ListItem>
                    <asp:ListItem Text="Computer Studies" Value="Computer Studies"></asp:ListItem>
                    <asp:ListItem Text="Arts and Sciences" Value="Arts and Sciences"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="row col-md-6">
                <div class="col-md-5">
                    <asp:TextBox ID="SearchTextBox" runat="server" CssClass="form-control" placeholder="Search by Party List Name"></asp:TextBox>
                </div>
                <div class="col-md-2">
                    <asp:Button ID="SearchButton" runat="server" Text="Search" CssClass="btn btn-primary"  />
                </div>
            </div>
            <div class="col">
                <asp:Button ID="AddPartyListButton" runat="server" Text="Add Party List" CssClass="btn btn-primary" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:GridView ID="PartyListGridView" runat="server" AutoGenerateColumns="False" CssClass="table">
                    <Columns>
                        <asp:BoundField DataField="PartyListName" HeaderText="Party List Name" />
                        <asp:BoundField DataField="DateAdded" HeaderText="Date Added" />
                        <asp:BoundField DataField="Department" HeaderText="Department" />
                        <asp:BoundField DataField="Program" HeaderText="Program" />
                        <asp:TemplateField HeaderText="Actions">
                            <ItemTemplate>
                                <asp:Button ID="EditButton" runat="server" Text="Edit" CssClass="btn btn-sm btn-primary" CommandName="Edit" />
                                <asp:Button ID="DeleteButton" runat="server" Text="Delete" CssClass="btn btn-sm btn-danger" CommandName="Delete" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
