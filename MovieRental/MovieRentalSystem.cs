using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class MovieRentalSystem
{
    private static UserManager userManager = new UserManager();
    public static void Menu()
    {
        MovieDisplay movie = new MovieDisplay();
        Console.WriteLine("Press 1 to see all movies");
        string n = Console.ReadLine();
        while (n != "1")
        {
            Console.WriteLine("Press 1 please");
            n = Console.ReadLine();
        }
        movie.AllMovies();
        Console.WriteLine("Choose movie u like");
        bool found = false;
        while (!found)
        {
            string id = Console.ReadLine();
            foreach (var m in movie.Movies)
            {
                if (id == (m.MovieId).ToString())
                {
                    movie.MovieById(int.Parse(id));
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Don't have any ID like that, choose again.");

            }
        }
    }
    public static void SignIn()
    {
        Console.WriteLine("----  Movie Rental Console App ----");
        Console.WriteLine("Plese enter username:");
        string un = Console.ReadLine();
        Console.WriteLine("Plese enter password:");
        string pw = Console.ReadLine();
        User CheckLogin = userManager.Login(un, pw);
        if (CheckLogin != null)
        {
            if (CheckLogin.Role == "Admin")
            {
                MovieRentalSystem.Menu();
            }
            else { }
        }
        else 
        { 
            Console.WriteLine("Login failed! Invalid username or password."); 
            SignIn();
        }
    }
}