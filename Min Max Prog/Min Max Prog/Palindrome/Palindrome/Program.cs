
using System;


namespace Palindrome
{
    public static class Program
    {

        static void Main(string[] args)
        {
            int i = 0, j, flag = 0;
            char[] arr;
            Console.WriteLine("Enter string");
            arr = Console.ReadLine().ToCharArray();
            j = arr.Length - 1;
            while (i <= j)
            {
                if (arr[i] == arr[j])
                {
                    i++;
                    j--;

                }
                else
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Entered string is a palidrome");

            }
            else
            {
                Console.WriteLine("Entered string is not a palidrome");
            }
        }
    }

}
