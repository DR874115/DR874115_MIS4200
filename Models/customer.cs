﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DR874115_MIS4200.Models
{
	public class customer
	{

		public int customerID { get; set; }
		[Display(Name = "First Name")]
		public string customerFirstName { get; set; }
		public string customerLastName { get; set; }
		public string email { get; set; }
		public string phone { get; set; }
		public DateTime customerSince  { get; set; }
		public ICollection<Orders> Orders { get; set; }
		public string fullName {
			get
			{
				return customerLastName + ", " + customerFirstName;
			}
		} //only use GET (not SET) because SET lets you change the item
	}
}