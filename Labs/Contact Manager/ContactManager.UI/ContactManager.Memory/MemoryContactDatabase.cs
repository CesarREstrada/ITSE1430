using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Memory
{
	public class MemoryContactDatabase : ContactDatabase
	{
		protected override void AddCore(Contact contact) => _items.Add(contact);

		protected override IEnumerable<Movie> GetAllCore();
		{
			//return _items.Select(item => new Movie()
			//{
			//	Name = item.Name,
			//	Description = item.Description,
				
			//});
		}
	}

	protected override void EditCore(Contact oldContact, Contact newContact)
		{
			_items.Remove(oldContact);

			_items.Add(newContact);
		}

		protected override void RemoveCore(string name)
		{
			var contact = FindByName(name);
			if (contact != null)
				_items.Remove(contact);
		}

		protected override Contact FindByName(string name)
		{
			return _items.FirstOrDefault(m => String.Compare(name, m.Name, true) == 0);

			// SQL syntax
			//return (from m in _items
			//		where String.Compare(name, m.Name, true) == 0
			//		select m).FirstOrDefault();
		}

		private List<Contact> _items = new List<Contact>();
	}	
}
