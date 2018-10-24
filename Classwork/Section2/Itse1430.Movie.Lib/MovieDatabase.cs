﻿using System;
using System.Collections.Generic;           // list only available with this header
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.MovieLib
{
    public abstract class MovieDatabase : IMovieDatabase
    {       
        public void Add ( Movie movie)
        {
            // TODO: Validate
            if (movie == null)
                return;

            AddCore(movie);          
        }

        protected abstract void AddCore( Movie movie );

        public IEnumerable<Movie> GetAll()
        {
            return GetAllCore();
        }

        protected abstract IEnumerable<Movie> GetAllCore();

        public void Edit (string name, Movie movie)
        {
            // TODO: Validate
            if (String.IsNullOrEmpty(name))
                return;
            if (movie == null)
                return;

            //Find movie by name
            var existing = FindByName(name);
            if (existing == null)
                return;

            EditCore(existing, movie);
        }

        protected abstract Movie FindByName( string name );

        protected abstract void EditCore( Movie oldMovie, Movie newMovie );

        public void Remove (string name)
        {
            // TODO: Validate
            if (String.IsNullOrEmpty(name))
                return;

            RemoveCore(name);
        }

        protected abstract void RemoveCore( string name );
    }
}