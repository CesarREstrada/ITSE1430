﻿using System;
using System.Collections.Generic;           // list only available with this header
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Itse1430.MovieLib.Memory
{
    public class MemoryMovieDatabase : MovieDatabase
    {
        /// <summary>Adds a movie to the database.</summary>
        /// <param name="movie">The movie to add.</param>
        protected override void AddCore( Movie movie )// => _items.Add(movie);     // Lamba
        {            
            //throw new Exception("Failed");
            _items.Add(movie);           

        }  
        //{
        //    _items.Add(movie);
        //    //var index = FindNextFreeIndex();
        //    //if (index >= 0)
        //    //    _movies[index] = movie;
        //}

        /// <summary>Gets all the movies.</summary>
        /// <returns>The list of movies.</returns>
        protected override IEnumerable<Movie> GetAllCore()
        {
            // var i = _items.ToArray();
            // return _items;


            // Use LINQ to clone  movies
            return from item in _items
                //where
                select new Movie() {               
                    Name = item.Name,
                    Description = item.Description,
                    ReleaseYear = item.ReleaseYear,
                    RunLength = item.RunLength,
                    IsOwned = item.IsOwned
                };

                //return _items.Select(item => new Movie()
                //{
                //    Name = item.Name,
                //    Description = item.Description,
                //    ReleaseYear = item.ReleaseYear,
                //    RunLength = item.RunLength,
                //    IsOwned = item.IsOwned
                //});

                //foreach (var item in _items)
                //    yield return new Movie()
                //    {
                //        Name = item.Name,
                //        Description = item.Description,
                //        ReleaseYear = item.ReleaseYear,
                //        RunLength = item.RunLength,
                //        IsOwned = item.IsOwned
                //    };

                ////How many movies do we have
                //var count = _items.Count;

                //var temp = new Movie[count];
                //var index = 0;
                //foreach (var movie in _items)
                //{
                //    temp[index++] = movie;
                //};

                //return temp;
            }

        // helper method  --  TODO: Temporary method to clone a movie
        //private Movie Clone( Movie item )
        //{
        //    return new Movie() {
        //        Name = item.Name,
        //        Description = item.Description,
        //        ReleaseYear = item.ReleaseYear,
        //        RunLength = item.RunLength,
        //        IsOwned = item.IsOwned
        //    };
        //}

        /// <summary>Edits an existing movie.</summary>
        /// <param name="name">The movie to edit.</param>
        /// <param name="movie">The new movie.</param>
        protected override void EditCore( Movie oldMovie, Movie newMovie )
        {
            //Find movie by name
            _items.Remove(oldMovie);

            //Replace it
            _items.Add(newMovie);
        }

        /// <summary>Removes a movie.</summary>
        /// <param name="name">The movie to remove.</param>
        protected override void RemoveCore( string name )
        {
            var movie = FindByName(name);
            if (movie != null)
                _items.Remove(movie);
        }

        #region Private Members

        protected override Movie FindByName( string name )
        {
            //Example with multiple type parameters
            //var pairs = new Dictionary<string, Movie>();

            //for (var index = 0; index < _movies.Length; ++index)
            //foreach (var movie in _items)
            //{
            //    //if (String.Compare(name, _movies[index]?.Name, true) == 0)
            //    if (String.Compare(name, movie.Name, true) == 0)
            //        return movie;
            //};

            //Use extension methods to get first item
            //return _items.Where(IsName).FirstOrDefault();       // can return null

            // LAMBDA****** the complier takes this and make a helper method (with closure "name,")
            //return _items.FirstOrDefault(m => String.Compare(name, m.Name, true) == 0); ********************* this ones better
            return (from m in _items
                   where String.Compare(name, m.Name, true) == 0
                   select m).FirstOrDefault();

            //return null;
        }

        //TODO: Temporary helper method to find movie by name
        //private bool IsName ( Movie movie )
        //{
        //    if (String.Compare(name, movie.Name, true) == 0)
        //        return true;

        //    return false;
        //}

        //private Movie[] _movies = new Movie[100];
        private List<Movie> _items = new List<Movie>();
        #endregion
    }
}
