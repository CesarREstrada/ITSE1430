using System;
using System.Collections.Generic;           // list only available with this header
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

            return new [] {            
                new Movie() {
                    Name = "Jaws",
                    RunLenght = 120,
                    ReleaseYear = 1977,
                },
                new Movie() {
                    Name = "What about Bob?",
                    RunLenght = 96,
                    ReleaseYear = 2004,
                },
            };
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
            _items.AddRange(movies);
            //for (var index = 0; index < movies.Length; ++index)
            //    _movies[index] = movies[index];
        }

        public void Add ( Movie movie)
        {
            _items.Add(movie);

            //var index = FindNextFreeIndex();
            //if (index >= 0)
            //    _movies[index] = movie;
        }

        //private int FindNextFreeIndex ()
        //{
        //    for (var index = 0; index < _movies.Length; ++index)
        //    {
        //        if (_movies[index] == null)
        //            return index;
        //    };
        //    return -1;
        //}

        //an array for movies to be added too
        //private Movie[] _movies = new Movie[100];
        private List<Movie> _items = new List<Movie>();   // lab 3


        public Movie[] GetAll()
        {
            // how many movies we have
            
            var count = _items.Count;

            foreach (var movie in _items)
            {
                if (movie != null)
                    ++count;
            };

            var temp = new Movie[count];
            var index = 0;

            foreach (var movie in _items)
            {
                temp[index++] = movie;
            };

            return temp;
            //var count = 0;
            //foreach (var movie in _movies)
            //{
            //    if (movie != null)
            //        ++count;
            //};



            //foreach ( var movie in _movies)
            //{
            //    if (movie != null)
            //        temp[index++] = movie;      

            //};

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
            var movie = FindMovie(name);

            if (movie != null)
                _items.Remove(movie);
                

            //for (var index = 0; index < _movies.Length; ++index)
            //{
            //    if (String.Compare(name, _movies[index]?.Name, true) == 0)
            //    {
            //        _movies[index] = null;
            //        return;
            //    };
            //};
        }

        private Movie FindMovie ( string name)
        {
            //var pairs = new Dictionary<string, Movie>();

            //for (var index = 0; index < _movies.Length; ++index)
            foreach (var movie in _items)            
            {
                //if (String.Compare(name, _movies[index]?.Name, true) == 0)
                if (String.Compare(name, movie.Name, true) == 0)
                    return movie;
            };

            return null;
        }
    }
}
