using System;
using System.Linq;

namespace MinMaxProg
{
    class Program
    {

        static void Main(string[] args)
        {
            string str_num = "2 7 5 6 1";
            Console.WriteLine("Input: " + str_num);
            Console.WriteLine("Output: " +test(str_num));
            
        }
        public static string test(string str_num)
        {
            var result = str_num.Split(' ').Select(int.Parse).ToArray();
            return result.Max() + " " + result.Min();
        }
    }
}