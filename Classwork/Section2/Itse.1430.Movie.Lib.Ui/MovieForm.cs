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

        public Movie Movie { get; set; }

        private void onCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;  // sets the dialogResult to cancel to tell the computer what to do
            Close(); // closes the add movie window
        }

        private void onSave( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;

            //var movie = new Movie();            
            //movie.Name = _txtName.Text;           
            //movie.Description = _txtDescription.Text;           
            //movie.ReleaseYear = GetIn32(_txtReleaseYear);                
            //movie.RunLenght = GetIn32(_txtRunLenght);           
            //movie.IsOwned = _chkOwned.Checked;

            // Initializer syntax           
            var movie = new Movie() {                           // only works in the context of the new             
                Name = _txtName.Text,           
                Description = _txtDescription.Text,           
                ReleaseYear = GetIn32(_txtReleaseYear),                
                RunLenght = GetIn32(_txtRunLenght),           
                IsOwned = _chkOwned.Checked,
            }; 

            Movie = movie;
            DialogResult = DialogResult.OK;  // if they click save we return ok
            Close();
        }

        // Helper function
        private int GetIn32 ( TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text))
                return -1;

            if (Int32.TryParse(textBox.Text, out var value))
                return value;

            return -1;
        }

                
		private void MovieForm_Load(object sender, EventArgs e)
		{
            if ( Movie != null)
            {
                _txtName.Text = Movie.Name;
                _txtDescription.Text = Movie.Description;
                _txtReleaseYear.Text = Movie.ReleaseYear.ToString();
                _txtRunLenght.Text = Movie.RunLenght.ToString();
                _chkOwned.Checked = Movie.IsOwned;
            };

           // ValidateChildren();     // YOU DONT REALLY NEED THIS IF YOU DONE WANT
		}


        //Validates it there is a name in the name text box Use events  focus validating
        private void OnValidateName( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _error.SetError(control, "Name is required");
                e.Cancel = true;
            } else
                _error.SetError(control, "");
        }

        private void OnValidatingReleaseYear( object sender, CancelEventArgs e )
        {
           var control = sender as TextBox;
           var result = GetIn32(control);
            if (result < 1900)
            {
                _error.SetError(control, "Must Be greater than 1900");
                e.Cancel = true;
            } else
                _error.SetError(control, "");
        }

        // you can use this for validating the atributes for you lab 2 for 50%(maybe)
        private void OnValidatingRunLength( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;
            var result = GetIn32(control);
            if (result < 0)
            {
                _error.SetError(control, "Must be greater than 0");
                e.Cancel = true;
            } else
                _error.SetError(control, "");
        }
    }
}
