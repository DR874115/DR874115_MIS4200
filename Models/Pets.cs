using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DR874115_MIS4200.Models
{
    public class Pets
    {
        [Key]
        public int PetID { get; set; }
        public string PetName { get; set; }
        public string Type { get; set; }
        public string Breed { get; set; }
        public ICollection<PetDetails> PetDetails { get; set; }

    }
}