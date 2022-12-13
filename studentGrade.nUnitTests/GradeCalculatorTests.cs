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
        public void GetGradePercentage_equalTest(double percentage)
        {
            //var percentage = 99;

            var grade= _calculator.GetGradePercentage(percentage);

            Assert.AreEqual("A", grade);
        }

        [TestCase(1)]
        [TestCase(45)]
        [TestCase(100.01)]
        [TestCase(89.999)]
        [TestCase(75)]
        public void GetGradePercentage_notEqualTest(double percentage)
        {
            //var percentage = 99;

            var grade = _calculator.GetGradePercentage(percentage);

            Assert.AreNotEqual("A", grade);
        }

    }
}