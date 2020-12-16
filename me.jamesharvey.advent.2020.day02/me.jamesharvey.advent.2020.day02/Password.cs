using System.Collections.Generic;
using System;
using System.Linq;

namespace me.jamesharvey.advent._2020.day02
{
    public class Password {
        private PasswordPolicy policy;
        private string value;

        public Password (string policyDetails, string passwordValue) {
            policy = new PasswordPolicy(policyDetails);
            value = passwordValue;
        }
        
        public bool IsValid {
            get {
                int occurances = value.Count(f => f == policy.RestrictedLetter);
                if (occurances >= policy.MinimumOccurances && occurances <= policy.MaximumOccurances) {
                    return true;
                } else {
                    return false;
                }
                
            }  
        }
    }
}