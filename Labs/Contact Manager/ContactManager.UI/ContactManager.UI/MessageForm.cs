// Cesar Estrada
// November 5, 2018
// ITSE 1430 MW 5pm
// SendMessage.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.UI
{
	public partial class MessageForm : Form
	{
		public MessageForm()
		{
			InitializeComponent();
		}


		#region Event Handlers

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
