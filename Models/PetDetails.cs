using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DR874115_MIS4200.Models
{
    public class PetDetails
    {
        [Key]
        public int PetOwnerID { get; set; }
        public int PetID { get; set; }
        public virtual Pets Pets { get; set; }
        public int OwnerID { get; set; }
        public virtual Owners Owners { get; set; }

    }
}