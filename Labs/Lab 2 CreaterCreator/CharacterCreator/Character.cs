using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CharacterCreator
{
	public class Character
	{
		// Property to back the name fields
		public string Name
		{
			get { return _name ?? ""; }	// string get ()
			set { _name = value; }
		}

		// Backing field for name
		private string _name = "";

		public string Profession
		{
			get { return _profession ?? ""; }
			set { _profession = value; }
		}
		private string _profession;

		public string Description
		{
			get { return _description ?? ""; }
			set { _description = value; }
		}
		private string _description;



		
    }
}
