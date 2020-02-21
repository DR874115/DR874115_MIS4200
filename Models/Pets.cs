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
        [Display(Name = "Pet Name")]
        [Required(ErrorMessage = "Pet name is required")]
        [StringLength(20)]
        public string PetName { get; set; }
        [Display(Name = "Pet Type")]
        [Required(ErrorMessage = "Pet type is required")]
        [StringLength(40)]
        public string Type { get; set; }
        [Display(Name = "Pet Breed")]
        [Required(ErrorMessage = "Pet Breed is required")]
        [StringLength(40)]
        public string Breed { get; set; }
        public ICollection<PetDetails> PetDetails { get; set; }

    }
}