using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Board_Game__SQL_
{
    public static class GlobalMethods
    {
        public static List<int> SClist = new List<int>();

        public static string SHA256Converter(string password)
        {
            string hash;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
            }

            return hash;
        }

        public static List<int> ShapeAndColorPref()
        {
            SClist.Clear();

            string col = UserClass.Color;
            string sha = UserClass.Shape;


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
