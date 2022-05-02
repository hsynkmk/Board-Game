using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Security.Cryptography;

namespace Board_Game
{
    public static class UserClass
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string UnHashedPassword { get; set; }
        public static XElement Xelem { get; set; }

        public static XDocument doc = XDocument.Load(@"../../UserData.xml");


        public static bool xmlConnection(string username, string password)
        {
            string hash;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
            }

            foreach (XElement elem in doc.Descendants("Admin"))
            {
                if (elem.Element("username").Value == username && elem.Element("password").Value == hash)
                {
                    Xelem = elem;
                    Username = username;
                    Password = hash;
                    UnHashedPassword = password;
                    //Difficulty = elem.Element("difficulty").Value;
                    return true;
                }
            }

            foreach (XElement elem in doc.Descendants("user"))
            {
                if (elem.Element("username").Value == username && elem.Element("password").Value == hash)
                {
                    Xelem = elem;
                    Username = username;
                    Password = hash;
                    UnHashedPassword = password;
                    //Difficulty = elem.Element("difficulty").Value;
                    return true;
                }
            }
            return false;
        }
        public static void xmlsave(string category, string data)
        {
            Xelem.Element(category).Value = data;
            doc.Save(@"../../UserData.xml");
        }
    }
}
