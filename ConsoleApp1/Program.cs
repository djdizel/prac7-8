using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = 4;
            bool b = (numbers % 2 == 0);
            if (b)
            {
                Console.WriteLine("Число четное");
            }
            else {
                Console.WriteLine("Число нечетное");
                    }
            Console.ReadLine();
        }
    }
}
