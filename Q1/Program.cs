using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{

    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            
            List<int> numbers = new List<int>();
            Random rnd = new Random();
            for (int i=0; i<100; i++)
            {
                numbers.Add(rnd.Next(0, 50));
            }
//'א
            List<int> less10 = numbers.Where(_ => _ < 10).ToList();
            PrintAll<int>(less10, "A");
//'ב
            List<int> div3 = numbers.Where(_ => _ %3 == 0).ToList();
            PrintAll<int>(div3,"B");
//'ג
            List<int> more20 = numbers.Where(_ => _ >20 && _%2 == 0).ToList();
            PrintAll<int>(more20,"C");
//'ד
            List<int> fromHigherToLower = numbers.OrderByDescending(_=>_).ToList();
            PrintAll<int>(fromHigherToLower,"D");

            Console.ReadKey();            
        }
        public static void PrintAll<T>(List<T> numbersList, string numQuestion)
        {
            Console.WriteLine($"{numQuestion}");
            Console.WriteLine();
            foreach (T number in numbersList)
                Console.WriteLine($"{ number}");
            Console.WriteLine();
            Console.WriteLine("**********************");
            Console.WriteLine();
        }
    }
}
