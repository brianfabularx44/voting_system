using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    public List<string> Sites = new List<string> { "StackOverflow", "Super User", "Meta SO", "NIGGA", "what" };
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (User.Identity.IsAuthenticated)
            {
                // User is logged in, perform necessary actions
                partylistCard.DataSource = Sites;
                partylistCard.DataBind();
            }
            else
            {
                ContentPlaceHolder mainContent = (ContentPlaceHolder)this.Master.FindControl("MainContent");
                mainContent.Visible = false;
                // User is not logged in, handle accordingly
                Response.Redirect("~/Account/Login.aspx");
            }
        }
    }
}