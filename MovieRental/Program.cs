namespace MovieRental
{
    internal class Program
    {
        static void Main()
        {
            MovieManager movie = new MovieManager();
            Console.WriteLine("Press 1 to see all movies");
            string n = Console.ReadLine();
            while (n!="1") {
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
    }
}
