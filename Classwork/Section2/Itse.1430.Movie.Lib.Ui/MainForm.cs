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
        #region Construction

        public MainForm()
        {
            InitializeComponent();      // designer code goes here (initalized all the fields - propterty function) - initializes data
        }
        #endregion


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

            if (form.ShowDialog(this) == DialogResult.Cancel)   // will display the form (this) will make this window the child of the parent
                return;

            // MessageBox.Show("Adding movie");  // a pop up comes up displaying the message "Adding Movie"
            _database.Add(form.Movie);
            //Movie.Name = "";       //whips out the field ( you probably dont need this)
            RefreshMovies();
        }


        private MovieDatabase _database = new MovieDatabase();


        // This method can be overridden in a derived type
        protected virtual void SomeFunction()
        { }

        // this method MUST BE defined in a derived type
        //protected abstract void SomeAbstractFunction()
        

        //protected override void OnLoad ( EventArgs e)
        //{

        //}


        // type override first then Onload and press enter*******************************************************************
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            _listMovies.DisplayMember = "Name";            
            RefreshMovies();
        }

        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        //// to diplays movies for _listMovies
        //private void MainForm_Load( object sender, EventArgs e )
        //{            
        //    _listMovies.DisplayMember = "Name";
        //    // _listMovies.DisplayMember = "Description";        // overrides name and those not show name
        //    RefreshMovies();
        //}

        private void RefreshMovies()
        {
            var movies = _database.GetAll();

            _listMovies.Items.Clear();
            _listMovies.Items.AddRange(movies);
        }

        private Movie GetSelectedMovie()
        {
            return _listMovies.SelectedItem as Movie;            
        }

        private void OnMovieDelete( object sender, EventArgs e )
        {
            DeleteMovie();
        }

        private void OnMovieEdit( object sender, EventArgs e )
        {
            EditMovie();
        }

        // actions double click 
        private void OnMovieDoubleClick( object sender, EventArgs e )
        {
            EditMovie();
        }
        
        private void EditMovie()
        {
            // Get selecte4d movie, if any
            var item = GetSelectedMovie();
            if (item == null)
                return;
            // Show form with selected movie
            var form = new MovieForm();
            form.Movie = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            // add to database and refresh
            _database.Edit(item.Name, form.Movie);
            RefreshMovies();
        }

        private void OnListKeyUp( object sender, KeyEventArgs e )
        {
            if (e.KeyData == Keys.Delete)
            {
                DeleteMovie();
            }
                
        }

        private void DeleteMovie()
        {
            // Get selected movie, if any
            var item = GetSelectedMovie();
            if (item == null)
                return;

            // add to database and refresh
            _database.Remove(item.Name);
            RefreshMovies();
        }
    }
}
