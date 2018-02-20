using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data.Entity;

namespace Lab20.Models
{
    public class Register
    {
        [Required]
        // [DisplayFormat(ConvertEmptyStringToNull = false)]
        // [StringLength(20, MinimumLength = 2, ErrorMessage = "Enter A Valid First Name")]
        [Key]
        public string FirstName { get; set; }

        [Required]
        // [DisplayFormat(ConvertEmptyStringToNull = false)]
        // [StringLength(20, MinimumLength =2, ErrorMessage = "Enter A Valid Email")]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string password { get; set; }
    }

    public class DBRegisterContext : DbContext
    {
        public DbSet<Register> Entries { get; set; }

        public System.Data.Entity.DbSet<Lab20.Models.Item> Items { get; set; }
    }
}