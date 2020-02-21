using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DR874115_MIS4200.Models
{
    public class Owners
    {
        [Key]
        public int OwnerID { get; set; }
        [Display(Name ="First Name")]
        [Required(ErrorMessage ="Owner first name is required")]
        [StringLength(20)]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Owner last name is required")]
        [StringLength(20)]
        public string LastName { get; set; }
        [Display(Name = "Most used email address")]
        [Required]
        [EmailAddress(ErrorMessage = "Enter your most frequently used email address")]
        public string Email { get; set; }
        [Display(Name = "Mobile phone number")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public string City { get; set; }
        public ICollection<PetDetails> PetDetails { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { 
            get
            {
                return LastName + ", " + FirstName;
            }
                
         }
    }
}