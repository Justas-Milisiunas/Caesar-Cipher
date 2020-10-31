using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher
{
    public class CaesarCipher
    {
        private readonly TextValidator textValidator;
        private readonly LetterShifter letterShifter;

        public CaesarCipher()
        {
            textValidator = new TextValidator();
            letterShifter = new LetterShifter();
        }

        public string Encrypt(string plainText, int shift)
        {
            CheckIfTextValid(plainText);
            return CaesarCipherAlhorithm(plainText, shift);
        }

        public string Decrypt(string cipherText, int shift)
        {
            CheckIfTextValid(cipherText);
            return CaesarCipherAlhorithm(cipherText, -shift);
        }

        private void CheckIfTextValid(string text)
        {
            if (!textValidator.IsValid(text))
            {
                throw new ArgumentException("Invalid text provided!");
            }
        }

        private string CaesarCipherAlhorithm(string text, int shift)
        {
            char[] letters = text.ToCharArray();
            StringBuilder modifiedText = new StringBuilder();

            foreach (var letter in letters)
            {
                if (char.IsWhiteSpace(letter))
                {
                    modifiedText.Append(letter);
                    continue;
                }

                char shiftedLetter = letterShifter.Shift(letter, shift);
                modifiedText.Append(shiftedLetter);
            }

            return modifiedText.ToString();
        }
    }
}
