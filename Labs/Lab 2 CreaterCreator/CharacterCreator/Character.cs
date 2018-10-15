using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CharacterCreator
{
	public class Character
	{
		// Property to back the Name fields
		public string Name
		{
			get { return _name ?? ""; } // string get ()
			set { _name = value; }
		}
		// Backing field for Name
		private string _name = "";

		public string Profession { get; set; }	

		public string Race { get; set; }

		// Attributes
		public int Strenght { get; set; } = 50;

		public int Intelligence { get; set; } = 50;

		public int Agility { get; set; } = 50;

		public int Constitution { get; set; } = 50;

		public int Charisma { get; set; } = 50;

		// Property to back the Description fields
		public string Description
		{
			get { return _description ?? ""; }
			set { _description = value; }
		}
		// Backing field for Description
		private string _description;


		//public object Items;
	}
}
