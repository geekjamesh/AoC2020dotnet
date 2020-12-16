using System.Collections.Generic;
using System;

namespace me.jamesharvey.advent._2020.day02
{
    public class PasswordPolicy {
        public int MinimumOccurances { get;} = 0;
        public int MaximumOccurances { get;} = 0;
        public char RestrictedLetter { get;}
        
        public PasswordPolicy(string policyDetails) {
            if (!String.IsNullOrWhiteSpace(policyDetails) && policyDetails.Length >= 5 ) {
                var rangeDelimeterPosition = policyDetails.IndexOf('-');
                var rangeEndPosition = policyDetails.IndexOf(' ');
                MinimumOccurances = int.Parse(policyDetails.Substring(0, rangeDelimeterPosition));
                MaximumOccurances = int.Parse(policyDetails.Substring(rangeDelimeterPosition+1, rangeEndPosition - rangeDelimeterPosition - 1));
                string letter = policyDetails.Substring(rangeEndPosition+1);
                RestrictedLetter = char.Parse(letter);
            }
            else {
                throw new ArgumentException("Invalid Policy Text");
            }
        }
    }
}