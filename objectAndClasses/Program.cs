using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var book =new Book("Omkar grade is good");
            book.AddGrade(89.1);
            book.AddGrade(85.2);
            book.AddGrade(83.8);
            book.ShowStatistics();

           

            
            Console.ReadLine();  













        }
    }
}
