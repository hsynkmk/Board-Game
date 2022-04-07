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
        public static string unHashedPassword { get; set; }
        public static XElement Xelem { get; set; }

        private static readonly XDocument doc = XDocument.Load(@"../../UserData.xml");


        public static bool xmlConnection(string username, string password)
        {

            SHA1 sha = new SHA1CryptoServiceProvider();

            string hashedData = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(password)));

            foreach (XElement elem in doc.Descendants("Admin"))
            {
                if (elem.Element("username")?.Value == username && elem.Element("password")?.Value == hashedData)
                {
                    Xelem = elem;
                    Username = username;
                    Password = hashedData;
                    unHashedPassword = password;
                    return true;
                }
            }

            foreach (XElement elem in doc.Descendants("user"))
            {
                if (elem.Element("username")?.Value == username && elem.Element("password")?.Value == hashedData)
                {
                    Xelem = elem;
                    Username = username;
                    Password = hashedData;
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
