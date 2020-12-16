using System;
using Xunit;

namespace me.jamesharvey.advent._2020.day02.test
{
    public class PasswordPolicyShould
    {
        [Fact]
        public void SetPropertiesCorrectly_WhenGiven_PolicyText_WithSingleDigitOccurances()
        {
            string policyText = "1-3 a";
            PasswordPolicy policy = new PasswordPolicy(policyText);
            Assert.Equal(1, policy.MinimumOccurances);
            Assert.Equal(3, policy.MaximumOccurances);
            Assert.Equal('a', policy.RestrictedLetter);
        }
        [Fact]
        public void SetPropertiesCorrectly_WhenGiven_PolicyText_WithDoubleDigitOccurances()
        {
            string policyText = "10-30 a";
            PasswordPolicy policy = new PasswordPolicy(policyText);
            Assert.Equal(10, policy.MinimumOccurances);
            Assert.Equal(30, policy.MaximumOccurances);
            Assert.Equal('a', policy.RestrictedLetter);
        }
    }
}
