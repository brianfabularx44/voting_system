using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ELNET.Models
{
    public class College
    {

        public int Id { get; set; }
        public string CollegeName { get; set; }
        public string CollegeShortName { get; set; }
    }
}
