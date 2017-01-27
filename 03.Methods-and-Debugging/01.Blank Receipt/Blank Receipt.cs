using System;

namespace _01.Blank_Receipt
{
    class Program
    {
        static void Lines()
        {
            Console.WriteLine("------------------------------");
        }
        static void Header()
        {
            Console.WriteLine("CASH RECEIPT");
            Lines();           
        }
        static void Body()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void Bottom()
        {
            Lines();
            Console.WriteLine("© SoftUni");
        }

        static void Main(string[] args)
        {
            Header();
            Body();
            Bottom();
        }

    }
}
