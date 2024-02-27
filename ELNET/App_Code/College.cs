using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.AspNet.Identity;
using System.Runtime.Remoting.Messaging;

namespace ELNET.Models
{
    public class College
    {

        public int Id { get; set; }
        public string CollegeName { get; set; }
        public string CollegeShortName { get; set; }
        public List<College> getColleges()
        {
            List<College> colleges = new List<College>();
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegiConnectionString"].ConnectionString);
                conn.Open();
                string query = "SELECT * FROM college";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        College college = new College();
                        college.Id = Convert.ToInt32(reader["Id"]);
                        college.CollegeName = reader["long_name"].ToString();
                        college.CollegeShortName = reader["short_name"].ToString();
                        colleges.Add(college);
                    }
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                colleges = null;
            }
            return colleges;
        }

    }
}
