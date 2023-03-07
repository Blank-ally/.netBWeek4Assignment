using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate.Services
{
    internal class MovieList
    {
       List<Movie> movies = new List<Movie>();

    

        List<String> title = new List<string>();
        List<Int64> Id = new List<Int64>();

        public List<Movie> ListOfMovies { get; set; }
        public void AddMovie(Movie movie)
        {
           
            title.Add(movie.Title);
            Id.Add(movie.ID);
            movies.Add(movie);
        }

        public int getMovies()

        {
           return movies.Count();
        }

      

        public void getMovieTitles()
        {
            foreach (String title in title)
            {
                Console.WriteLine($"Title:{title}");
            }
        }
        public void getMovieIDs()
        {
            foreach (Int64 id in Id) {
                Console.WriteLine($"ID:{id}");

            }
        }


    }
}
