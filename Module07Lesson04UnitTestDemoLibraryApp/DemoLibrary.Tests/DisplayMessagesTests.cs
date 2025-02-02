using Module07Lesson04DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Xunit;      //use for unit test

//Arrange, Act, Assert - These are three steps for good unit tests
//expected and actual
//red, green, refactor

namespace DemoLibrary.Tests
{
    public class DisplayMessagesTests
    {
        //Arrange
        DisplayMessages messages = new DisplayMessages();

        [Fact]     //makes unit test
        public void GreetingShouldReturnGoodMorningMessage()
        {
            string expected = "Go to bed Tim";

            //Act
            string actual = messages.Greeting("Tim", 2);

            //Assert - this should have happened
            Assert.Equal(expected, actual);  //always in the order expected and actual
        }

        [Fact]
        public void GreetingShouldReturnGoodAfternoonMessage()
        {
            string expected = "Good afternoon Tim";

            //Act
            string actual = messages.Greeting("Tim", 15);

            //Assert - this should have happened
            Assert.Equal(expected, actual);
            
        }

        [Theory]
        [InlineData("Tim", 0, "Go to bed Tim")]
        [InlineData("Tim", 1, "Go to bed Tim")]
        [InlineData("Tim", 2, "Go to bed Tim")]
        [InlineData("Tim", 3, "Go to bed Tim")]
        [InlineData("Tim", 4, "Go to bed Tim")]
        [InlineData("Tim", 5, "Good morning Tim")]
        [InlineData("Tim", 6, "Good morning Tim")]
        [InlineData("Tim", 7, "Good morning Tim")]
        [InlineData("Tim", 8, "Good morning Tim")]
        [InlineData("Tim", 9, "Good morning Tim")]
        [InlineData("Tim", 10, "Good morning Tim")]
        [InlineData("Tim", 11, "Good morning Tim")]
        [InlineData("Tim", 12, "Good afternoon Tim")]
        [InlineData("Tim", 13, "Good afternoon Tim")]
        [InlineData("Tim", 14, "Good afternoon Tim")]
        [InlineData("Tim", 15, "Good afternoon Tim")]
        [InlineData("Tim", 16, "Good afternoon Tim")]
        [InlineData("Tim", 17, "Good afternoon Tim")]
        [InlineData("Tim", 18, "Good evening Tim")]
        [InlineData("Tim", 19, "Good evening Tim")]
        [InlineData("Tim", 20, "Good evening Tim")]
        [InlineData("Tim", 21, "Good evening Tim")]
        [InlineData("Tim", 22, "Good evening Tim")]
        [InlineData("Tim", 23, "Good evening Tim")]
        [InlineData("Tim", 24, "Good evening Tim")]

        public void GreetingShouldReturnExpectedValue(
            string firstName,
            int hourOfTheDay,
            string expected
            )
        {
            //Act
            string actual = messages.Greeting(firstName, hourOfTheDay);

            //Assert - this should have happened
            Assert.Equal(expected, actual);
        }


    }
}

/*
Unit test tests is only intended to test one unit of work (i.e. one method)
Unit test only tests public methods
You should not test your dependencies, it must be independent of email, database, 
we just want to test the logic
this is called mocking
 */
 