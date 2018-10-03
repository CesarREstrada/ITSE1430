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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();			
		}

		private void onExit(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to EXIT?", "Close", MessageBoxButtons.YesNo) == DialogResult.No)
				return;
			Close();
		}

		private void OnHelpAbout(object sender, EventArgs e)
		{
			MessageBox.Show(this, "Cesar Estrada\n ITSE-1430 MW 5pm\n Character Creator", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void OnCharacterNew(object sender, EventArgs e)
		{
			var form = new CharacterForm();
			if (form.ShowDialog(this) == DialogResult.Cancel)
				return;
			Character = form.Character;

		}
		private Character Character;
	}
}
