using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher.Tests
{
    [TestClass]
    public class LetterShifterTests
    {
        LetterShifter letterShifter;

        [TestInitialize]
        public void Startup()
        {
            letterShifter = new LetterShifter();
        }

        [DataRow('a', 1, 'b', DisplayName = "Letter from the alphabet start with small shift")]
        [DataRow('Z', 1, 'A', DisplayName = "Uppercase letter from the alphabet end with small shift")]
        [DataRow('l', 1, 'm', DisplayName = "Letter from the alphabet middle with small shift")]
        [DataRow('A', 120, 'Q', DisplayName = "Uppercase letter from the alphabet start with high shift")]
        [DataRow('x', 50, 'v', DisplayName = "Letter from the alphabet end with high shift")]
        [DataRow('A', -1, 'Z', DisplayName = "Uppercase letter from the alphabet start with small negative shift")]
        [DataRow('z', -1, 'y', DisplayName = "Letter from the alphabet end with small negative shift")]
        [DataRow('L', -1, 'K', DisplayName = "Uppercase letter from the alphabet middle with small negative shift")]
        [DataRow('a', -120, 'k', DisplayName = "Letter from the alphabet start with high negative shift")]
        [DataRow('x', -50, 'z', DisplayName = "Letter from the alphabet end with high negative shift")]

        [TestMethod]
        public void ShiftLetter_Test_ShiftedSuccessfully(char letter, int shift, char expectedLetter)
        {
            char shiftedLetter = letterShifter.Shift(letter, shift);

            Assert.AreEqual(expectedLetter, shiftedLetter);
        }

        [DataRow('!', DisplayName = "Random symbol")]
        [DataRow('&', DisplayName = "Random symbol")]
        [DataRow(',', DisplayName = "Random symbol")]
        [DataRow('5', DisplayName = "Random digit")]
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShiftLetter_Test_ThrowedException(char letter)
        {
            letterShifter.Shift(letter, 1);
        }
    }
}
