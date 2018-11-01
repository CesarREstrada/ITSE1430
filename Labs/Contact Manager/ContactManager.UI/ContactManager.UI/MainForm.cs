// Cesar Estrada
// November 5, 2018
// ITSE 1430 MW 5pm
// MainForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactManager;
using ContactManager.Memory;

namespace ContactManager.UI
{
	public partial class MainForm : Form
	{
		#region Contruction

		public MainForm()
		{
			InitializeComponent();
		}

		#endregion

		#region Event Handlers

		private void OnFileExit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to exit the Contact Manager?",
					"Close", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
				return;

			Close();
		}

		private void OnContactNew_Click(object sender, EventArgs e)
		{
			var form = new ContactForm();
			if (form.ShowDialog(this) == DialogResult.Cancel)
				return;

			_database.Add(form.Contact);
			RefreshContacts();
		}

		private void OnContactEdit_Click(object sender, EventArgs e)
		{
			EditContact();
		}

		private void OnContactDelete_Click(object sender, EventArgs e)
		{
			DeleteContact();
		}

		private void OnHelpAbout_Click(object sender, EventArgs e)
		{
			MessageBox.Show(this, "Cesar Estrada\n ITSE 1430\n Contact Manager",
				"About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		#endregion


		private IContactDatabase _database = new MemoryContactDatabase();

		
	}
}
