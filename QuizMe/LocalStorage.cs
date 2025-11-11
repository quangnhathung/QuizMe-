using System;
using System.Collections.Generic;

namespace QuizMe
{
    class LocalStorage
    {
        public static List<dynamic> Storage = new List<dynamic>();

        public static void Add(dynamic value)
        {
            Storage.Add(value);
        }

        public static void Clear()
        {
            Storage.Clear();
        }

        public static dynamic Get(int index)
        {
            if (index < 0 || index >= Storage.Count)
                throw new IndexOutOfRangeException("Index nằm ngoài danh sách!");

            return Storage[index];
        }

        public static dynamic GetFirst()
        {
            if (Storage.Count == 0)
                return null; // hoặc throw exception tuỳ bạn muốn

            return Storage[0];
        }
    }
}
