using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals.Logic
{
    public class RomanNumeralsLogic
    {
        public string Get(int input)
        {
            var inputString = input.ToString();

            var result = "";

            if (inputString.Length == 1)
            {
                var characterAsInt = Char.GetNumericValue(inputString, 0);
                var romanNumeral = GetRomanNumeralFirstChar(characterAsInt);
                result += romanNumeral;
            }

            if (inputString.Length == 2)
            {
                var characterAsInt = Char.GetNumericValue(inputString, 0);
                var romanNumeral = GetRomanNumeralSecondChar(characterAsInt);
                result += romanNumeral;

                characterAsInt = Char.GetNumericValue(inputString, 1);
                romanNumeral = GetRomanNumeralFirstChar(characterAsInt);
                result += romanNumeral;
            }

            if (inputString.Length == 3)
            {
                var characterAsInt = Char.GetNumericValue(inputString, 0);
                var romanNumeral = GetRomanNumeralThirdChar(characterAsInt);
                result += romanNumeral;

                characterAsInt = Char.GetNumericValue(inputString, 1);
                romanNumeral = GetRomanNumeralSecondChar(characterAsInt);
                result += romanNumeral;

                characterAsInt = Char.GetNumericValue(inputString, 2);
                romanNumeral = GetRomanNumeralFirstChar(characterAsInt);
                result += romanNumeral;
            }

            if (inputString.Length == 4)
            {
                var characterAsInt = Char.GetNumericValue(inputString, 0);
                var romanNumeral = GetRomanNumeralFourthChar(characterAsInt);
                result += romanNumeral;

                characterAsInt = Char.GetNumericValue(inputString, 1);
                romanNumeral = GetRomanNumeralThirdChar(characterAsInt);
                result += romanNumeral;

                characterAsInt = Char.GetNumericValue(inputString, 2);
                romanNumeral = GetRomanNumeralSecondChar(characterAsInt);
                result += romanNumeral;

                characterAsInt = Char.GetNumericValue(inputString, 3);
                romanNumeral = GetRomanNumeralFirstChar(characterAsInt);
                result += romanNumeral;

            }

            return result;
        }

       

        private string GetRomanNumeralFirstChar(double input)
        {
            switch (input)
            {
                case 0: return "";
                case 1: return "I";
                case 2: return "II";
                case 3: return "III";
                case 4: return "IV";
                case 5: return "V";
                case 6: return "VI";
                case 7: return "VII";
                case 8: return "VIII";
                case 9: return "IX";
            }

            return "";
        }

        private string GetRomanNumeralSecondChar(double input)
        {
            switch (input)
            {
                case 0: return "";
                case 1: return "X";
                case 2: return "XX";
                case 3: return "XXX";
                case 4: return "XL";
                case 5: return "L";
                case 6: return "LX";
                case 7: return "LXX";
                case 8: return "LXXX";
                case 9: return "XC";
            }

            return "";
        }

        private string GetRomanNumeralThirdChar(double input)
        {
            switch (input)
            {
                case 0: return "";
                case 1: return "C";
                case 2: return "CC";
                case 3: return "CCC";
                case 4: return "CD";
                case 5: return "D";
                case 6: return "DC";
                case 7: return "DCC";
                case 8: return "DCCC";
                case 9: return "CM";
            }

            return "";
        }

        private string GetRomanNumeralFourthChar(double input)
        {
            switch (input)
            {
                case 0: return "";
                case 1: return "M";
                case 2: return "MM";
                case 3: return "MMM";
                
            }

            return "Number is too high";
        }
    }
}
