using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RomanNumerals.Logic.Tests
{
    public class RomanNumeralsTests
    {
        [TestCase("", 0)]
        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("VII", 7)]
        [TestCase("VIII", 8)]
        [TestCase("IX", 9)]
        [TestCase("X", 10)]
        [TestCase("LXXV", 75)]
        [TestCase("LXXXIX", 89)]
        [TestCase("XCI", 91)]
        [TestCase("XLIII", 43)]
        [TestCase("CIII", 103)]
        [TestCase("DCCLXXXVIII", 788)]
        [TestCase("DCCCXLIV", 844)]
        [TestCase("DCXXIII", 623)]
        [TestCase("MCCCL", 1350)]
        [TestCase("MMCMLXXXIX", 2989)]

        public void Run(string expected, int input)
        {
            //Arrange
            var romanNumeralsLogic = new RomanNumeralsLogic();

            //Act
            var result = romanNumeralsLogic.Get(input);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
