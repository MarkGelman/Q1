using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            { "John","Ichak","Donald","Michail","Daniel","Shmuel","Beniamin","Moshe","Franklin","Nikita" };
            List<string> test = new List<string>();
            test = names.Where(_ => _.Length > 4).ToList();
            PrintAll(test, "A");
            names.ForEach(_ => { if (_.Contains("a")) {Console.WriteLine($"{_}");} Console.WriteLine("********"); });
            test = names.OrderBy(_ => _).ToList();
            PrintAll(test, "C");
            Console.ReadKey();
        }

        public static void PrintAll(List<string> namesList, string numQuestion)
        {
            Console.WriteLine($"{numQuestion}");
            Console.WriteLine();
            foreach (string names in namesList)
                Console.WriteLine($"{ names}");
            Console.WriteLine();
            Console.WriteLine("**********************");
            Console.WriteLine();
        }

    }

}
