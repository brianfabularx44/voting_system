<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Vote.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="mt-5">
        <h3>Vote for your Candidates!</h3>
        <p>It's time to vote for the leaders who will represent you and make a difference in our school community. Remember to vote wisely!</p>
        <div class="border rounded mt-3 py-5">
            <div class="mx-5">
                <div class="mb-3">
                    <h5 class="mb-3">President</h5>
                    <div class="row">
                        <div class="row col-6 align-items-center">
                            <img src="assets/uc_logo.jpg" class="col-4 img-thumbnail" width="50" height="50" style="object-fit: cover"/>
                            <div class="form-check col-5 ms-2">
                              <input class="form-check-input" type="radio" name="flexRadioDefault" id="flexRadioDefault1">
                              <label class="form-check-label" for="flexRadioDefault1">
                                Jewel Oniichan (BS Computer Science)
                              </label>
                            </div>
                        </div>

                        <div class="row col-6 align-items-center">
                            <img src="assets/uc_logo.jpg" class="col-4 img-thumbnail" width="50" height="50" style="object-fit: cover"/>
                            <div class="form-check col-5 ms-2">
                              <input class="form-check-input" type="radio" name="flexRadioDefault" id="flexRadioDefault1">
                              <label class="form-check-label" for="flexRadioDefault1">
                                Jewel Oniichan (BS Computer Science)
                              </label>
                            </div>
                        </div>
                    </div>

                    <div class="mt-3">
                        <h5 class="mb-3 mt-5">Vice President</h5>
                        <div class="row">
                            <div class="row col-6 align-items-center">
                                <img src="assets/uc_logo.jpg" class="col-4 img-thumbnail" width="50" height="50" style="object-fit: cover"/>
                                <div class="form-check col-5 ms-2">
                                  <input class="form-check-input" type="radio" name="flexRadioDefault1" id="flexRadioDefault2">
                                  <label class="form-check-label" for="flexRadioDefault1">
                                    Jewel Oniichan (BS Computer Science)
                                  </label>
                                </div>
                            </div>

                            <div class="row col-6 align-items-center">
                                <img src="assets/uc_logo.jpg" class="col-4 img-thumbnail" width="50" height="50" style="object-fit: cover"/>
                                <div class="form-check col-5 ms-2">
                                  <input class="form-check-input" type="radio" name="flexRadioDefault1" id="flexRadioDefault2">
                                  <label class="form-check-label" for="flexRadioDefault1">
                                    Jewel Oniichan (BS Computer Science)
                                  </label>
                                </div>
                            </div>
                        </div>
                </div>
            </div>
                <div class="text-center mt-5">
                    <asp:Button CssClass="btn btn-primary" runat="server" Text="Submit"/>
                </div>
        </div>
    </div>
</asp:Content>

