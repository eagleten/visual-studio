using System;


namespace Program1
{
    class Employee

    {
        string name, email;
        int phoneno;

        static void Main(string[] args)
        {
            Employee maria = new Employee();
            maria.name = "Maria Pontes";
            maria.email = "maria@gmail.com";
            maria.phoneno = 12345;
            Console.WriteLine("{0}", maria.name);
            Console.WriteLine("{0}", maria.email);
            Console.WriteLine("{0}", maria.phoneno);
             

        }
    }

}
