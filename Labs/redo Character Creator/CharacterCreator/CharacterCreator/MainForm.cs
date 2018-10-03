using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to Exit?", "Close", MessageBoxButtons.YesNo) == DialogResult.No)
				return;

			Close();
		}

		private void _onHelpAbout(object sender, EventArgs e)
		{
			MessageBox.Show(this, "Cesar Estrada\nITSE-1430 MW 5pm\nCharacter Creator",
							"Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
