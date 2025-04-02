using System.Runtime.CompilerServices;

namespace Övning_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Comedy("The Lost City", 125, 23));
            movies.Add(new Comedy("Murder Mystery", 119, 12));
            movies.Add(new Action("The Continental", 112, 97));
            movies.Add(new Action("Mission Impossible", 134, 245));
            movies.Add(new SciFi("The Creator", 142, 12));
            movies.Add(new SciFi("Dune", 153, 9));

            foreach (Movie movie in movies)
            {

                movie.ShowMovie();

            }
        }
    }
}
