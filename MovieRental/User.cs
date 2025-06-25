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

}

class UserManager
{
    private List<User> users = new List<User>
    {
        new User {Account="Admin",Password="123",Role ="Admin" },
        new User { Account = "User01", Password = "123", Role = "User" }
    };
    public  User Login(string username, string password)
    {
        User CheckLogin = users.FirstOrDefault(u => u.Account == username && u.Password == password);
        return CheckLogin;
    }
}

