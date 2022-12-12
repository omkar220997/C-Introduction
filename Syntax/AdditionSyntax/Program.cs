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
            double avg2 = result2/grades.Count;
            Console.WriteLine("Addition of given numbers in list grades by foreach loop is : " + result2);
            Console.WriteLine("Average of given numbers in list grades by foreach loop is : " + avg2);
            Console.WriteLine("....................................................................................");

            double result = numbers[0];
            result = result+numbers[1];
            result = result+numbers[2];
            result = result+numbers[3];
            result = result+numbers[4];
            double avg = result / 5;
            Console.WriteLine("Addition of the given numbers by simple method is : " + result);
            Console.WriteLine("Addition of the given numbers by simple method is : " + avg);
            Console.WriteLine("....................................................................................");


            double result1 = 0.0;
            foreach(double number in numbers)
            {
                result1 += number;
            }
            double avg1 = result1/numbers.Length;
            Console.WriteLine("Addition of given numbers in Array numbers by foreach loop is : " +result1);
            Console.WriteLine("Average of given numbers in Array numbers by foreach loop is : " +avg1);
            Console.WriteLine("....................................................................................");


            double x = 57.8621;
            double y = 35.426;
            double z = x + y;
            double A = z / 2;
            Console.WriteLine("Addition of x and y is " +z);
            Console.WriteLine("Average of x and y is " +A);
            Console.WriteLine("....................................................................................");

            Console.ReadLine();

        }
    }
}
