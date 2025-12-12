using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuizMe
{
    class Data
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Server=localhost;Database=quizme_db;Integrated Security=True;");
        }

        public static SqlConnection GetMasterConnection()
        {
            return new SqlConnection(@"Server=localhost;Database=master;Integrated Security=True;");
        }
    }
}
