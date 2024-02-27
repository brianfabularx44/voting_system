using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.UI;
using ELNET;
using System.Configuration;
using System.Data.SqlClient;

public partial class Account_Register : Page
{
    protected void CreateUser_Click(object sender, EventArgs e)
    {
        string idNumber = IDNumber.Text;
        string firstName = FirstName.Text;
        string lastName = LastName.Text;
        string password = Password.Text;
        var manager = new UserManager();
        var user = new ApplicationUser() { UserName = idNumber };
        IdentityResult result = manager.Create(user, password);
        if (result.Succeeded)
        {
            IdentityHelper.SignIn(manager, user, isPersistent: false);
            string query = "INSERT INTO users (firstName, lastName, idNumber, password) " +
                       "VALUES (@FirstName, @LastName, @IdNumber, @Password);";
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegiConnectionString"].ConnectionString);
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@IdNumber", idNumber);
                command.Parameters.AddWithValue("@Password", password); // Assuming password is constant for demonstration purposes
                command.ExecuteNonQuery();
                conn.Close();
                IdentityHelper.RedirectToReturnUrl("~/Default.aspx", Response);
            }
            catch (Exception ex)
            {
                FailureText.Text = ex.Message;
            }
        }
        else
        {
            FailureText.Text = "Invalid username or password.";
            foreach (var error in result.Errors)
            {
                FailureText.Text += "<br />" + error;
            }


            /*
                    var manager = new UserManager();
                    var user = new ApplicationUser() { UserName = UserName.Text };
                    IdentityResult result = manager.Create(user, Password.Text);
                    if (result.Succeeded)
                    {
                        IdentityHelper.SignIn(manager, user, isPersistent: false);
                        IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                    }
                    else
                    {
                        ErrorMessage.Text = result.Errors.FirstOrDefault();
                    }
                    */
        }
    }
}