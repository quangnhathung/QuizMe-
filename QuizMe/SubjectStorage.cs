using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMe
{
    class Subject
    {
        public string MaMon { get; set; }
        public string TenMonHoc { get; set; }
        public int ThoiGianThi { get; set; }
        public int SoCauHoi { get; set; }

        public Subject(string a, string b, int c, int d)
        {
            this.MaMon = a;
            this.TenMonHoc = b;
            this.ThoiGianThi = c;
            this.SoCauHoi = d;
        }

        public Subject()
        {
            this.MaMon = "";
            this.TenMonHoc = "";
            this.ThoiGianThi = 0;
            this.SoCauHoi = 0;
        }
    }
    class SubjectStorage
    {
        public static List<Subject> Subjects = new List<Subject>();

        public static void Add(Subject item)
        {
            Subjects.Add(item);
        }
    }
}
