﻿using ELNET.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
/// Summary description for Class1
/// </summary>
public class Program
{
    private int id;
    private string programName;
    public Program()
    {
        // TODO: Add constructor logic here
        //
    }

    public Program getProgramById(int id) {
        List<Program> programs = new List<Program>();
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
        }
        catch (Exception ex)
        {
            colleges = null;
        }
        return null;
    }
}