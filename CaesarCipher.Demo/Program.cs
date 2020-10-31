using System;

namespace CaesarCipher.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            RunDemoUntilUserQuits();
        }

        static void RunDemoUntilUserQuits()
        {
            while (true)
            {
                RunDemoWithExceptionHandling();

                Console.WriteLine("Type q to quit or any key to continue: ");
                string userChoice = Console.ReadLine();

                if (userChoice == "q")
                    break;
            }
        }

        static void RunDemoWithExceptionHandling()
        {
            try
            {
                RunDemo();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void RunDemo()
        {
            CaesarCipher caesarCipher = new CaesarCipher();
            UserInputCapture userInput = new UserInputCapture();

            Console.Write("Enter plaintext: ");
            string plainText = userInput.GetPlainText();

            Console.Write("Enter shift value: ");
            int shift = userInput.GetShiftValue();

            string cipherText = caesarCipher.Encrypt(plainText, shift);
            string decryptedText = caesarCipher.Decrypt(cipherText, shift);

            Console.WriteLine($"Cipher text: {cipherText}");
            Console.WriteLine($"Decrypted cipher text: {decryptedText}");
        }
    }
}
