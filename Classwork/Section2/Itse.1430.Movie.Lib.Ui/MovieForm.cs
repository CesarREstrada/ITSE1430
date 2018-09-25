using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itse._1430.MovieLib.Ui
{
    public partial class MovieForm : Form
    {
        public MovieForm()
        {
            InitializeComponent();
        }

        private void onCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;  // sets the dialogResult to cancel to tell the computer what to do
            Close(); // closes the add movie window
        }

        private void onSave( object sender, EventArgs e )
        {
            var movie = new Movie();

            
            // Name is required
            movie.Name = _txtName.Text;
            if (String.IsNullOrEmpty(_txtNameLabel.Text))
                return;

            movie.Description = _txtDescription.Text;

            // Release year is a numeric value if set
            movie.releaseYear = GetIn32(_txtReleaseYear);
            var releaseYear = GetIn32(_txtReleaseYear);
            if (releaseYear < 0)
                return;

            // Run length, if set
            movie.runLenght = GetIn32(_txtRunLenght);
            var runLenght = GetIn32(_txtRunLenght);
            if (releaseYear < 0)
                return;

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
