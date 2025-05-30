using System;

namespace MilkbarPOS.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Salt { get; set; } // Optional: for password hashing

        public User() { }

        public User(int userId, string username, string password, string role)
        {
            UserID = userId;
            Username = username;
            Password = password;
            Role = role;
        }
    }
}
