using System.Collections.Generic;
using System;

namespace me.jamesharvey.advent._2020.day02
{
    public class PasswordPolicy {
        public int FirstPosition { get;} = 0;
        public int SecondPosition { get;} = 0;
        public char RestrictedLetter { get;}
        
        public PasswordPolicy(string policyDetails) {
            if (!String.IsNullOrWhiteSpace(policyDetails) && policyDetails.Length >= 5 ) {
                var positionDelimeterPosition = policyDetails.IndexOf('-');
                var positionEndPosition = policyDetails.IndexOf(' ');
                FirstPosition = int.Parse(policyDetails.Substring(0, positionDelimeterPosition));
                SecondPosition = int.Parse(policyDetails.Substring(positionDelimeterPosition+1, positionEndPosition - positionDelimeterPosition - 1));
                string letter = policyDetails.Substring(positionEndPosition+1);
                RestrictedLetter = char.Parse(letter);
            }
            else {
                throw new ArgumentException("Invalid Policy Text");
            }
        }
    }
}