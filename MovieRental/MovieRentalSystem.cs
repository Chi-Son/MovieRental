using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class MovieRentalSystem
{
    private static UserManager userManager = new UserManager();
    public static void CustomerMenu()
    {
        Console.WriteLine("---0--- Menu --0--");
        Console.WriteLine("1. List Movies ");
        Console.WriteLine("2. UserInfo ");
        Console.WriteLine("3. Logout");
        Console.WriteLine("---0--- Menu --0--");
        string n = Console.ReadLine();
        while (n != "1")
        {
            Console.WriteLine("Press please againt");
            n = Console.ReadLine();
        }
        MovieDisplay.AllMovies();




        Console.WriteLine("Choose movie u like");
        bool found = false;
        while (!found)
        {
            string id = Console.ReadLine();
            foreach (var m in Movie.Movies)
            {
                if (id == (m.MovieId).ToString())
                {
                    MovieDisplay.MovieById(int.Parse(id));
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
                MovieRentalSystem.CustomerMenu();
            }
            else { MovieRentalSystem.CustomerMenu(); }
        }
        else 
        { 
            Console.WriteLine("Login failed! Invalid username or password."); 
            SignIn();
        }
    }
}