// Cesar Estrada
// November 5, 2018
// ITSE 1430 MW 5pm
// Contact.cs

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Contact : IValidatableObject
	{
		// Property to back the name field
		public string Name
		{
			get => _name ?? "";
			set => _name = value;
		}
		// Backing field for name
		private string _name = "";

		// Property to back the email address field
		public string EmailAddress
		{
			get => _emailAddress ?? "";
			set => _emailAddress = value;
		}
		// Backing field for email address
		private string _emailAddress;		

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if (String.IsNullOrEmpty(Name))
				yield return new ValidationResult("Name is required.", new[] { nameof(Name) });

			if (String.IsNullOrEmpty(EmailAddress))
				yield return new ValidationResult("Name is required.", new[] { nameof(EmailAddress) });
		}
	}
	
}
