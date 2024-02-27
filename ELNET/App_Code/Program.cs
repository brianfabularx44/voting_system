using ELNET.Models;
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
    public int Id { get; set; }
    public string programName { get; set; }
    public Program()
    {
        // TODO: Add constructor logic here
        //
    }

    public List<Program> getProgramsOfCollegeId(int id)
    {
        List<Program> programs = new List<Program>();
        try
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegiConnectionString"].ConnectionString);
            conn.Open();
            string query = "SELECT * FROM programs INNER JOIN college on programs.college_id = "+id+" where college.ID = "+id;
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Program program= new Program();
                    program.Id = Convert.ToInt32(reader["Id"]);
                    program.programName = reader["long_name"].ToString();
                    programs.Add(program);
                }
            }
        }
        catch (Exception ex)
        {
            programs = null;
        }
        return programs;
    }
}