using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ELNET.Models
{
    public class CollegeContext:DbContext
    {
        public DbSet<College> Colleges {  get; set; }
    }
}
