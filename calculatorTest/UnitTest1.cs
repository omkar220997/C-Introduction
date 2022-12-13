using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace calculatorTest
{
    public class UnitTest1
    {
        Program mytest = new Program();
        [Fact]
        public void Test1()
        
        {
            double a = 10;
            double b = 20;
            double sum = 30;

            double Answer = mytest.addtion(a, b);
        }
    }
}