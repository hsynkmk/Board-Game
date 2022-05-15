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
    public static class GlobalFunctions
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string UnHashedPassword { get; set; }
        public static XElement Xelem { get; set; }

        public static XDocument doc = XDocument.Load(@"../../UserData.xml");

        public static List<int> SClist = new List<int>();


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

        public static List<int> ShapeAndColorPref()
        {


            string col = Xelem.Element("color").Value;
            string sha = Xelem.Element("shape").Value;


            if (sha[0] == '1')
            {
                if (col[0] == '1')
                    SClist.Add(0);
                if (col[1] == '1')
                    SClist.Add(1);
                if (col[2] == '1')
                    SClist.Add(2);
            }
            if (sha[1] == '1')
            {
                if (col[0] == '1')
                    SClist.Add(3);
                if (col[1] == '1')
                    SClist.Add(4);
                if (col[2] == '1')
                    SClist.Add(5);
            }
            if (sha[2] == '1')
            {
                if (col[0] == '1')
                    SClist.Add(6);
                if (col[1] == '1')
                    SClist.Add(7);
                if (col[2] == '1')
                    SClist.Add(8);
            }


            return SClist;
        }
    }
}
