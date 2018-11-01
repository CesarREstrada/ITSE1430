// Cesar Estrada
// November 5, 2018
// ITSE 1430 MW 5pm
// SeedDataBase.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
	public static class ContactDatabaseExtensions
	{
		public static void Seed(this IContactDatabase source)
		{
			var contacts = new[] {
				new Contact(){
					Name = "Test1",
					EmailAddress = "testemail1@gmail.com",
				},
				new Contact() {
				Name = "Test2",
				EmailAddress = "testemail2@gmail.com"
				},
			};
			Seed(source, contacts);
		}

		public static void Seed(this IContactDatabase source, Movie[] contact)
		{
			foreach (var contact in contacts)
				source.Add(contact);
		}

	}
}
