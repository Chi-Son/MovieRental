using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class User
{
    public string Account { get; set; }
    public string Password { get; set; } 
    public string Role { get; set; }
    public static List<User> Users { get; set; } = new List<User>();
    public static void LoadUserFromTxt()
    {
        string filepath = "Data/User.txt";
        foreach (var line in File.ReadAllLines(filepath))
        {
            var userTxt = line.Split('|');
            if (userTxt.Length ==3 )
            {
                User user = new User { 
                    Account = userTxt[0],
                    Password = userTxt[1],
                    Role = userTxt[2],
                };
                Users.Add(user);
            }
        }
    }
}

class UserManager
{
    public  User Login(string username, string password)
    {
        return (User.Users).FirstOrDefault(u => u.Account == username && u.Password == password);
    }
}

