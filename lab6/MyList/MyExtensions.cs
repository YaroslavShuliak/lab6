using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    internal static class MyExtensions
    {
        public static T[] GetArray<T>(this Mylist<T> list)
        {
            T[] array = new T[list.Count];
            for (int i = 0; i < list.Count; i++)

                array[i] = list[i];
            return array;
            Console.WriteLine(array);
        }
    }
}
