using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Movie
{
    public int MovieId { get; set; }
    public string Title { get; set; }
    public double RentPrice { get; set; }
    public void Display()
    {
        Console.WriteLine("  Title: " + Title);
        Console.WriteLine("  Rent Price: " + RentPrice);
    }

}
class MovieManager
{
    public List<Movie> Movies { get; set; } = new List<Movie>();
    public MovieManager()
    {
        Movies.Add(new Movie { MovieId = 1, Title = "Friends", RentPrice = 3.9 });
        Movies.Add(new Movie { MovieId = 2, Title = "How i meet your mother", RentPrice = 2.88 });
        Movies.Add(new Movie { MovieId = 3, Title = "The Fall of the House of Usher", RentPrice = 4.34 });
        Movies.Add(new Movie { MovieId = 4, Title = "Zodiac", RentPrice = 2.16 });
    }
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





