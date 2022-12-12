using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter first digit : ");
            string astr = Console.ReadLine();
            double a = Convert.ToDouble(astr);

            Console.WriteLine("Enter second digit : ");
            string bstr = Console.ReadLine();
            double b = Convert.ToDouble(bstr);

            operation oprtn = new operation();
            if (a != 0 && b != 0)
            {
                Console.WriteLine("Enter the Operation from addition, substraction, multiplication, division, modulus ");
                string opr = Console.ReadLine();
                switch (opr)
                {
                    case "addition":
                        Console.WriteLine(oprtn.addition(a, b));
                        break;
                    case "substraction":
                        Console.WriteLine(oprtn.substraction(a, b));
                        break;
                    case "multiplication":
                        Console.WriteLine(oprtn.multiplication(a, b));
                        break;
                    case "division":
                        Console.WriteLine(oprtn.division(a, b));
                        break;
                    case "modulus":
                        Console.WriteLine(oprtn.modulus(a, b));
                        break;
                }
            }
            else if (a != 0 && b == 0)
            {
                Console.WriteLine("select the operation square, square root");
                string opr1 = Console.ReadLine();
                switch (opr1)
                {
                    case "square":
                        Console.WriteLine(oprtn.square(a));
                        break;
                    case "square root":
                        Console.WriteLine(oprtn.squareRoot(a));
                        break;


                }

            }




            Console.ReadLine();

        }
    }
}

