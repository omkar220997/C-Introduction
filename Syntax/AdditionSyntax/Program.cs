using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[5] {57.369,25.352,56.859,69.963,74.248};

            List <double> grades=new List<double>() { 57.369, 25.352, 56.859, 69.963, 74.248 };
            double result2 = 0.0;
            foreach (double number in grades)
            {
                result2 += number;
            }
            Console.WriteLine("Addition of given numbers in list grades by foreach loop is : " + result2);

            double result = numbers[0];
            result = result+numbers[1];
            result = result+numbers[2];
            result = result+numbers[3];
            result = result+numbers[4];
            Console.WriteLine("Addition of the given numbers by simple method is : " + result);

            double result1 = 0.0;
            foreach(double number in numbers)
            {
                result1 += number;
            }
            Console.WriteLine("Addition of given numbers in Array numbers by foreach loop is : " +result1);

            double x = 57.8621;
            double y = 35.426;
            double z = x + y;
            Console.WriteLine("Addition of x and y is " +z);
            Console.ReadLine();

        }
    }
}
