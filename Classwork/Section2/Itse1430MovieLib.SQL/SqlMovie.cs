using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itse1430.MovieLib;

namespace Itse1430MovieLib.SQL
{
    // Provides additional information for the SQL database (wrapping movie with a private type. Allows us to hide data with we pass the movie around)
    internal class SqlMovie : Movie
    {
       // public int Id { get; set; }

    }
}
