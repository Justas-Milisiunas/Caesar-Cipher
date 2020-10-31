using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CaesarCipher
{
    class CaesarTextValidator : ITextValidator
    {
        private const string TEXT_VALIDATOR_REGEX = "^[A-Za-z ]+$";
        public bool IsValid(string text)
        {
            return Regex.IsMatch(text, TEXT_VALIDATOR_REGEX);
        }
    }
}
