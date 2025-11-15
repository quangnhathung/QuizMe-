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
    public class Question
    {
        public string CauHoi { get; set; }
        public List<string> LuaChon { get; set; } = new List<string>();
        public int DapAn { get; set; }

        public Question(string rawData)
        {
            if (string.IsNullOrWhiteSpace(rawData))
                throw new ArgumentException("Chuỗi dữ liệu câu hỏi không hợp lệ!");

            var parts = rawData.Split('_');

            CauHoi = parts[0].Trim();

            if (parts.Length > 1)
            {
                LuaChon = parts[1]
                    .Split('|')
                    .Select(opt => opt.Replace("''", "'").Trim())
                    .ToList();
            }

            DapAn = 1;
        }
    }
    class SubjectStorage
    {
        public static List<Subject> Subjects = new List<Subject>();
        public static Subject CurrentSubject = new Subject();
        public static void Add(Subject item)
        {
            Subjects.Add(item);
        }

        public static void Choose(Subject a)
        {
            CurrentSubject = a;
        }

        public static void Clear()
        {
            Subjects.Clear();
        }
    }
}
