using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamBackend.Models
{
    public class UserData
    {
        public int Id { get; set; } 
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Organization { get; set; }

        
        public string AddressLine1 { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }

       
    }
}
