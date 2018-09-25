using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.MovieLib
{
    public class Movie
    {
        public string Name;
        //public System.String Name;

        public string Description;

        public int ReleaseYear;
        public int RunLenght;

        int someValue;              // both of these are private(only accessable in this class Movie type only)
        private int someValue2;
    }
}
