using System;
using System.Collections.Generic;
using Xunit;

namespace me.jamesharvey.advent._2020.day04.test
{
    public class PassportShould
    {
        [Fact]
        public void PopulateBirthYear_WhenPopulatePassportPropertiesCalled_WithbyrValue()
        {
            Passport passport = new Passport(new List<string>());
            passport.PopulatePassportProperties("byr:2000");
            Assert.Equal("2000", passport.BirthYear);
        }
        
        [Fact]
        public void PopulateCountryId_WhenPopulatePassportPropertiesCalled_WithcidValue()
        {
            Passport passport = new Passport(new List<string>());
            passport.PopulatePassportProperties("cid:89");
            Assert.Equal("89", passport.CountryId);
        }
        
        [Fact]
        public void PopulateExpirationYear_WhenPopulatePassportPropertiesCalled_WitheyrValue()
        {
            Passport passport = new Passport(new List<string>());
            passport.PopulatePassportProperties("eyr:2034");
            Assert.Equal("2034", passport.ExpirationYear);
        }
        
        [Fact]
        public void PopulateEyeColour_WhenPopulatePassportPropertiesCalled_WitheclValue()
        {
            Passport passport = new Passport(new List<string>());
            passport.PopulatePassportProperties("ecl:amb");
            Assert.Equal("amb", passport.EyeColour);
        }
        
        [Fact]
        public void PopulateHairColour_WhenPopulatePassportPropertiesCalled_WithhclValue()
        {
            Passport passport = new Passport(new List<string>());
            passport.PopulatePassportProperties("hcl:#fffffd");
            Assert.Equal("#fffffd", passport.HairColour);
        }
        
        [Fact]
        public void PopulateHeight_WhenPopulatePassportPropertiesCalled_WithhgtValue()
        {
            Passport passport = new Passport(new List<string>());
            passport.PopulatePassportProperties("hgt:176cm");
            Assert.Equal("176cm", passport.Height);
        }
        
        [Fact]
        public void PopulateIssueYear_WhenPopulatePassportPropertiesCalled_WithiyrValue()
        {
            Passport passport = new Passport(new List<string>());
            passport.PopulatePassportProperties("iyr:2013");
            Assert.Equal("2013", passport.IssueYear);
        }
        
        [Fact]
        public void PopulatePassportId_WhenPopulatePassportPropertiesCalled_WithpidValue()
        {
            Passport passport = new Passport(new List<string>());
            passport.PopulatePassportProperties("pid:934693255");
            Assert.Equal("934693255", passport.PassportId);
        }
        
        [Fact]
        public void ThrowException_WhenPopulatePassportPropertiesCalled_WithInvalidValue()
        {
            Passport passport = new Passport(new List<string>());
            var ex = Assert.Throws<ArgumentException>(() => passport.PopulatePassportProperties("abc:xyz"));
            Assert.Equal("Invalid Passport detail - abc:xyz", ex.Message);
        }
        
        [Fact]
        public void PopulateDetails_WhenConstructed_With1ValueOn1line()
        {
            Passport passport = new Passport(new List<string>() {"cid:89"});
            Assert.Equal("89", passport.CountryId);
            Assert.Null(passport.BirthYear);
            Assert.Null(passport.ExpirationYear);
            Assert.Null(passport.EyeColour);
            Assert.Null(passport.HairColour);
            Assert.Null(passport.Height);
            Assert.Null(passport.IssueYear);
            Assert.Null(passport.PassportId);
        }
        
        [Fact]
        public void PopulateDetails_WhenConstructed_With2ValuesOn1line()
        {
            Passport passport = new Passport(new List<string>() {"cid:89 pid:934693255"});
            Assert.Equal("89", passport.CountryId);
            Assert.Equal("934693255", passport.PassportId);
            Assert.Null(passport.BirthYear);
            Assert.Null(passport.ExpirationYear);
            Assert.Null(passport.EyeColour);
            Assert.Null(passport.HairColour);
            Assert.Null(passport.Height);
            Assert.Null(passport.IssueYear);
        }
        
        [Fact]
        public void PopulateDetails_WhenConstructed_With3ValuesOn1line()
        {
            Passport passport = new Passport(new List<string>() {"cid:89 pid:934693255 iyr:2013"});
            Assert.Equal("89", passport.CountryId);
            Assert.Equal("934693255", passport.PassportId);
            Assert.Equal("2013", passport.IssueYear);
            Assert.Null(passport.BirthYear);
            Assert.Null(passport.ExpirationYear);
            Assert.Null(passport.EyeColour);
            Assert.Null(passport.HairColour);
            Assert.Null(passport.Height);
        }
        
