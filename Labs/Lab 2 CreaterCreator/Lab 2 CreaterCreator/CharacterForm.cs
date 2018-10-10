using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterCreator;

namespace Lab_2_CreaterCreator
{
	public partial class CharacterForm : Form
	{
		#region Construction

		public CharacterForm()
		{
			InitializeComponent();
		}
		#endregion

		public Character Character { get; set; }

		private void CharacterForm_Load(object sender, EventArgs e)
		{
			if (Character != null)
			{
				_txtName.Text = Character.Name;
				
				_txtDescription.Text = Character.Description;
			}
		}

		#region Event Handlers

		private void OnCancel(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void OnSave(object sender, EventArgs e)
		{
			var character = new Character();

			// Name is required
			character.Name = _txtName.Text;
			if (String.IsNullOrEmpty(character.Name))
				return;

			character.Profession = _cbxProfession.Text;

			// release year

			// Run length

			character.Description = _txtDescription.Text;

			//movie.IsOwned = _chkOwned.Checked;

			Character = character;
			DialogResult = DialogResult.OK;
			Close();
		}
		#endregion

		#region Private Members
		// Helper function
		private int GetIn32(TextBox textBox)
		{
			if (String.IsNullOrEmpty(textBox.Text))
				return 0;

			if (Int32.TryParse(textBox.Text, out var value))
				return value;

			return -1;
		}
		#endregion
	}
}
