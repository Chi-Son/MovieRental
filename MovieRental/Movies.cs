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
    public void Display()
    {
        Console.WriteLine("  Title: " + Title);
        Console.WriteLine("  Rent Price: " + RentPrice);
        if (RentStatus== true) {
            Console.WriteLine("  Rent Status: Rented " );
        }
        else
        {
            Console.WriteLine("  Rent Status: Available");
        }
    }

}
class MovieDisplay
{
    public List<Movie> Movies { get; set; } = new List<Movie>
    {
        new Movie { MovieId = 1, Title = "Friends", RentPrice = 3.9, RentStatus =true },
        new Movie { MovieId = 2, Title = "How i meet your mother", RentPrice = 2.88, RentStatus = false },
        new Movie { MovieId = 3, Title = "The Fall of the House of Usher", RentPrice = 4.34, RentStatus = false },
        new Movie { MovieId = 4, Title = "Zodiac", RentPrice = 2.16, RentStatus = false }
    };

    public void AllMovies()
    {
        int nums = 1;
        foreach (var movie in Movies)
        {
            Console.WriteLine("---Movie No." + nums + "---");
            movie.Display();
            nums++;
        }
    }
    public void MovieById(int id)
    {
        foreach (var movie in Movies)
        {
            if (movie.MovieId == id)
            {
                movie.Display();
                break;
            }
        }
    }
}





