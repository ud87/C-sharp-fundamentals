using MathLibrary;

namespace UnitTest
{
    public class MathOperationsUnitTest
    {
        [Fact]
        public void TestAdd()
        {
            int expected = 5;
            int actual = MathOperations.Add(2, 3);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, "+", 3)]
        [InlineData(1, 2, "-", -1)]
        [InlineData(1, 2, "*", 2)]
        [InlineData(1, 2, "/", 0.5)]
        public void TestMathOperations(int x, int y, string op, int expected)
        {
            int actual;

            switch (op)
            {
                case "+":
                    actual = MathOperations.Add(x, y); 
                    break;

                case "-":
                    actual = MathOperations.Subtract(x, y);
                    break;

                case "*":
                    actual = MathOperations.Multiply(x, y); 
                    break;

                case "/":
                    actual = MathOperations.Divide(x, y);
                    break;

                default:
                    actual = 0;
                    break;
            }

            Assert.Equal(expected, actual);
        }
    }
}