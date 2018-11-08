using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itse1430.MovieLib;

namespace Itse1430MovieLib.SQL          // in programming it should be Sql
{
    public class SqlMoviedDatebase : MovieDatabase      // using for movie database // SQL impent abstract extraction
    {
        public SqlMoviedDatebase( string connectionString )
        {
            //Validate
            if (connectionString == null)
                throw new ArgumentNullException(nameof(connectionString));
            if (connectionString == "")
                throw new ArgumentException("Connection string cannot be empty."
                            , nameof(connectionString));

            _connectionString = connectionString;
        }
        private readonly string _connectionString;

        protected override void AddCore( Movie movie )
        {
            //var conn = new SqlConnection(_connectionString);                        

            //var cmd = new SqlCommand("AddMovie", conn);
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //Approach 1
            //var param = new SqlParameter("@title", System.Data.SqlDbType.VarChar);
            //param.Value = movie.Name;
            //cmd.Parameters.Add(param);

            //Approach 2
            //var param = cmd.Parameters.Add("@title", System.Data.SqlDbType.VarChar);
            //param.Value = movie.Name;

            //Approach 3                                                // downside sql is very picking. if you say its a int sql will require 
            //cmd.Parameters.AddWithValue("@title", movie.Name);          //it to be an it and if not it will  fail or put a typecast cast to a int
            //cmd.Parameters.AddWithValue("@length", movie.RunLength);
            //cmd.Parameters.AddWithValue("@isOwned", movie.IsOwned);
            //cmd.Parameters.AddWithValue("@description", movie.Description);

            // Run Command
            //try
            using (var conn = CreateConnection())     // base connection
            {
                var cmd = new SqlCommand("AddMovie", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@title", movie.Name);       
                cmd.Parameters.AddWithValue("@length", movie.RunLength);
                cmd.Parameters.AddWithValue("@isOwned", movie.IsOwned);
                cmd.Parameters.AddWithValue("@description", movie.Description);

                conn.Open();
                var result = cmd.ExecuteScalar();
                var id = Convert.ToInt32(result);       // Converts a object to a int gives the id of the new movie
            };                                                      
            //} finally
            //{
            //    conn.Close();                   // closes connection
            //}    
        }

        protected override void EditCore( Movie oldMovie, Movie newMovie )
        {
            using (var conn = CreateConnection())     // base connection
            {
                //var cmd = new SqlCommand("AddMovie", conn);
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UpdateMovie";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                var id = GetMovieId(oldMovie); // temp hard code
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@title", newMovie.Name);
                cmd.Parameters.AddWithValue("@length", newMovie.RunLength);
                cmd.Parameters.AddWithValue("@isOwned", newMovie.IsOwned);
                cmd.Parameters.AddWithValue("@description", newMovie.Description);

                conn.Open();
                cmd.ExecuteNonQuery();
            };
        }

        private object GetMovieId( Movie oldMovie )
        {
            return 1;
        }

        protected override Movie FindByName( string name )
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<Movie> GetAllCore()
        {
            //throw new NotImplementedException();
            return new Movie[0];
        }

        protected override void RemoveCore( string name )
        {
            var movie = FindByName(name);
            if (movie == null)
                return;

            using (var conn = CreateConnection())     // base connection
            {                
                var cmd = conn.CreateCommand();
                cmd.CommandText = "RemoveMovie";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                var id = GetMovieId(movie); 
                cmd.Parameters.AddWithValue("@id", id);                

                conn.Open();
                cmd.ExecuteNonQuery();
            };
        }

        private SqlConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
