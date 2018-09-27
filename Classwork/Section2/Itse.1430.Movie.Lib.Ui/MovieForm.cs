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
    public partial class MovieForm : Form
    {
        public MovieForm()
        {
            InitializeComponent();
        }

        public Movie Movie;

        private void onCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;  // sets the dialogResult to cancel to tell the computer what to do
            Close(); // closes the add movie window
        }

        private void onSave( object sender, EventArgs e )
        {
            var movie = new Movie();
            var movie2 = new Movie();           //creats a new movie out of scope of 1st movie
            var name = movie2.GetName();        // strings start off as NULL
            
            // Name is required
            movie.SetName(_txtName.Text);                   // passing to Movie.cs to store the data**********************************************
            if (String.IsNullOrEmpty(_txtNameLabel.Text))
                return;

            movie.SetDescription(_txtDescription.Text);

            // Release year is a numeric value if set
            movie.SetReleaseYear(GetIn32(_txtReleaseYear));
            var releaseYear = GetIn32(_txtReleaseYear);
            if (releaseYear < 0)
                return;

            // Run length, if set  you have to the dot operator***********************************************
            movie.SetRunLenght(GetIn32(_txtRunLenght));
            var runLenght = GetIn32(_txtRunLenght);
            if (releaseYear < 0)
                return;
            
            Movie = movie;
            DialogResult = DialogResult.OK;  // if they click save we return ok
            Close();
        }

        // Helper function
        private int GetIn32 ( TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text))
                return 0;

            if (Int32.TryParse(textBox.Text, out var value))
                return value;

            return -1;
        }
    }
}
