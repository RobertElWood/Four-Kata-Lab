using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLab
{
    public class NumberstoEngKata
    {
        //Dictionary properties store unique values for numeric names
        //Number strings can then be referenced by numeric value and concatenated
        public Dictionary <string, string> SingleNums { get; set; } = new Dictionary<string, string> ();

        //Keys after nineteen reset to single nums, i.e. 2, in this dictionary in order to match the value of numbers in the 'tens' position
        public Dictionary<string, string> DoubleNums { get; set; } = new Dictionary<string, string>();

        //Unlike the other dictionaries, the 'key' represents the number of decimal places (i.e. 3 is paired with value 100)
        public Dictionary<string, string> LargerNums { get; set; } = new Dictionary<string, string>();

        public NumberstoEngKata()
        {
            SingleNums.Add("0", "zero");
            SingleNums.Add("1", "one");
            SingleNums.Add("2", "two");
            SingleNums.Add("3", "three");
            SingleNums.Add("4", "four");
            SingleNums.Add("5", "five");
            SingleNums.Add("6", "six");
            SingleNums.Add("7", "seven");
            SingleNums.Add("8", "eight");
            SingleNums.Add("9", "nine");

            DoubleNums.Add("10", "ten");
            DoubleNums.Add("11", "eleven");
            DoubleNums.Add("12", "twelve");
            DoubleNums.Add("13", "thirteen");
            DoubleNums.Add("14", "fourteen");
            DoubleNums.Add("15", "fifteen");
            DoubleNums.Add("16", "sixteen");
            DoubleNums.Add("17", "seventeen");
            DoubleNums.Add("18", "eighteen");
            DoubleNums.Add("19", "nineteen");
            DoubleNums.Add("2", "twenty");
            DoubleNums.Add("3", "thirty");
            DoubleNums.Add("4", "forty");
            DoubleNums.Add("5", "fifty");
            DoubleNums.Add("6", "sixty");
            DoubleNums.Add("7", "seventy");
            DoubleNums.Add("8", "eighty");
            DoubleNums.Add("9", "ninety");

            LargerNums.Add("3", "hundred");
            LargerNums.Add("4", "thousand");
            LargerNums.Add("7", "million");
            LargerNums.Add("10", "billion");
        }

        public string NumbersToEng(string numString)
        {
            //TryParse to determine if amt entered is number at all.
            var isNumeric = double.TryParse(numString, out double num);

            //Variable to store version of input with decimals trimmed.
            string numStringTrim = "";

            //removes text from right of decimal place, for use where necessary
            if (numString.Contains('.'))
            {
                numStringTrim = numString.Substring(0, numString.LastIndexOf('.'));
            } 
            else
            {
                numStringTrim = numString;
            }

            //If used in a main program, would loop to prompt for new input if isNumeric == false.
            if (numString == null || isNumeric == false)
            {
                return "dummy";
            }
            //Conditionals are based around the length of numString, which indicates num's order of magnitude.
            //LINQ is then used to extract matching string values from dictionary.
            else if (numStringTrim.Length == 1)
            {
                string foundNum = SingleNums.FirstOrDefault(n => n.Key == numStringTrim).Value;
                return foundNum;
            } 
            else if (numStringTrim.Length == 2)
            {
                if (double.Parse(numStringTrim) < 20)
                {
                    string foundNum = DoubleNums.FirstOrDefault(n => n.Key == numStringTrim).Value;
                    return foundNum;
                } 
                else if (numStringTrim[1].ToString() == 0.ToString())
                { 
                    string foundNum = DoubleNums.FirstOrDefault(n => n.Key == numStringTrim[0].ToString()).Value;
                    return foundNum;
                }
                else
                {
                    string firstName = DoubleNums.FirstOrDefault(n => n.Key == numStringTrim[0].ToString()).Value;
                    string secondName = SingleNums.FirstOrDefault(n => n.Key == numStringTrim[1].ToString()).Value;
                   
                    string foundNum = $"{firstName}-{secondName}";
                    return foundNum;
                }
            } 
            else if (numStringTrim.Length == 3)
            { 
                if (numStringTrim[1].ToString() == 0.ToString() && numStringTrim[2].ToString() == 0.ToString())
                {
                    string foundNum = SingleNums.FirstOrDefault(n => n.Key == numStringTrim[0].ToString()).Value + " " + LargerNums.FirstOrDefault(n => int.Parse(n.Key) == numString.Length).Value;
                    return foundNum;
                }
                else if (numStringTrim[1].ToString() != 0.ToString() && numStringTrim[2].ToString() == 0.ToString())
                {
                    string firstName =SingleNums.FirstOrDefault(n => n.Key == numStringTrim[0].ToString()).Value + " " + LargerNums.FirstOrDefault(n => int.Parse(n.Key) == numString.Length).Value;
                    string secondName = DoubleNums.FirstOrDefault(n => n.Key == numStringTrim[1].ToString()).Value;
                    
                    string foundNum = $"{firstName} and {secondName}";
                    return foundNum;
                }
                else
                {
                    string firstName = SingleNums.FirstOrDefault(n => n.Key == numStringTrim[0].ToString()).Value + " " + LargerNums.FirstOrDefault(n => int.Parse(n.Key) == numString.Length).Value;
                    string secondName = DoubleNums.FirstOrDefault(n => n.Key == numStringTrim[1].ToString()).Value;
                    string thirdName = SingleNums.FirstOrDefault(n => n.Key == numStringTrim[2].ToString()).Value;
                    
                    string foundNum = $"{firstName} and {secondName}-{thirdName}";
                    return foundNum;
                }
            } 
            else if (numStringTrim.Length == 4) 
            {
                if (numStringTrim[3].ToString() == 0.ToString() && numStringTrim[2].ToString() == 0.ToString() && numStringTrim[1].ToString() == 0.ToString() && numStringTrim[0].ToString() != 0.ToString())
                {
                    string foundNum = SingleNums.FirstOrDefault(n => n.Key == numStringTrim[0].ToString()).Value + " " + LargerNums.FirstOrDefault(n => int.Parse(n.Key) == numString.Length).Value;
                    return foundNum;
                }
                else if (numStringTrim[3].ToString() == 0.ToString() && numStringTrim[2].ToString() == 0.ToString() && numStringTrim[0].ToString() != 0.ToString() && numStringTrim[1].ToString() != 0.ToString())
                {
                    string firstName = SingleNums.FirstOrDefault(n => n.Key == numStringTrim[0].ToString()).Value + " " + LargerNums.FirstOrDefault(n => int.Parse(n.Key) == numString.Length).Value;
                    string secondName = SingleNums.FirstOrDefault(n => n.Key == numStringTrim[1].ToString()).Value + " " + LargerNums.FirstOrDefault(n => int.Parse(n.Key) == numString.Length-1).Value;

                    string foundNum = $"{firstName} {secondName}";
                    return foundNum;
                }
                else if (numStringTrim[3].ToString() == 0.ToString() && numStringTrim[2].ToString() != 0.ToString() && numStringTrim[0].ToString() != 0.ToString() && numStringTrim[1].ToString() != 0.ToString())
                {
                    string firstName = SingleNums.FirstOrDefault(n => n.Key == numStringTrim[0].ToString()).Value + " " + LargerNums.FirstOrDefault(n => int.Parse(n.Key) == numString.Length).Value;
                    string secondName = SingleNums.FirstOrDefault(n => n.Key == numStringTrim[1].ToString()).Value + " " + LargerNums.FirstOrDefault(n => int.Parse(n.Key) == numString.Length - 1).Value;
                    string thirdName = DoubleNums.FirstOrDefault(n => n.Key == numStringTrim[2].ToString()).Value;

                    string foundNum = $"{firstName} {secondName} and {thirdName}";
                    return foundNum;
                }
                {
                    string firstName = SingleNums.FirstOrDefault(n => n.Key == numStringTrim[0].ToString()).Value + " " + LargerNums.FirstOrDefault(n => int.Parse(n.Key) == numString.Length).Value;
                    string secondName = SingleNums.FirstOrDefault(n => n.Key == numStringTrim[1].ToString()).Value + " " + LargerNums.FirstOrDefault(n => int.Parse(n.Key) == numString.Substring(1).Length).Value;
                    string thirdName = DoubleNums.FirstOrDefault(n => n.Key == numStringTrim[2].ToString()).Value;
                    string fourthName = SingleNums.FirstOrDefault(n => n.Key == numStringTrim[3].ToString()).Value;

                    string foundNum = $"{firstName} {secondName} and {thirdName}-{fourthName}";
                    return foundNum;
                }
            }
            //Right now this works only with numbers up to 9,999...
            //But this would be easy to modify for larger numbers...
            //Although the code would be huge!
            //Just continue the same formula and test methodology!
            else 
            {
                return "That number is too large";
            }

        }
    }
}
