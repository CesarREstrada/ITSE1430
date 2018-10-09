using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{	
	public class CharacterDatabase
	{
		// Array for character to be added too
		private Character[] _characters = new Character[100];

		public CharacterDatabase() : this(true)
		{ }

		private static Character[] GetSeedCharcters(bool seed)
		{
			if (!seed)
				return new Character[0];

			var characters = new Character[2];			// may not need this
			
			return characters;
		}

		public CharacterDatabase(bool seed) : this(GetSeedCharcters(seed))
		{ }

		// Constructor
		public CharacterDatabase(Character[] characters)
		{
			for (var index = 0; index < characters.Length; ++index)
				_characters[index] = _characters[index];
		}

		private int FindNextFreeIndex()
		{
			for (var index = 0; index < _characters.Length; ++index)
			{
				if (_characters[index] == null)
					return index;
			}
			return -1;
		}

		public Character[] GetAll()
		{
			// how many character in total
			var count = 0;
			foreach (var character in _characters)
			{
				if (character != null)
					++count;
			}

			var temp = new Character[count];
			var index = 0;
			foreach (var character in _characters)
			{
				if (character != null)
					temp[index++] = character;
			}
			return temp;		
		}

		public void Edit (string name, Character character)
		{
			// Find movie by name
			//Remove(name);

			// replace it
			//Add(character);
		}

		public void Remove (string name)
		{
			for (var index = 0; index < _characters.Length; ++index)
			{
				if (String.Compare(name, _characters[index]?.Name, ture) == 0)
				{
					_characters[index] = null;
					return;
				}
			}
		}
	}
}
