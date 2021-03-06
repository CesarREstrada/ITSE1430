﻿using System;
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
	public partial class MainForm : Form
	{
		#region Construction

		public MainForm()
		{
			InitializeComponent();			
		}
		#endregion

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			_listCharacters.DisplayMember = "Name";			
			RefreshCharacters();
		}
		
		#region Event Handlers

		private void onExit(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to EXIT?", "Close", MessageBoxButtons.YesNo, 
				MessageBoxIcon.Question) == DialogResult.No)
				return;

			Close();
		}
				
		private void OnCharacterNew( object sender, EventArgs e)
		{
			var form = new CharacterForm();
			if (form.ShowDialog(this) == DialogResult.Cancel)
				return;
			
			_database.Add(form.Character);
			RefreshCharacters();
		}
		
		private void OnEditCharacter(object sender, EventArgs e)
		{			
			EditCharacter();
		}

		private void OnDeleteCharacter(object sender, EventArgs e)
		{
			DeleteCharacter();
		}

		private void OnDoubleClick(object sender, EventArgs e)
		{
			EditCharacter();
		}

		private void OnHelpAbout(object sender, EventArgs e)
		{
			MessageBox.Show(this, "Cesar Estrada\n ITSE-1430 MW 5pm\n Character Creator", "About",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		#endregion

		#region Private Members

		private void DeleteCharacter()
		{
			// Get selected name, if any
			var itemName = GetSelectedCharacter();
			if (itemName == null)
				return;

			// Show form with selected name
			var form = new CharacterForm();
			form.Character = itemName;
		
			if (MessageBox.Show($"Are you sure you want to DELETE {itemName.Name}?", "Delete Character", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				return;

			// Get selected movie, if any
			var item = GetSelectedCharacter();
			if (item == null)
				return;

			// Remove from database and refresh
			_database.Remove(item.Name);
			RefreshCharacters();
		}

		private void EditCharacter()
		{
			// Get selected name, if any
			var item = GetSelectedCharacter();
			if (item == null)
				return;

			// Show form with selected name
			var form = new CharacterForm();
			form.Character = item;
			if (form.ShowDialog(this) == DialogResult.Cancel)
				return;

			// Update database and refresh
			_database.Edit(item.Name, form.Character);
			RefreshCharacters();			
		}

		private void RefreshCharacters()
		{
			var characters = _database.GetAll();

			_listCharacters.Items.Clear();
			_listCharacters.Items.AddRange(characters);
		}

		private Character GetSelectedCharacter()
		{
			return _listCharacters.SelectedItem as Character;
		}

		private CharacterDatabase _database = new CharacterDatabase();

		#endregion

		private void OnListKeyup(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Delete)
			{
				DeleteCharacter();
			}
		}	
	}
}
