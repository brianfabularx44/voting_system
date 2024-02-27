using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.UI;
using ELNET;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Services.Description;
using ELNET.Models;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity.EntityFramework;
public partial class Account_Register : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            ProgramDropdown.Items.Add(new ListItem("Select Program", "-1"));
            List<College> colleges = new College().getColleges();
            CollegeDropdown.Items.Add(new ListItem("Select College", "-1"));
            foreach (College college in colleges)
            {
                ListItem item = new ListItem(college.CollegeName, college.Id + "");
                CollegeDropdown.Items.Add(item);
            }
            CollegeDropdown.DataBind();
        }
        
    }
    protected void CreateUser_Click(object sender, EventArgs e)
    {
        string idNumber = IDNumber.Text;
        string firstName = FirstName.Text;
        string lastName = LastName.Text;
        string password = Password.Text;
        string programId = CollegeDropdown.SelectedValue;
        string yrLevel = YearLevelDropDown.SelectedValue;
        
            string query = "INSERT INTO users (firstName, lastName, idNumber, password, programId, yrLevel) " +
                       "VALUES (@FirstName, @LastName, @IdNumber, @Password, @ProgramId, @YearLevel);";
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegiConnectionString"].ConnectionString);
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@IdNumber", idNumber);
                command.Parameters.AddWithValue("@Password", password); // Assuming password is constant for demonstration purposes
                command.Parameters.AddWithValue("@ProgramId", int.Parse(programId)); // Assuming password is constant for demonstration purposes
                command.Parameters.AddWithValue("@YearLevel", yrLevel); // Assuming password is constant for demonstration purposes
                command.ExecuteNonQuery();
                conn.Close();
                var manager = new UserManager();
                var user = new ApplicationUser() { UserName = idNumber };
                IdentityResult result = manager.Create(user, password);
                IdentityHelper.SignIn(manager, user, isPersistent: false);
                IdentityHelper.RedirectToReturnUrl("~/Default.aspx", Response);
            }
            catch (Exception ex)
            {
                FailureText.Text = ex.Message;
            }
    }

    protected void CollegeSelectionChange(object sender, EventArgs e)
    {
        ProgramDropdown.Items.Clear();  
        List<Program> programs= new Program().getProgramsOfCollegeId(int.Parse(CollegeDropdown.SelectedValue));

        foreach (Program program in programs)
        {
            ListItem item = new ListItem(program.programName, program.Id + "");
            ProgramDropdown.Items.Add(item);
        }
        ProgramDropdown.DataBind();

    }
}