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
                var occurances = new List<int>();
                for(int index = 0;index < value.Length; index+=1) {
                    if (value[index] == policy.RestrictedLetter) {
                        occurances.Add(index+1);
                    }
                }

                if (occurances.Count == 0) {
                    return false;
                }
                else {
                    if (occurances.Contains(policy.FirstPosition) ^ occurances.Contains(policy.SecondPosition)){
                        return true;
                    }
                    else {
                        return false;
                    }
                }

            }  
        }
    }
}