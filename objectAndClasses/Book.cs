using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectAndClasses
{
    internal class Book
    {
        public Book(string name) 
        {
            grades = new List<double>();
            this.name = name;
        }

      public void AddGrade(double grade)
        {

            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (var number in grades)
            {
                lowGrade = Math.Min(lowGrade, number);
                highGrade = Math.Max(highGrade, number);
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine("average grade is " + result);
            Console.WriteLine("Lowest grade is " + lowGrade);

            Console.WriteLine("Highest grade is " + highGrade);
        }
        private List<double> grades;
        private string name;
    }
}