        [Fact]
        public void PopulateDetails_WhenConstructed_With2ValuesOn2lines()
        {
            Passport passport = new Passport(new List<string>() {"cid:89","pid:934693255"});
            Assert.Equal("89", passport.CountryId);
            Assert.Equal("934693255", passport.PassportId);
            Assert.Null(passport.BirthYear);
            Assert.Null(passport.ExpirationYear);
            Assert.Null(passport.EyeColour);
            Assert.Null(passport.HairColour);
            Assert.Null(passport.Height);
            Assert.Null(passport.IssueYear);
        }
        
        [Fact]
        public void PopulateDetails_WhenConstructed_With3ValuesOn2line()
        {
            Passport passport = new Passport(new List<string>() {"cid:89 pid:934693255","iyr:2013"});
            Assert.Equal("89", passport.CountryId);
            Assert.Equal("934693255", passport.PassportId);
            Assert.Equal("2013", passport.IssueYear);
            Assert.Null(passport.BirthYear);
            Assert.Null(passport.ExpirationYear);
            Assert.Null(passport.EyeColour);
            Assert.Null(passport.HairColour);
            Assert.Null(passport.Height);
        }
        
        [Fact]
        public void ReturnTrue_FromIsValid_WhenAllValuesPresent()
        {
            Passport passport = new Passport(new List<string>() {"ecl:gry pid:860033327 eyr:2020 hcl:#fffffd", "byr:1937 iyr:2017 cid:147 hgt:183cm"});
            Assert.True(passport.IsValid);
        }
        
        [Fact]
        public void ReturnFalse_FromIsValid_WhenMissingHeight()
        {
            Passport passport = new Passport(new List<string>() {"iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884", "hcl:#cfa07d byr:1929"});
            Assert.False(passport.IsValid);
        }
        
        [Fact]
        public void ReturnTrue_FromIsValid_WhenMissingCountryId()
        {
            Passport passport = new Passport(new List<string>() {"hcl:#ae17e1 iyr:2013", "eyr:2024", "ecl:brn pid:760753108 byr:1931", "hgt:179cm"});
            Assert.True(passport.IsValid);
        }
        
        [Fact]
        public void ReturnFalse_FromIsValid_WhenMissingCountryIdAndBirthYear()
        {
            Passport passport = new Passport(new List<string>() {"hcl:#cfa07d eyr:2025 pid:166559648", "iyr:2011 ecl:brn hgt:59in"});
            Assert.False(passport.IsValid);
        }
        
        [Fact]
        public void ReturnFalse_FromIsValid_WhenMissingPassportID()
        {
            Passport passport = new Passport(new List<string>() {"ecl:gry eyr:2020 hcl:#fffffd", "byr:1937 iyr:2017 cid:147 hgt:183cm"});
            Assert.False(passport.IsValid);
        }
        
        [Fact]
        public void ReturnFalse_FromIsValid_WhenMissingBirthYear()
        {
            Passport passport = new Passport(new List<string>() {"ecl:gry pid:860033327 eyr:2020 hcl:#fffffd", "iyr:2017 cid:147 hgt:183cm"});
            Assert.False(passport.IsValid);
        }
        
        [Fact]
        public void ReturnFalse_FromIsValid_WhenMissingExpirationYear()
        {
            Passport passport = new Passport(new List<string>() {"ecl:gry pid:860033327 hcl:#fffffd", "byr:1937 iyr:2017 cid:147 hgt:183cm"});
            Assert.False(passport.IsValid);
        }
        
        [Fact]
        public void ReturnFalse_FromIsValid_WhenMissingEyeColour()
        {
            Passport passport = new Passport(new List<string>() {"pid:860033327 eyr:2020 hcl:#fffffd", "byr:1937 iyr:2017 cid:147 hgt:183cm"});
            Assert.False(passport.IsValid);
        }
        
        [Fact]
        public void ReturnFalse_FromIsValid_WhenMissingHairColour()
        {
            Passport passport = new Passport(new List<string>() {"ecl:gry pid:860033327 eyr:2020", "byr:1937 iyr:2017 cid:147 hgt:183cm"});
            Assert.False(passport.IsValid);
        }
        
        [Fact]
        public void ReturnFalse_FromIsValid_WhenMissingIssueYear()
        {
            Passport passport = new Passport(new List<string>() {"ecl:gry pid:860033327 eyr:2020 hcl:#fffffd", "byr:1937 cid:147 hgt:183cm"});
            Assert.False(passport.IsValid);
        }
    }
}
