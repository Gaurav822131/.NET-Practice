using System;
using System.Collections.Generic;
using System.Linq;

namespace movieStock
{
    class Program
    {
        static List<Movie> movieList = new List<Movie>();

        // Add Movie (manual input)
        public static void AddMovie()
        {
            Movie m = new Movie();

            Console.WriteLine("Enter Title:");
            m.Title = Console.ReadLine();

            Console.WriteLine("Enter Artist:");
            m.Artist = Console.ReadLine();

            Console.WriteLine("Enter Genre:");
            m.Genre = Console.ReadLine();

            Console.WriteLine("Enter Ratings:");
            m.Ratings = Convert.ToInt32(Console.ReadLine());

            movieList.Add(m);
        }

        // View Movies by Genre (LINQ)
        public static List<Movie> ViewMoviesByGenre(string genre)
        {
            List<Movie> result = movieList
                                .Where(m => m.Genre == genre)
                                .ToList();

            if (result.Count == 0)
                Console.WriteLine("No Movies found in genre " + genre);

            return result;
        }

        // View Movies by Rating (LINQ)
        public static List<Movie> ViewMoviesByRating()
        {
            return movieList
                    .OrderBy(m => m.Ratings)
                    .ToList();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of movies:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                AddMovie();
            }

            Console.WriteLine("Enter genre:");
            string genre = Console.ReadLine();

            foreach (Movie m in ViewMoviesByGenre(genre))
                Console.WriteLine($"{m.Title},{m.Artist},{m.Genre},{m.Ratings}");

            Console.WriteLine("Sorted by rating:");
            foreach (Movie m in ViewMoviesByRating())
                Console.WriteLine($"{m.Title},{m.Artist},{m.Genre},{m.Ratings}");
        }
    }
}
