using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itse1430.MovieLib;

namespace Itse1430MovieLib.SQL          // in programming it should be Sql
{
    public class SQLMoviedDatebase : MovieDatabase      // using for movie database // SQL impent abstract extraction
    {
        protected override void AddCore( Movie movie )
        {
            throw new NotImplementedException();
        }

        protected override void EditCore( Movie oldMovie, Movie newMovie )
        {
            throw new NotImplementedException();
        }

        protected override Movie FindByName( string name )
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<Movie> GetAllCore()
        {
            throw new NotImplementedException();
        }

        protected override void RemoveCore( string name )
        {
            throw new NotImplementedException();
        }
    }
}
