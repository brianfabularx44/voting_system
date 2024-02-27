<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="mt-5">
        <h5 class="mb-3">Partylists of College of Computer Studies</h5>

        <div class="row justify-content-start">
            <asp:Repeater ID="partylistCard" runat="server">
                <ItemTemplate>
                    <div class="col-sm-4">
                        <div class="card shadow w-75 border-primary my-3" style="width: 18rem;">
                          <img src="assets/uccp_logo.jpg" class="card-img-top" alt="..." style="height: 12vw; object-fit: cover; width: 100%">
                          <div class="card-body row align-items-center">
                            <h5 class="col">Jewel Partylist</h5>
                            <a href="#" class="btn-sm btn text-white col-4 me-1" style="background-color: #BB9237">See more</a>
                          </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>

    </div>
</asp:Content>
