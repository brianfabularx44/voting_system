using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ELNET.Models
{
    public class CollegeDBInitializer : DropCreateDatabaseIfModelChanges<CollegeContext>
    {
        protected override void Seed(CollegeContext context)
        {
            getColleges().ForEach(c => context.Colleges.Add(c));
        }

        private static getColleges()
        {
            return new List<College>
            {
                new College
                {
                    Id = 1,
                    CollegeName = "CCS",
                    CollegeShortName = "CCS"
                }
            }
        }
    }
}
