using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Populate the GridView with dummy data
            List<PartyList> partyLists = GetDummyPartyLists();
            PartyListGridView.DataSource = partyLists;
            PartyListGridView.DataBind();
        }
    }

    // Dummy method to generate sample party list data
    private List<PartyList> GetDummyPartyLists()
    {
        List<PartyList> partyLists = new List<PartyList>
        {
            new PartyList { PartyListName = "Party List 1", DateAdded = DateTime.Now.AddDays(-10), Department = "College of Computer Studies", Program = "BSCS" },
            new PartyList { PartyListName = "Party List 2", DateAdded = DateTime.Now.AddDays(-5), Department = "College of Computer Studies", Program = "BSCS" },
            new PartyList { PartyListName = "Party List 3", DateAdded = DateTime.Now.AddDays(-2), Department = "College of Computer Studies", Program = "BSCS" }
            // Add more dummy data as needed
        };
        return partyLists;
    }
}

public class PartyList
{
    public string PartyListName { get; set; }
    public DateTime DateAdded { get; set; }
    public string Department { get; set; }
    public string Program { get; set; }
}
