using System.Collections.Generic;
using System.IO;
using System;

namespace me.jamesharvey.advent._2020.day04
{
    public static class PassportLoader {
        public static List<Passport> LoadPassports(string filename) {
            List<string> inputValues = new List<string>();
            List<Passport> passports = new List<Passport>();
            using (var reader = new StreamReader(filename))
            {
                string item = reader.ReadLine();
                while(item != null) {
                    if (item != "") {
                        inputValues.Add(item);
                        item = reader.ReadLine();
                    }
                    else {
                        passports.Add(new Passport(inputValues));
                        inputValues.Clear();
                        item = reader.ReadLine();
                    }
                }
                if (inputValues.Count > 0) {
                    passports.Add(new Passport(inputValues));
                    inputValues.Clear();
                }
            }
            return passports;
        }
    }
}