using System.Net;

namespace TestProjectN1
{
    public class Tests
    {
        /*
        [SetUp]
        public void Setup()
        {
        }
        */

        [Test]
        public void BubbleSort_test_1()
        {
            int[] array = { 5, 3, 2, 4, 1 };
            int[] expected = { 1, 2, 3, 4, 5 };


            int[] result = Universal.SortBubble(array);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void BubbleSort_test_2()
        {
            int[] array = { };
            int[] expected = { };


            int[] result = Universal.SortBubble(array);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsPalindrome_test_1()
        {
            string palindrome = "adaada";
            bool result = Universal.IsPalindrome(palindrome);

            Assert.IsTrue(result);
        }
        [Test]
        public void IsPalindrome_test_2()
        {
            string palindrome = null;


            bool result = Universal.IsPalindrome(palindrome);

            Assert.IsFalse(result);
        }

        [Test]
        public void FactorialOfNumber_test_1()
        {
            int number = 5;
            int expected = 120;

            int result = Universal.FactorialOfNumber(number);

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FactorialOfNumber()
        {
            int number = -1;

            Assert.Throws<ArgumentException>(() => Universal.FactorialOfNumber(number));
        }

        [Test]
        public void Fibonacci_test1()
        {
            int position = 6;
            int expected = 8;

            int result = Universal.Fibonacci(position);

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Fibonacci_test2()
        {
            int position = -1;

            Assert.Throws<ArgumentException>(() => Universal.FactorialOfNumber(position));

        }

        [Test]
        public void Power_test1()
        {
            double number = 2;
            double exponent = 3;
            double expected = 8;

            double result = Universal.Power(number, exponent);

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Power_test2()
        {
            double number = 2.1;
            double exponent = 3.5;
            double expected = Math.Pow(number, exponent);


            double result = Universal.Power(number, exponent);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Check_prime_test1()
        {
            int primeNumber = 7;

            bool result = Universal.IsPrime(primeNumber);

            Assert.IsTrue(result);
        }
        [Test]
        public void Check_prime_test2()
        {
            int primeNumber = 17;

            bool result = Universal.IsPrime(primeNumber);

            Assert.IsTrue(result);
        }
    }
}