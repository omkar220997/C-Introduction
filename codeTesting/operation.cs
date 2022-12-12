using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeTesting
{

    public class operation
    {
        public double addition(double a, double b)
        {
            double sum = a + b;
            Console.WriteLine($"the addition of {a} and {b} is : " + sum);
            return sum;
        }
        public double substraction(double a, double b)
        {
            double sub = a - b;
            Console.WriteLine($"the substraction of {a} and {b} is : " + sub);
            return sub;
        }
        public double multiplication(double a, double b)
        {
            double mul = a * b;
            Console.WriteLine($"the multiplication of {a} and {b} is : " + mul);
            return mul;
        }
        public double division(double a, double b)
        {
            double div = a / b;
            Console.WriteLine($"the division of {a} and {b} is : " + div);
            return div;
        }
        public double modulus(double a, double b)
        {
            double mod = a % b;
            Console.WriteLine($"the modulus of {a} and {b} is : " + mod);
            return mod;
        }
        public double square(double a)
        {
            double sqr = a * a;
            Console.WriteLine($"the square of {a} is : " + sqr);
            return sqr;
        }
        public double squareRoot(double a)
        {
            double sqrt = Math.Sqrt(a);
            Console.WriteLine($"the square root of {a}  is : " + sqrt);
            return sqrt;
        }
    }
}

