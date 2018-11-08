using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Itse1430.MovieLib;
using Itse1430.MovieLib.Memory;
using Itse1430MovieLib.SQL;

namespace Itse._1430.MovieLib.Ui
{
    public partial class MainForm : Form
    {
        #region Construction

        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        //This method can be overridden in a derived type
        //protected virtual void SomeFunction ()
        //{ }

        //This method MUST BE defined in a derived type
        //protected abstract void SomeAbstractFunction();

        /// <summary></summary>
        /// <param name="e"></param>
        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);
                                                                   // for App.Config 
            var connString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;       // adds connection string
            _database = new SqlMoviedDatebase(connString);

            //TODO: Remove this line(test for errots)
           // _database.Add(new Movie());

           //Seed database
           //var seed = new SeedDatabase();
           //SeedDatabase.Seed(_database);
           //_database.Seed(); // its an instance member calls the SeedDatabase adding additional functionallity to a _database (.Seed) extention method

            _listMovies.DisplayMember = "Name";
            RefreshMovies();
        }

        #region Event Handlers

        private void OnFileExit( object sender, EventArgs e )
        {
            if (MessageBox.Show("Are you sure you want to exit?",
                        "Close", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            Close();
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            //aboutToolStripMenuItem.
            MessageBox.Show(this, "Sorry", "Help", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void OnMovieAdd( object sender, EventArgs e )
        {
            var form = new MovieForm();
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            //Add to database and refresh
            try
            {
                _database.Add(form.Movie);
            //} catch (ArgumentException ex)
            //{
            //    MessageBox.Show("Programmer messed up", "Error",
            //                MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    // Throw a different execption
            //    throw new InvalidOperationException("Programmer messed up"); // hinds the impentation for people how dont really know whats going on

            } catch (Exception ex) // normally we would use e instead of e becuase of the argument EventArgs e
            {
                MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // Log Failure
                // Crash app
                //throw ex; 0% of the time

                // Rethrow 95% of the time you will use
                //throw;
            };
            RefreshMovies();
        }

        private void OnMovieDelete( object sender, EventArgs e )
        {
           DeleteMovie();            
        }

        private void OnMovieEdit( object sender, EventArgs e )
        {           
                EditMovie();               
            
        }

        private void OnMovieDoubleClick( object sender, EventArgs e )
        {
            EditMovie();
        }

        private void OnListKeyUp( object sender, KeyEventArgs e )
        {
            if (e.KeyData == Keys.Delete)
            {
                DeleteMovie();
            };
        }
        #endregion

        #region Private Members

        private void DeleteMovie()
        {
            //Get selected movie, if any
            var item = GetSelectedMovie();
            if (item == null)
                return;

            //Remove from database and refresh
            try
            {
                _database.Remove(item.Name);
            } catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
            
            RefreshMovies();
        }

        private void EditMovie()
        {
            //Get selected movie, if any
            var item = GetSelectedMovie();
            if (item == null)
                return;

            //Show form with selected movie
            var form = new MovieForm();
            form.Movie = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            //Update database and refresh
            try
            {
                _database.Edit(item.Name, form.Movie);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };            
            RefreshMovies();
        }

        private void RefreshMovies()
        {
            // OrderBY
            //var movies = _database.GetAll();
            var movies = from m in _database.GetAll()
                         orderby m.Name
                         select m;

            _listMovies.Items.Clear();

           //TODO: Hard way
           // foreach (var movie in movies)
           //     _listMovies.Items.Add(movie);

           _listMovies.Items.AddRange(movies.ToArray());
        }

        private Movie GetSelectedMovie()
        {
            return _listMovies.SelectedItem as Movie;
        }

        private IMovieDatabase _database; // = new SqlMoviedDatebase();

        #endregion        
    }
}
