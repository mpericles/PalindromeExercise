using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        //[Fact]
        [Theory]
       // [InlineData("")]
        [InlineData("racecar", true)]
        [InlineData("madam", true)]
        [InlineData("mom", true)]
        [InlineData("myriam", false)]
        //public void Test1()
        public void IsPalidromeTest(string testWord, bool expected)
        {
            //Arrage = Prep
            //Instancciate 
            var instance = new WordSmith();


            //Act - Call the Method
            var actual = instance.IsPalindrome(testWord);


            //Asset - Compare
            Assert.Equal(expected, actual);


        }
    }
}
