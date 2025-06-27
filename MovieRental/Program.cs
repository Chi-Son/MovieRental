namespace MovieRental
{
    internal class Program
    {
        static void Main()
        {
            Movie.LoadMoviesFromTxt();
            MovieRentalSystem.SignIn();
        }
    }
}
