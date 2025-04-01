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

                Console.WriteLine($"Filmen {movie.Title} är {movie.RunningTime} min lång, och har följande skådespelare:");
                foreach (var m in movie.Actors)
                {
                    Console.WriteLine($"{m.Name} (född {m.BirthYear})");
                }
                Console.Write($"Filmen innehåller ");

                if(movie.Title == "The Lost City" || movie.Title == "Murder Mystery")
                {
                    Console.WriteLine($"{((Comedy)movie).NumberOfFunnyScenes} roliga scener.");
                }
                else if (movie.Title == "The Continental" || movie.Title == "Mission Impossible")
                {
                    Console.WriteLine($"I filmen skjuts det {((Action)movie).NumberOfShotsFired} gånger.");
                }
                else
                {
                    Console.WriteLine($"Filmen innehåller minst {((SciFi)movie).NumberOfSpaceShips} rymdskepp");
                }

                    Console.WriteLine("-----------------------------------------");

            }
        }
    }
}
