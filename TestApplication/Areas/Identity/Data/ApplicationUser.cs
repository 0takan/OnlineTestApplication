using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace TestApplication.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="nvarchar(100)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }
    }
    public class Cards 
    {


        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string test_name { get; set; }
        [Column(TypeName = "nvarchar(100)")]

        public string img { get; set; }
        [Column(TypeName = "nvarchar(500)")]

        public string descrition { get; set; }
    }

}
