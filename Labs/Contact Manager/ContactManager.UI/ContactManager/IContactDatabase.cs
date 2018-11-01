// Cesar Estrada
// November 5, 2018
// ITSE 1430 MW 5pm
// IContactDatabase.cs
using System.Collections.Generic;

namespace ContactManager
{
	public interface IContactDatabase
	{
		void Add(Contact contact);
		void Edit(string name, Contact contact);
		IEnumerable<Contact> GetAll();
		void Remove(string name);
	}
}