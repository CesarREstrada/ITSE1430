using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{	
	public class CharacterDatabase
	{
		#region Construction

		/// <summary> Initializes an instance of the <see cref="CharacterDatabase"/> class.</summary>
		/// <remarks>
		/// The database is seeded with some characters
		/// </remarks>		
		public CharacterDatabase() : this(true)
		{ }

		/// <summary> Initializes an instance of the <see cref="CharacterDatabase"/>/// </summary>
		/// <param name="seed">true to seed the database with characters.</param>
		public CharacterDatabase (bool seed) : this(GetSeedCharcters(seed))
		{ }

		/// <summary> Initializes an instance of the <see cref="CharacterDatabase"/>/// </summary>
		/// <param name="characters">true to seed the database with characters.</param>
		public CharacterDatabase (Character[] characters)
		{
			for (var index = 0; index < characters.Length; ++index)
				_characters[index] = _characters[index];
		}
		#endregion

		/// <summary>Adds a movie to the database.</summary>
		/// <param name="charactor">The movie to add.</param>
		public void Add (Character character)
		{
			var index = FindNextFreeIndex();
			if (index >= 0)
				_characters[index] = character;
		}

		/// <summary>Gets all the characters.</summary>
		/// <returns>The list of characters.</returns>
		public Character[] GetAll()
		{
			// how many character in total
			var count = 0;
			foreach (var character in _characters)
			{
				if (character != null)
					++count;
			};

			var temp = new Character[count];
			var index = 0;
			foreach (var character in _characters)
			{
				if (character != null)
					temp[index++] = character;
			};

			return temp;
		}

		/// <summary>Edits an existing character.</summary>
		/// <param name="name">The character to edit.</param>
		/// <param name="character">The new character.</param>
		public void Edit(string name, Character character)
		{
			// Find movie by name
			Remove(name);

			// Replace it
			Add(character);
		}
		
		/// <summary>Removes a character.</summary>
		/// <param name="name">The character to remove.</param>
		public void Remove(string name)
		{
			for (var index = 0; index < _characters.Length; ++index)
			{
				if (String.Compare(name, _characters[index]?.Name, true) == 0)
				{
					_characters[index] = null;
					return;
				};
			};
		}

		#region Private Members		

		private int FindNextFreeIndex()
		{
			for (var index = 0; index < _characters.Length; ++index)
			{
				if (_characters[index] == null)
					return index;
			}
			return -1;
		}

		// Gets some movies to see database with
		private static Character[] GetSeedCharcters(bool seed)		//******************************************************** this is not right **************************
		{
			if (!seed)
				return new Character[0];

			var characters = new Character[0];  			

			return characters;
		}	
			   		 	  
		// Array for character to be added too
		private Character[] _characters = new Character[100];
		#endregion
	}
}
