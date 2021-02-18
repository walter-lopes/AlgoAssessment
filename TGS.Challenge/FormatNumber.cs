using System;
using System.Collections.Generic;

namespace TGS.Challenge
{
    /*
        Devise a function that takes an input 'n' (integer) and returns a string that is the
        decimal representation of that number grouped by commas after every 3 digits. 
        
        NOTES: You cannot use any built-in formatting functions to complete this task.

        Assume: 0 <= n < 1000000000

        1 -> "1"
        10 -> "10"
        100 -> "100"
        1000 -> "1,000"
        10000 -> "10,000"
        100000 -> "100,000"
        1000000 -> "1,000,000"
        35235235 -> "35,235,235"

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class FormatNumber
    {
        public string Format(int value)
        {
            string newString = value.ToString();

            if (value < 1 || value > 1000000000)
            {
                throw new ArgumentOutOfRangeException();
            }

            else if (newString.Length <= 3)
            {
                return newString;
            }

            int counter = 0;
            int maxIndex = newString.Length;
            int commasToAdd = (newString.Length / 3);
           

            while (commasToAdd >= 0)
            {
                counter += 1;
                int commaPlacement = 3 * counter;

                int delimiterIndex = maxIndex - commaPlacement;
                bool isValidIndex = delimiterIndex > 0;

                if (isValidIndex)
                {
                    var valueFromDelimiterIndex = newString[delimiterIndex].ToString();

                    newString = $"{newString.Substring(0, delimiterIndex)},{valueFromDelimiterIndex}{newString[(delimiterIndex + 1)..]}";
                }

                commasToAdd -= 1;
            }

            return newString;
        }
    }
}
