using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Board_Game__SQL_
{
    public class SQLClass
    {
        public static SqlConnection connection = new SqlConnection("Server=tcp:boardgameoop.database.windows.net,1433;Initial Catalog=BoardGameDB;Persist Security Info=False;User ID=152120181100@ogrenci.ogu.edu.tr;Password=DH.huseyin68;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Authentication=\"Active Directory Password\"");
        public static void openConn()
        {
            connection.Open();
        }
        public static void closeConn()
        {
            connection.Close();
        }

        public static void SetBestScore(string score)
        {
            SqlCommand BestScoreCommand = new SqlCommand("Update BoardGameUsers set BestScore=@bstscore where username=@usn", SQLClass.connection);

            BestScoreCommand.Parameters.AddWithValue("@usn", UserClass.Username);
            BestScoreCommand.Parameters.AddWithValue("@bstscore", score);
            BestScoreCommand.ExecuteNonQuery();
        }
    }
}