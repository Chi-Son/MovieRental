namespace MovieRental
{
    internal class Program
    {
        static void Main()
        {
            Movie.LoadMoviesFromTxt();
            User.LoadUserFromTxt();
            MovieRentalSystem.SignIn();
        }
    }
}
