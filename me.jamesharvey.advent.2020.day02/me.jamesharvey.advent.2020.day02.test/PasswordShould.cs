using System;
using Xunit;

namespace me.jamesharvey.advent._2020.day02.test
{
    public class PasswordShould
    {
        [Fact]
        public void ReturnTrue_FromIsValid_WhenPasswordIsValid()
        {
            Password password = new Password("1-3 a", "abcde");
            Assert.True(password.IsValid);
            Password password2 = new Password("2-9 c", "ccccccccc");
            Assert.True(password2.IsValid);
        }

        [Fact]
        public void ReturnFalse_FromIsValid_WhenPasswordIsInvalid()
        {
            Password password = new Password("1-3 b", "cdefg");
            Assert.False(password.IsValid);
        }
    }
}
