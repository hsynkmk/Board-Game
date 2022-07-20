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
        public static SqlConnection connection = new SqlConnection("workstation id=BoardGame.mssql.somee.com;packet size=4096;user id=hsynkmk_SQLLogin_1;pwd=twn3zim4wz;data source=BoardGame.mssql.somee.com;persist security info=False;initial catalog=BoardGame");
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