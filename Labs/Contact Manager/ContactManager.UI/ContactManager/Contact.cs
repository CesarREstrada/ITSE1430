// Cesar Estrada
// November 5, 2018
// ITSE 1430 MW 5pm
// Contact.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Contact : IValidatableObject
	{
		public string Name
		{
			get => _name ?? "";
			set => _name = value;
		}
		private string _name = "";

		public string EmailAddress
		{
			get => _emailAddress ?? "";
			set => _emailAddress = value;
		}
		private string _emailAddress;
    }

	public IEnumerable<ValidationResult> Validate( ValidationContext validationContext )
	{
		if (String.IsNullOrEmpty(Name))
			yield return new ValidationResult("Name is requried.", new[] { nameof(Name) });

		if (String.IsNullOrEmpty(EmailAddress))
			yield return new ValidationResult("Name is requried.", new[] { nameof(EmailAddress) });
	}
}
