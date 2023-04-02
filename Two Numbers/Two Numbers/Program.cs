
using System;


namespace TwoNumbers
{
    public static class Program
    {

        static void Main(string[] args)
        {
            int n1, n2, r, mchoice;
            char ynchoice;

            do
            {
                Console.WriteLine("Enter first number ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1: +");
                Console.WriteLine("2: -");
                Console.WriteLine("3: *");
                Console.WriteLine("4: /");
                Console.WriteLine("5: %");
                Console.WriteLine("6: Exit");
                Console.WriteLine("Enter your choice...........(1-6)");
                mchoice = Convert.ToInt32(Console.ReadLine());
                if(mchoice==6)
                {
                    break;
                }
                else
                {
                    switch (mchoice)
                    {
                        case 1:

                            r = n1 + n2;
                            Console.WriteLine("Addition is: {0}",r);
                            break;
                        case 2:

                            r = n1 - n2;
                            Console.WriteLine("Subtraction is : {0}",r);
                            break;
                        case 3:

                            r = n1 * n2;
                            Console.WriteLine("Multiplication is : {0}",r);
                            break;
                        case 4:

                            r = n1 / n2;
                            Console.WriteLine("division is {0}",r);
                            break;
                        case 5:

                            r = n1 % n2;
                            Console.WriteLine("Remainder is: {0}", r);
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;



                    }
                }
                Console.WriteLine("Do you want to continue......");
                ynchoice = Convert.ToChar(Console.ReadLine());

            }while(ynchoice=='y' || ynchoice=='Y');

           
        }
    }

}

