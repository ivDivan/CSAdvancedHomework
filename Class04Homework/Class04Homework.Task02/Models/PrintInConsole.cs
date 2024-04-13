using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class04Homework.Task02.Models
{
    public class PrintInConsole
    {
        public static void Print<T>(T obj)
        {
            Console.WriteLine(obj);
        }

        public static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.Write(item + " ");
            }
        }
    }
}
