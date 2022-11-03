using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerSupportLogger.Models
{
    public class User
    {
        [Required]
        public int UserId { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}