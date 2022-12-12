using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("Hello Omkar");
            }
            else
            {
                Console.WriteLine("Hello world");
            }
            
            Console.ReadLine();
        }
    }
}
