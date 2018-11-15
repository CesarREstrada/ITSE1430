using System;
using System.Collections.Generic;
using System.Data;
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
            using (var conn = CreateConnection())     // base connection the using statment (IDisposable) will close the connection
            {
                //var cmd = new SqlCommand("AddMovie", conn);
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UpdateMovie";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                var id = GetMovieId(oldMovie); 
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@title", newMovie.Name);
                cmd.Parameters.AddWithValue("@length", newMovie.RunLength);
                cmd.Parameters.AddWithValue("@isOwned", newMovie.IsOwned);
                cmd.Parameters.AddWithValue("@description", newMovie.Description);

                conn.Open();                // may be able to use the data adapter to open the connection in GetAllCore
                cmd.ExecuteNonQuery();
            };
        }

        //Gets the ID if this is a SQL movie
        private object GetMovieId( Movie movie )
        {
            var sql = movie as SqlMovie;

            return sql?.Id ?? 0;
        }

        protected override Movie FindByName( string name )
        {
            // Using a data reader  *********************************************************************************************************
            using (var conn = CreateConnection())
            {
                var da = new SqlDataAdapter();
                var cmd = new SqlCommand("GetAllMovies", conn);
                cmd.CommandType = CommandType.StoredProcedure;        // the fill method generates the DataTable[] for Data visulizer

                conn.Open();
                using (var reader = cmd.ExecuteReader())        // ExcuteReader will never return NULL
                {
                    while (reader.Read())       // must use a while loop to read the first row
                    {
                        var movieName = reader.GetString(1);
                        if (String.Compare(movieName, name, true) != 0)
                            continue;

                        //reader.GetOrdinal("Id");

                        return new SqlMovie() {
                            Id = reader.GetFieldValue<int>(0),
                            Name = movieName,
                            Description = Convert.ToString(reader.GetValue(2)),
                            ReleaseYear = 1900,
                            RunLength = reader.GetFieldValue<int>(3),
                            IsOwned = reader.GetBoolean(4),
                        };
                    };
                };

            };

            return null;
        }

        //
        protected override IEnumerable<Movie> GetAllCore()
        {
           // Using a DataSet ************************************************************************************************************************************
            var ds = new DataSet();     // data visulizer here after break point is set on the return new Movie[0]******************************************************

            using (var conn = CreateConnection())
            {
                var da = new SqlDataAdapter();
                var cmd = new SqlCommand("GetAllMovies", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                da.SelectCommand = cmd;         // data adatper will automatically OPEN the connection and CLOSEd the connection for you
                da.Fill(ds);        // the fill method generates the DataTable[] for Data visulizer

            };

            // Read data
           // if(!ds.Tables.OfType<DataTable>().Any())        // ofType implents IEnumarable<T>
           //     return Enumerable.Empty<Movie>();

            var table = ds.Tables.OfType<DataTable>().FirstOrDefault();    //fetches the first table or null
            if (table == null)
                return Enumerable.Empty<Movie>();

            var movies = new List<Movie>();
            foreach (var row in table.Rows.OfType<DataRow>())
            {
                var movie = new SqlMovie() {                    
                    Id = Convert.ToInt32(row["Id"]),            // convert to a int
                    Name = row.Field<string>("Title"),           // does the string conversion behind the sences
                    Description = Convert.ToString(row[2]),     // another way to convert to a string
                    ReleaseYear = 1900,
                    RunLength = row.Field<int>(3),
                    IsOwned = Convert.ToBoolean(row[4]),
                };
                movies.Add(movie);
            };

            return movies;
            //throw new NotImplementedException();
            //return new Movie[0];
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
