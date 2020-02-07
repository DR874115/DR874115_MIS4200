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
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Email { get; set; }
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