using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspinia_MVC5.Models
{
    class Profile
    {
        [Key]
        [Required]
        public int PersonId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        [Required]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Emergency Phone number")]
        public string EmergencyPhoneNumber { get; set; }

        [Display(Name = "Emergency Contact")]
        public string EmergencyContact { get; set; }

        public string Info { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
