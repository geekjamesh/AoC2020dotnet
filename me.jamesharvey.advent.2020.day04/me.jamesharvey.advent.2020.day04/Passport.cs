using System.Collections.Generic;
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
                if (BirthYear != null && IssueYear != null && ExpirationYear != null && Height != null && HairColour != null && EyeColour != null && PassportId != null) {
                    return true;
                }
                else {
                    return false;
                }
                
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

    }
}