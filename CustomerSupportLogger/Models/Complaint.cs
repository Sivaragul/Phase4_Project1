using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerSupportLogger.Models
{
    public class Complaint
    {
        public int LogId { get; set; }
        public string CustomerMail { get; set; }
        public string CustomerName { get; set; }
        public string LogStatus { get; set; }
        public string Description { get; set; }
    }
}