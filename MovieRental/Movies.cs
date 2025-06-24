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
    List<Movie> Movies { get; set; } = new List<Movie>();

    public void Display()
    {
        Console.WriteLine("--Movie--");
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Rent Price: " + RentPrice);
    }
    public void AllMovies()
    {
        int nums = 1;
        foreach(var  movie in Movies)
        {
            Console.WriteLine("---Movie No."+nums+"---");
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





