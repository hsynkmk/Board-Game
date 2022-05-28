using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_Game__SQL_
{
    public static class UserClass
    {

        public static bool IsAdmin { get; set; }=false;
        public static int BestScore { get; set; } = 0;
        public static string Username { get; set; }
        public static string UnHashedPassword { get; set; }
        public static string HashedPassword { get; set; }
        public static string NameSurname { get; set; }
        public static string PhoneNumber { get; set; }
        public static string Address { get; set; }
        public static string City { get; set; }
        public static string Country { get; set; }
        public static string Email { get; set; }
        public static string Difficulty { get; set; }
        public static string CustomDifficultyWidth { get; set; }
        public static string CustomDifficultyHeight { get; set; }
        public static string Shape { get; set; }
        public static string Color { get; set; }
        public static void Clear()
        {
            IsAdmin = false;
            BestScore = 0;
            Username = null;
            UnHashedPassword = null;
            HashedPassword = null;
            NameSurname = null;
            PhoneNumber = null;
            Address = null;
            City = null;
            Country = null;
            Email = null;
            Difficulty = null;
            CustomDifficultyWidth = null;
            CustomDifficultyHeight = null;
            Shape = null;
            Color = null;
        }
        
    }
}
