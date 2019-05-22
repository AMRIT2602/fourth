using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourth
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Enter your First Number");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter your Second Number");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine(a - b);
            Console.ReadLine();


        }
    }
}
