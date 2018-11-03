// Cesar Estrada
// November 5, 2018
// ITSE 1430 MW 5pm
// SendMessage.cs

using System;
using System.Windows.Forms;

namespace ContactManager.UI
{
	public partial class MessageForm : Form //IContactDatabase  //impleace inferace ex
	{
		public Contact Contact { get; internal set; }

		public MessageForm()
		{
			InitializeComponent();
		}

		#region Event Handlers

		//Contact contact = new Contact();
		//string value = Contact.Name;
		

		//MessageForm message = new MessageForm(Contact);

		//public Contact Contact { get; set; }
		//public Message Message { get; set; }
		//public new string Name { get; set; }

		private void MessageForm_Load(object sender, EventArgs e)
		{
			_txtName.Text = Contact.Name;
			_txtEmailAddress.Text = Contact.EmailAddress;			
		}

		private void OnSend_Click(object sender, EventArgs e)
		{

		}

		private void OnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}



		#endregion

		
	}
}
