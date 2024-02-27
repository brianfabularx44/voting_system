using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Web;
using System.Web.UI;
using ELNET;
using System.Security.Principal;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;

public partial class Account_Login : Page
{
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Default.aspx");
            }
    }

    protected void Login_Click(object sender, EventArgs e)
        {
            string idnumberValue = idnumber.Text;
            string passwordValue = password.Text;

            string query = "SELECT * FROM users WHERE idNumber = @IdNumber AND password = @Password";

        try
        {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegiConnectionString"].ConnectionString);
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@IdNumber", idnumberValue);
                command.Parameters.AddWithValue("@Password", passwordValue);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    var userManager = new UserManager();
                    ApplicationUser user = userManager.Find(idnumberValue, passwordValue);
                    if (user != null)
                    {
                        IdentityHelper.SignIn(userManager, user, isPersistent: true);
                        IdentityHelper.RedirectToReturnUrl("~/Default.aspx", Response);
                    }
                }
                else
                {
                    FailureText.Text = "Incorrect Password";
                }
             conn.Close();

            }catch (Exception ex)
            {
                FailureText.Text = ex.Message;
            }

        /*
        Session["user"] = idnumberValue;
        var manager = new UserManager();
        var user = new ApplicationUser() { UserName = idnumber.Text };
        IdentityResult result = manager.Create(user, password.Text);
        if (result.Succeeded)
        {
            IdentityHelper.SignIn(manager, user, isPersistent: false);
        }
        else
        {
            FailureText.Text = "Invalid username or password.";
        foreach (var error in result.Errors)
        {
            FailureText.Text += "<br />" + error;
        }
        */

    }




}
