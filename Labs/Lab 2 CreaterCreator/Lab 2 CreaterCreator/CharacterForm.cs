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
using System.Collections;

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
			BindProfession();
			BindRace();

			if (Character != null)
			{		
				
				_txtName.Text = Character.Name;	 				
				_cbxProfession.Text = Character.Profession;
				_cbxRace.Text = Character.Race;

				// Attributes				
				_txtAttrStrenght.Text = Character.Strenght.ToString();
				_txtAttrIntelligence.Text = Character.Intelligence.ToString();
				_txtAttrAgility.Text = Character.Agility.ToString();
				_txtAttrConstitution.Text = Character.Constitution.ToString();
				_txtAttrCharisma.Text = Character.Charisma.ToString();

				_txtDescription.Text = Character.Description;				
			}
		}

		private void BindProfession()
		{
			ArrayList arrProfession = new ArrayList();
			arrProfession.Add("Fighter");
			arrProfession.Add("Hunter");
			arrProfession.Add("Priest");
			arrProfession.Add("Rogue");
			arrProfession.Add("Wizard");
			_cbxProfession.DataSource = arrProfession;
			_cbxProfession.SelectedIndex = 0;
		}

		private void BindRace()
		{
			ArrayList arrRace = new ArrayList();
			arrRace.Add("Dwarf");
			arrRace.Add("Elf");
			arrRace.Add("Gnome");
			arrRace.Add("Half Elf");
			arrRace.Add("Human");
			_cbxRace.DataSource = arrRace;
			_cbxRace.SelectedIndex = 0;
		}

		#region Event Handlers

		private void OnCancel(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void OnSave(object sender, EventArgs e)
		{
			if (!ValidateChildren())
				return;

			var character = new Character();
			
			character.Name = _txtName.Text;			
			character.Profession = _cbxProfession.Text;			
			character.Race = _cbxRace.Text;

			// Attributes
			character.Strenght = GetIn32(_txtAttrStrenght);
			character.Intelligence = GetIn32(_txtAttrIntelligence);
			character.Agility = GetIn32(_txtAttrAgility);
			character.Constitution = GetIn32(_txtAttrConstitution);
			character.Charisma = GetIn32(_txtAttrCharisma);

			character.Description = _txtDescription.Text;			

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

		#region Validating

		private void OnValidateName(object sender, CancelEventArgs e)
		{
			var control = sender as TextBox;

			if (String.IsNullOrEmpty(control.Text))
			{
				_errors.SetError(control, "Name is required");
				e.Cancel = true;
			} else
				_errors.SetError(control, "");
		}

		private void OnValidatingStrength(object sender, CancelEventArgs e)
		{
			ValidatingAttributes(sender, e);
		}

		private void OnValidatingIntelligence(object sender, CancelEventArgs e)
		{
			ValidatingAttributes(sender, e);
		}		

		private void OnValidatingAgility(object sender, CancelEventArgs e)
		{
			ValidatingAttributes(sender, e);
		}

		private void OnValidatingConstitution(object sender, CancelEventArgs e)
		{
			ValidatingAttributes(sender, e);
		}

		private void OnValidatingCharisma(object sender, CancelEventArgs e)
		{
			ValidatingAttributes(sender, e);
		}

		private void ValidatingAttributes(object sender, CancelEventArgs e)
		{
			var control = sender as TextBox;
			var result = GetIn32(control);
			if (result < 1 || 100 < result)
			{
				_errors.SetError(control, "Must be between 1 and 100");
				e.Cancel = true;
			}
			else
				_errors.SetError(control, "");
		}
		#endregion
	}
}
