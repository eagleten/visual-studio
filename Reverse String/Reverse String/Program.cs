
using System;


namespace ReverseString
{
    public static class Program
    {

        static void Main(string[] args)
        {

            string[] arr = { "C", "s", "h", "r", "a", "p", };
            int i = 5;
            Console.WriteLine("The reverse of the string is:");
            while(i >= 0)
            {
                Console.Write(arr[i]);
                i--;
            }
            Console.Read();

        }
    }

}
