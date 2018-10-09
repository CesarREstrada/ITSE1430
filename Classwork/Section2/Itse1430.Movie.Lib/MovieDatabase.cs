using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.MovieLib
{
    public class MovieDatabase
    {
        // default constructor
        public MovieDatabase() : this(true)
        {  }

        private static Movie[] GetSeedMovies (bool seed)
        {
            if (!seed)
                return new Movie[0];

            var movies = new Movie[2];

            movies[0] = new Movie();
            movies[0].Name = "Jaws";
            movies[0].RunLenght = 120;
            movies[0].ReleaseYear = 1977;
           

            movies[1] = new Movie();
            movies[1].Name = "What about Bob?";
            movies[1].RunLenght = 96;
            movies[1].ReleaseYear = 2004;

            return movies;
        }

        // Constructor that allows to provide a list a movies
        public MovieDatabase ( bool seed ) : this(GetSeedMovies(seed))
        {
            //if (seed)
            //{
            //    var movie = new Movie();
            //    movie.Name = "Jaws";
            //    movie.RunLenght = 120;
            //    movie.ReleaseYear = 1977;
            //    Add(movie);

            //    movie = new Movie();
            //    movie.Name = "What about Bob?";
            //    movie.RunLenght = 96;
            //    movie.ReleaseYear = 2004;
            //    Add(movie);
            //}
        }

        //constructor
        public MovieDatabase( Movie[] movies) // by defualt :base
        {

            for (var index = 0; index < movies.Length; ++index)
                _movies[index] = movies[index];
        }

        public void Add ( Movie movie)
        {
            var index = FindNextFreeIndex();
            if (index >= 0)
                _movies[index] = movie;
        }

        private int FindNextFreeIndex ()
        {
            for (var index = 0; index < _movies.Length; ++index)
            {
                if (_movies[index] == null)
                    return index;
            };
            return -1;
        }

        //an array for movies to be added too
        private Movie[] _movies = new Movie[100];

        public Movie[] GetAll()
        {
            // how many movies we have
            var count = 0;
            foreach (var movie in _movies)
            {
                if (movie != null)
                    ++count;
            };

            var temp = new Movie[count];
            var index = 0;
            foreach( var movie in _movies)
            {
                if (movie != null)
                    temp[index++] = movie;      
                
            };
            return temp;
        }

        public void Edit (string name, Movie movie)
        {
            // find movie by name
            Remove(name);

            // replace it
            Add(movie);
        }

        public void Remove (string name)
        {
            for (var index = 0; index < _movies.Length; ++index)
            {
                if (String.Compare(name, _movies[index]?.Name, true) == 0)
                {
                    _movies[index] = null;
                    return;
                };
            };
        }
    }
}
