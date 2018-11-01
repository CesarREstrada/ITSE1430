// Cesar Estrada
// November 5, 2018
// ITSE 1430 MW 5pm
// ContactDatabase.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
	public abstract class ContactDatabase : IContactDatabase
	{
		public void Add(Contact contact)
		{
			if (contact == null)
				return;

			AddCore(contact);
		}

		protected abstract void AddCore(Contact contact);

		public IEnumerable<Contact> GetAll()
		{
			return GetAllCore();
		}

		protected abstract IEnumerable<Contact> GetAllCore();

		public void Edit(string name, Contact contact)
		{
			if (String.IsNullOrEmpty(name))
				return;
			if (contact == null)
				return;

			var existing = FindByName(name);
			if (existing == null)
				return;
		}

		protected abstract Contact FindByName(string name);

		protected abstract void EditCore(Contact oldContact, Contact newContact);;

		public void Remove(string name)
		{
			if (String.IsNullOrEmpty(name))
				return;

			RemoveCore(name);
		}

		protected abstract void RemoveCore(string name);
		
	}
}
