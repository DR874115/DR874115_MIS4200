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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public ICollection<PetDetails> PetDetails { get; set; }
        public string FullName { 
            get
            {
                return FirstName + ", " + LastName;
            }
                
         }
    }
}