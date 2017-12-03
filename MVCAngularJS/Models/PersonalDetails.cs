using System;

namespace MVCAngularJS.Models
{

    public class PersonalDetails
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddresss { get; set; }
    }
}