using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Drive.Dtos
{
    public class DriverForCreationDto
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(15, ErrorMessage = "Name can't be longer than 15 characters")]
        public string Name { get; set; }
        //[Required(ErrorMessage = "Address is required")]
        //[StringLength(100, ErrorMessage = "Address cannot be loner then 100 characters")]
        public string LastName { get; set; }
        //[Required(ErrorMessage = "Date of birth is required")]
        public DateTime DateOfBirth { get; set; }
        public string Jmbg { get; set; }
        public string BankAccount { get; set; }
        //[Required(ErrorMessage = "Date of birth is required")]
        public DateTime WorkStart { get; set; }
        //[Required(ErrorMessage = "Address is required")]
        //[StringLength(100, ErrorMessage = "Address cannot be loner then 100 characters")]
        public string Adress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
