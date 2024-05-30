using BusinessLogic;
using SemesterProjektDenAnden.Tools;

namespace TestProject3
{
    public class Tests
    {


        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestRate()
        {
            // Arrange
            

            // Act
            double result = Calculator.CalculateFinalValue(100, 5, 1);

            // Assert

            result = Math.Round(result, 2);
            Assert.That(result, Is.EqualTo(105));
        }

        [Test]
        public void TestPeriode()
        {
            // Arrange
            var cal = new Calculator();

            // Act
            double result = Calculator.CalculateFinalValue(100, 5, 2);

            // Assert

            result = Math.Round(result, 2);
            Assert.That(result, Is.EqualTo(53.78));
        }
      

        
        [Test]
        public void TestNegativRate()
        {
            // Arrange
            var cal = new Calculator();

            // Act
            double result = Calculator.CalculateFinalValue(100, -5, 1);

            // Assert

            result = Math.Round(result, 2);
            Assert.That(result, Is.EqualTo(0));
        }
    }   
    

}