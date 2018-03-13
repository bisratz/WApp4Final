using System.ComponentModel;

namespace HairSalonApp.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [DisplayName("Employee First Name")]
        public string FirstName { get; set; }

        [DisplayName("Employee Last Name")]
        public string LastName { get; set; }

        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }
    }
}