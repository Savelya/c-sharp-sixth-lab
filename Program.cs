using System;
using System.Linq;

namespace sixth_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            str = System.Text.RegularExpressions.Regex.Replace(str, @"\s+", " ");
            string[] words = str.Split(" ");
            Array.Sort(words);
            Console.WriteLine(String.Join(" ", words));
            Console.WriteLine(String.Concat(words.Select((x) => x.Last()).ToArray()));
        }
    }
}
