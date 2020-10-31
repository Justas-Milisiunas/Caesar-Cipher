using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher
{
    class CaesarCipher : ICaesarCipher
    {
        private readonly ITextValidator textValidator;

        public CaesarCipher()
        {
            textValidator = new CaesarTextValidator();
        }

        public CaesarCipher(ITextValidator textValidator)
        {
            this.textValidator = textValidator;
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
            if(!textValidator.IsValid(text))
            {
                throw new ArgumentException("Invalid text provided!");
            }
        }

        private static string CaesarCipherAlhorithm(string text, int shift)
        {
            char[] letters = text.ToCharArray();
            StringBuilder modifiedText = new StringBuilder();

            foreach (var letter in letters)
            {
                if (Char.IsWhiteSpace(letter))
                {
                    modifiedText.Append(letter);
                    continue;
                }

                char shiftedLetter = ShiftLetter(letter, shift);
                modifiedText.Append(shiftedLetter);
            }

            return modifiedText.ToString();
        }

        private static char ShiftLetter(char letter, int shift)
        {
            return (char)(letter + shift);
        }
    }
}
