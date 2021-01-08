using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

namespace me.jamesharvey.advent._2020.day04
{
    public class Passport {

        public string BirthYear { get; set; }
        public string IssueYear { get; set; }
        public string ExpirationYear { get; set; }
        public string Height { get; set; }
        public string HairColour { get; set; }
        public string EyeColour { get; set; }
        public string PassportId { get; set; }
        public string CountryId { get; set; }

        public Passport(List<string> passportListInfo) {
            foreach (string line in passportListInfo) {
                var infoItems = line.Split(" ");
                foreach (string item in infoItems) {
                    PopulatePassportProperties(item);
                }
            }            
        }

        public bool IsValid {
            get {
                if (isValidBirthYear(BirthYear) && isValidIssueYear(IssueYear) && isValidExpirationYear(ExpirationYear) && isValidHeight(Height)
                        && isValidHairColour(HairColour) && isValidEyeColour(EyeColour) && isValidPassportId(PassportId) && isValidCountryId(CountryId)) {
                    return true;
                }
                return false;
            }
        }

        public void PopulatePassportProperties(string detail) {
            var details = detail.Split(":");
            switch (details[0])
            {
                case "byr":
                    BirthYear = details[1];
                    break;
                case "iyr":
                    IssueYear = details[1];
                    break;
                case "eyr":
                    ExpirationYear = details[1];
                    break;
                case "hgt":
                    Height = details[1];
                    break;
                case "hcl":
                    HairColour = details[1];
                    break;
                case "ecl":
                    EyeColour = details[1];
                    break;
                case "pid":
                    PassportId = details[1];
                    break;
                case "cid":
                    CountryId = details[1];
                    break;
                default:
                    throw new ArgumentException($"Invalid Passport detail - {detail}");
            }
        }

        private bool isValidBirthYear(string value){
            if (value == null) {
                return false;
            }
            if (value.Length != 4) {
                return false;
            }
            try {
                int year = int.Parse(value);
                if (year <1920 || year > 2002) {
                    return false;
                }
            }
            catch (Exception ex) {
                Console.WriteLine($"Error parsing year {value} - {ex.Message}");
                return false;
            }
            
            return true;
        }

        private bool isValidIssueYear(string value){
            if (value == null) {
                return false;
            }
            if (value.Length != 4) {
                return false;
            }
            try {
                int year = int.Parse(value);
                if (year < 2010 || year > 2020) {
                    return false;
                }
            }
            catch (Exception ex) {
                Console.WriteLine($"Error parsing year {value} - {ex.Message}");
                return false;
            }
            return true;
        }

        private bool isValidExpirationYear(string value){
            if (value == null) {
                return false;
            }
            if (value.Length != 4) {
                return false;
            }
            try {
                int year = int.Parse(value);
                if (year < 2020 || year > 2030) {
                    return false;
                }
            }
            catch (Exception ex) {
                Console.WriteLine($"Error parsing year {value} - {ex.Message}");
                return false;
            }
            return true;
        }

        private bool isValidHeight(string value){
            if (value == null) {
                return false;
            }
            if (Regex.IsMatch(value, "^\\d+(in|cm)$", RegexOptions.IgnoreCase)) {
                int cm = value.IndexOf("cm");
                int inch = value.IndexOf("in");
                if (cm > 0) {
                    int heightCm = int.Parse(value.Substring(0, cm));
                    if (heightCm < 150 || heightCm > 193) {
                        return false;
                    }
                }
                else if (inch > 0) {
                    int heightIn = int.Parse(value.Substring(0, inch));
                    if (heightIn < 59 || heightIn > 76) {
                        return false;
                    }
                }
                else {
                    return false;
                }
            }
            else {
                return false;
            }
            return true;
        }

        private bool isValidHairColour(string value){
            if (value == null) {
                return false;
            }
            if (!Regex.IsMatch(value, "^#[0-9|a-f]{6}$", RegexOptions.IgnoreCase)) {
                return false;
            }
            return true;
        }

        private bool isValidEyeColour(string value){
            if (value == null) {
                return false;
            }
            if (!Regex.IsMatch(value, "^(amb|blu|brn|gry|grn|hzl|oth)$", RegexOptions.IgnoreCase)) {
                return false;
            }
            return true;
        }

        private bool isValidPassportId(string value){
            if (value == null) {
                return false;
            }
            if (!Regex.IsMatch(value, "^\\d{9}$", RegexOptions.IgnoreCase)) {
                return false;
            }
            return true;
        }

        private bool isValidCountryId(string value){
            return true;
        }

    }
}