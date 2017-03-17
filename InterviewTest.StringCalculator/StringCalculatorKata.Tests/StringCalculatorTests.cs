using NUnit.Framework;
using StringCalculatorCore;

namespace StringCalculatorKata.Tests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [Test]
        public void Calculate_EmptyString_ReturnsZero()
        {
            int expectedResult = 0;
            int val = StringCalculator.Add("");
            Assert.AreEqual(expectedResult, val);
        }

        [Test]
        //[Ignore("complete previous test first")]
        public void Calculate_SingleNumber_ReturnsSameNumber()
        {
            int expectedResult = 42;
            int val = StringCalculator.Add("42");
            Assert.AreEqual(expectedResult, val);
        }

        [Test]
        //[Ignore("complete previous test first")]
        public void Calculate_TwoNumbers_ReturnsSum()
        {
            int expectedResult = 6;
            int val = StringCalculator.Add("3,3");
            Assert.AreEqual(expectedResult, val);
        }
        
        [Test]
        //[Ignore("complete previous test first")]
        public void Calculate_FiveNumbers_ReturnsSum()
        {
            int expectedResult = 42;
            int val = StringCalculator.Add("2,4,9,5,22");
            Assert.AreEqual(expectedResult, val);
        }
   
        // Additional Functionality

        [Test]
        //[Ignore("complete previous test first")]
        public void Calculate_CanUseAlternativeDelimiters_ReturnsSum()
        {
            int expectedResult = 42;
            int val = StringCalculator.Add("2;4;9;5;22", ';');
            Assert.AreEqual(expectedResult, val);
        }

        [Test]
        [Ignore("complete previous test first")]
        public void Calculate_NumbersLargerThan100_IgnoresOver100sInSum()
        {
        
        }

        [Test]
        [Ignore("complete previous test first")]
        public void Calculate_NonNumericValue_ReturnsZero()
        {
        
        }

        [Test]
        [Ignore("complete previous test first")]
        public void Calculate_FirstSevenInFibonacciSequence_ThrowsCustomFibonacciAlertException()
        {
        
        }
    }
}
