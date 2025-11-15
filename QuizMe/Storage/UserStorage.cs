using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMe
{
    class UserStorage
    {
        public static string Uid { get; set; }
        public static string Ten { get; set; }
        public static string Role { get; set; }
        public static string Gender { get; set; }
        public static DateTime? Dob { get; set; }
        public static string Phone { get; set; }
        public static string MaLop { get; set; }

        public static void Clear()
        {
            Uid = null;
            Ten = null;
            Role = null;
            Phone = null;
            MaLop = null;
            Dob = null;
            Gender = null;
        }
    }
}
