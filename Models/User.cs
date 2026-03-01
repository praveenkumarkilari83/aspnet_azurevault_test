// User.cs

using System;

namespace Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public DateTime CreatedAt { get; set; }

        public User() {
            CreatedAt = DateTime.UtcNow; // Set to the current UTC time
        }
    }
}