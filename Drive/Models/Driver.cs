using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Drive.Models
{
    public class Driver
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(15, ErrorMessage = "Name can't be longer than 60 characters")]
        public string Name { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DateOfBirth { get; set; }
        public string Jmbg { get; set; }
        public string BankAccount { get; set; }
        public DateTime WorkStart { get; set; }
        public DateTime? WorkEnd { get; set; }
        [Required(ErrorMessage = "Address is required")]
        [StringLength(50, ErrorMessage = "Address cannot be longer than 100 characters")]
        public string Adress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
