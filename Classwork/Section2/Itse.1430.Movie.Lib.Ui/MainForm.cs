using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Itse1430.MovieLib;

namespace Itse._1430.MovieLib.Ui
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
            // the if statement asks the user wants to close the window
            if (MessageBox.Show("Are you sure you want to exit?", "Close", MessageBoxButtons.YesNo) == DialogResult.No) // dialogResult is a enum (glorified named constants)
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

        private void OnMovieAdd( object sender, EventArgs e ) // highlight and right click rename to change name symbolically and click apply
        {
            var form = new MovieForm(); // creates new movie

           if(form.ShowDialog(this) == DialogResult.Cancel)   // will display the form (this) will make this window the child of the parent
                return;

            // MessageBox.Show("Adding movie");  // a pop up comes up displaying the message "Adding Movie"
            Movie = form.Movie;
            //Movie.Name = "";       //whips out the field ( you probably dont need this)
         }

        private Movie Movie;
        
    }
}
