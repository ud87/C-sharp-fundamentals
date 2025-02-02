using Xunit;
using Module07Lesson04UnitTestDemoLibraryExcercise;

namespace FizzBuzzUnitTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(7, "7")]
        [InlineData(8, "8")]
        [InlineData(9, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(11, "11")]
        [InlineData(12, "Fizz")]
        [InlineData(13, "13")]
        [InlineData(14, "14")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(16, "16")]
        [InlineData(17, "17")]
        [InlineData(18, "Fizz")]
        [InlineData(19, "19")]
        [InlineData(20, "Buzz")]


        public void Test1(int number, string expected)
        {
            //Arrange - no need to instantiate obj as its static
            
            //Act
            string actual = FizzBuzz.GetFizzBuzz(number);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

/*
 Steps
- Add project reference to unit test dependencies
- add using and name of the class library at the top to import 
 */