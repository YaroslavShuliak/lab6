using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    internal class Go
    {
        static void Main(string[] args)
        {
            Mylist<int> mylist = new Mylist<int>();
            Console.WriteLine("Елементи масиву:");
            mylist.Add(10);
            Console.WriteLine($"{mylist[0]}");
            mylist.Add(2);
            Console.WriteLine($"{mylist[1]}");
            mylist.Add(33);
            Console.WriteLine($"{mylist[2]}");
            Console.WriteLine($"Всього елементів: {mylist.Count}");
            Console.WriteLine("Значення елементів:");
            int[] array = MyExtensions.GetArray(mylist);
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
} 
