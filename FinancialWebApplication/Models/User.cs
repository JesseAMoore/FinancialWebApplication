using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinancialWebApplication.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public bool LoggedIn { get; set; }
        public DateTime CreatedDTTM { get; set; }
        public DateTime UpdatedDTTM { get; set; }
    }
}