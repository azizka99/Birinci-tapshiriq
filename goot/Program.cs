using System;

namespace goot
{
    class Program
    {
        static void Main(string[] args)
        {
            string nem = "Salam baki necesen?";

            standEnd(nem);
            
        }

        static string standEnd(string A)
        {

            string[] B = A.Split(' ');
            string lastvariable = B[0] + B[(B.Length - 1)];

            Console.WriteLine(lastvariable);
            return "";
        }
    }
}
