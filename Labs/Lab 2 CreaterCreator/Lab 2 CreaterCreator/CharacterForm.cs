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
		public CharacterForm()
		{
			InitializeComponent();
		}

		public Character Character;

		private void OnCancel(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		// Helper function
		private int GetIn32(TextBox textBox)
		{
			if (String.IsNullOrEmpty(textBox.Text))
				return 0;

			if (Int32.TryParse(textBox.Text, out var value))
				return value;

			return -1;
		}
	}
}
