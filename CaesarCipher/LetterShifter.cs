using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher
{
    public class LetterShifter
    {
        private const int ALPHABET_LENGTH = 26;
        public char Shift(char letter, int shift)
        {
            CheckIfLetter(letter);

            char startLetter = GetAlphabetStartingLetter(letter);
            int normalizedShift = NormalizeShift(shift);

            return ShiftLetter(letter, normalizedShift, startLetter);
        }

        private void CheckIfLetter(char letter)
        {
            if (!char.IsLetter(letter))
            {
                throw new ArgumentException("Bad character provided. Only letters can be shifted");
            }
        }

        private char GetAlphabetStartingLetter(char letter)
        {
            return char.IsUpper(letter) ? 'A' : 'a';
        }

        private int NormalizeShift(int shift)
        {
            shift %= ALPHABET_LENGTH;
            if (shift < 0)
            {
                shift = ALPHABET_LENGTH - Math.Abs(shift);
            }

            return shift;
        }

        private char ShiftLetter(char letter, int shift, char rangeStartLetter)
        {
            return (char)(((letter + shift - rangeStartLetter) % ALPHABET_LENGTH) + rangeStartLetter);
        }
    }
}
