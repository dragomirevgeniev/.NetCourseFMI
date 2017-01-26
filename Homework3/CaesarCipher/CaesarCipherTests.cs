using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    public class CaesarCipherTests
    {
        public static void OpenMenu()
        {
            const int SHIFT_LENGTH = 3; // the shift length
            string plaintext = ""; // the plain text which the user has entered
            string input = ""; // the input choice
            int choice = -1; // the parsed input choice to int
            string currentText; // the current text that has been encoded
            
            Console.WriteLine("Hello! This is a testing Caesar Cipher console application!");
            Console.Write("Please enter the plain text you want to work with: ");
            plaintext = Console.ReadLine(); // user promt to enter the plaintext
            currentText = plaintext; // the current text is the text that the user has entered

            Console.WriteLine("\nPlease choose one of the following options:");
            Console.WriteLine("1) to encrypt the text.");
            Console.WriteLine("2) to deceypt the text.");
            Console.WriteLine("3) to enter a new plaintext.");
            Console.WriteLine("4) to exit.\n");
            while(choice != 4) // exit when the user enters 3
            {
                Console.Write("Please enter your choice: "); // promt for the user to choise an option
                input = Console.ReadLine();
                if (int.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            // when the user has chosen to encrypt the text
                            Console.WriteLine("Current plaintext: {0}", currentText);
                            string encryptedText = CaesarCipher.Encipher(currentText, SHIFT_LENGTH);
                            currentText = encryptedText;
                            Console.WriteLine("Encrypted text: {0}", encryptedText);
                            break;
                        case 2:
                            // when the user has chosen to decrypt the text
                            Console.WriteLine("Current plaintext: {0}", currentText);
                            string decryptedText = CaesarCipher.Decipher(currentText, SHIFT_LENGTH);
                            currentText = decryptedText;
                            Console.WriteLine("Decrypted text: {0}", decryptedText);
                            break;
                        case 3:
                            Console.Write("Enter the new plaintext: ");
                            currentText = Console.ReadLine();
                            Console.WriteLine("A new plaintext has been entered!");
                            break;
                        case 4:
                            // when the user has chosen to exit the application
                            Console.WriteLine("Thanks for using this application! Goodbye!");
                            return;
                        default:
                            // when the user has entered a wrong input
                            Console.WriteLine("Wrong input! Please enter a correct option!");
                            break;
                    }
                }
                else
                {
                    // when the user has enter an input that cannot be parsed to int
                    Console.WriteLine("Wrong input! Please enter a correct option!");
                }
            }
        }

        public static void Main(string[] args)
        {
            OpenMenu(); // loads the menu
        }
    }
}
