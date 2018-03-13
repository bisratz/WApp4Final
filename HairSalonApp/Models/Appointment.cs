using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HairSalonApp.Models
{
    public class Appointment
    {
        public int ID { get; set; }       
        public Customer customer { get; set; }
        public Employee employee { get; set; }

        [Required]
        [DisplayName("Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [DisplayName("Time")]
        [DataType(DataType.Time)]
        public DateTime Time { get; set; }

        public string Description { get; set; }
    }
}