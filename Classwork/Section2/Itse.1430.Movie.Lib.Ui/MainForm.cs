using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itse._1430.Movie.Lib.Ui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // file - exit
        private void eExitToolStripMenuItem_Click( object sender, EventArgs e )
        {
            // this logic only works with the file exit menu to close the window for asking the user before closing
            // the if statment asks the user wants to close the window
            if (MessageBox.Show("Are you sure you want to exit?", "Close", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            // closes the form when user selects file exit
            Close(); 
        }

        // help - about
        private void OnHelpAbout( object sender, EventArgs e )
        {
            
            // Sorry is the message in the box. Help is the title of the pop of box.
            // this and message box icon have to be in that order the window will center on the main(parent) window
            MessageBox.Show(this, "Sorry", "Help", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
