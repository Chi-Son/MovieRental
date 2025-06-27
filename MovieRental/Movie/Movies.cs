using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


class Movie
{
    public int MovieId { get; set; }
    public string Title { get; set; }
    public double RentPrice { get; set; }
    public bool RentStatus { get; set; }
    public static List<Movie> Movies { get; set; } = new List<Movie>();

    public static void LoadMoviesFromTxt()
    {
        string filepath = "Data/Movies.txt";
        foreach (var line in File.ReadAllLines(filepath))
        {
            var parts = line.Split('|');
            if (parts.Length == 4)
            {
                Movie movie = new Movie
                {
                    MovieId = int.Parse(parts[0]),
                    Title = parts[1],
                    RentPrice = double.Parse(parts[2]),
                    RentStatus = bool.Parse(parts[3])
                };
                Movies.Add(movie);
            }
        }
    }
    public void Display()
    {
        Console.WriteLine($"  Title: {Title}" );
        Console.WriteLine($"  Rent Price: {RentPrice}" );
        Console.WriteLine($"  Rent Status: {(RentStatus ? "Rented" : "Available")}");

    }

}
static class MovieDisplay
{
    public static void AllMovies()
    {   
        int nums = 1;
        foreach (var movie in Movie.Movies)
        {
            Console.WriteLine("---Movie No." + nums + "---");
            movie.Display();
            nums++;
        }
    }
    public static void MovieById(int id)
    {
        foreach (var movie in Movie.Movies)
        {
            if (movie.MovieId == id)
            {
                movie.Display();
                break;
            }
        }
    }
}





