using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gradeCalculator =new GradeCalculator();
            Console.WriteLine("Enter your percentage: ");
            
            string per=Console.ReadLine();
            double percentage=Convert.ToDouble(per);

            var grade = gradeCalculator.GetGradePercentage(percentage);
            Console.WriteLine($"Grade for {percentage} is {grade}");
            Console.ReadLine();

        }
    }
}
