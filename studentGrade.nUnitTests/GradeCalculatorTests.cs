using xUnitTest;

namespace studentGrade.nUnitTests
{
    public class GradeCalculatorTests
    {
        private GradeCalculator _calculator { get; set; }=null!;

        [SetUp]
        public void Setup()
        {
            _calculator = new GradeCalculator();
        }

        [TestCase(92.6)]
        [TestCase(95.7)]
        [TestCase(90.3)]
        [TestCase(90.009)]
        [TestCase(100)]
        public void GetGradePercentage_Test(double percentage)
        {
            //var percentage = 99;

            var grade= _calculator.GetGradePercentage(percentage);

            Assert.AreEqual("A", grade);
        }
    }
}