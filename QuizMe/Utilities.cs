using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMe
{
    class Utilities
    {
        private static Random _random = new Random();
        public static void MessageBoxWarning(string content)
        {
            MessageBox.Show(content,"Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MessageBoxError(string content)
        {
            MessageBox.Show(content, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MessageBoxInfor(string content)
        {
            MessageBox.Show(content, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //lấy 1 số ngẫu nhiên trong khoảng (min -> max) cho trước
        public static int GetUniqueRandomNumber(int min, int max)
        {
            max += 1;
            if (min >= max)
                throw new ArgumentException("Giá trị min phải nhỏ hơn max.");

            return _random.Next(min, max);
        }

        //lấy ngẫu nhiên count phần tử trong 1 list 
        public static List<T> GetRandomElements<T>(List<T> source, int count)
        {
            if (source == null || source.Count == 0)
                throw new ArgumentException("Danh sách rỗng hoặc null.");

            if (count > source.Count)
                throw new ArgumentException("Số lượng yêu cầu lớn hơn số phần tử trong danh sách.");

            return source.OrderBy(x => _random.Next())
                         .Take(count)
                         .ToList();
        }

        public static List<T> Shuffle<T>(List<T> list)
        {
            if (list == null || list.Count <= 1) return list;
            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = GetUniqueRandomNumber(0, i + 1); // lấy từ 0 đến i
                T tmp = list[i];
                list[i] = list[j];
                list[j] = tmp;
            }
            return list;
        }
    }
}
