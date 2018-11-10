// Cesar Estrada
// November 5, 2018
// ITSE 1430 MW 5pm
// MainForm.cs

using ContactManager.Memory;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ContactManager.UI
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

			_database.Seed();			
			_listContacts.DisplayMember = "Name";

			_database2.Seed();			
			_listMessages.DisplayMember = "Message";

			RefreshContacts();
		}		

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

		private void OnSendMessage_Click(object sender, EventArgs e)
		{
			// Get selected name, if any
			var item = GetSelectedContact();
			if (item == null)
				return;

			var form = new MessageForm();
			form.Contact = item;
			if (form.ShowDialog(this) == DialogResult.Cancel)
				return;

			_database2.Add(form.Contact);
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

		private void OnContactDoubleClick(object sender, EventArgs e)
		{
			EditContact();
		}

		private void OnListKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Delete)
			{
				DeleteContact();
			}
		}

		#endregion

		private void DeleteContact ()
		{
			// Get selected name, if any
			var itemName = GetSelectedContact();
			if (itemName == null)
				return;

			// Show form with selected name
			var form = new ContactForm();
			form.Contact = itemName;

			if (MessageBox.Show($"Are you sure you want to DELETE {itemName.Name}?", "Delete Character",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				return;

			//Get selected contact, if any
			var item = GetSelectedContact();
			if (item == null)
				return;

			// Remove from database and refresh
			_database.Remove(item.Name);
			RefreshContacts();
		}

		private void EditContact ()
		{
			//Get selected contact, if any
			var item = GetSelectedContact();
			if (item == null)
				return;

			//Show form with selected contact
			var form = new ContactForm();
			form.Contact = item;
			if (form.ShowDialog(this) == DialogResult.Cancel)
				return;

			//Update database and refresh
			_database.Edit(item.Name, form.Contact);
			RefreshContacts();
		}

		private void RefreshContacts()
		{
			var contacts = from m in _database.GetAll()
						   orderby m.Name
						   select m;			

			_listContacts.Items.Clear();
			_listContacts.Items.AddRange(contacts.ToArray());

			var messages = from m in _database2.GetAll()
						   orderby m.Name
						   select m;

			_listMessages.Items.Clear();
			_listMessages.Items.AddRange(messages.ToArray());
		}

		private Contact GetSelectedContact()
		{
			return _listContacts.SelectedItem as Contact;
		}

		#region Private Members

		private IContactDatabase _database = new MemoryContactDatabase();
		private IContactDatabase _database2 = new MemoryContactDatabase();		
		#endregion		
	}
}
