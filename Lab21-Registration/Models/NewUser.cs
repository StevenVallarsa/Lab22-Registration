using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab21_Registration.Models
{
    public class NewUser
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Phone { get; set; }
    }
}