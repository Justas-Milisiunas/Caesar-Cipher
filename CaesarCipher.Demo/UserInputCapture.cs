using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher.Demo
{
    class UserInputCapture
    {
        public UserInputCapture()
        { 
        }

        public string GetPlainText()
        {
            return Console.ReadLine();
        }

        public int GetShiftValue()
        {
            string shiftValue = Console.ReadLine();
            return int.Parse(shiftValue);
        }
    }
}
