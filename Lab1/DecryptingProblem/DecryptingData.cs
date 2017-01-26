using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class DecryptingData
    {
        public static void Main(string[] args)
        {
            // Declarations
            int digitOne, digitTwo, digitThree, digitFour;
            int input;

            // Promt message
            Console.Write("Please enter a four-digit number: ");

            // Initializations
            // Read user input
            input = Int32.Parse(Console.ReadLine());
            // Default initialisations
            digitOne = 0;
            digitTwo = 0;
            digitThree = 0;
            digitFour = 0;

            // Encrypting algorithm
            if (input >= 0 && input <= 9)
            {
                digitOne = 0;
                digitTwo = 0;
                digitThree = 0;
                digitFour = input;
            }

            else if (input > 9 && input <= 99)
            {
                digitOne = 0;
                digitTwo = 0;
                digitThree = (input / 10) % 10;
                digitFour = input % 10;
            }

            else if (input > 99 && input <= 999)
            {
                digitOne = 0;
                digitTwo = (input / 100) % 10;
                digitThree = (input / 10) % 10;
                digitFour = input % 10;
            }

            else if (input > 999 && input <= 9999)
            {
                digitOne = input / 1000;
                digitTwo = (input / 100) % 10;
                digitThree = (input / 10) % 10;
                digitFour = input % 10;
            }

            else
            {
                Console.WriteLine("Wrong input!");
            }

            // Encrypting algorithm
            digitOne = (digitOne + 7) % 10;
            digitTwo = (digitTwo + 7) % 10;
            digitThree = (digitThree + 7) % 10;
            digitFour = (digitFour + 7) % 10;
            
            // Output encrypted number
            Console.WriteLine("Encrypted number: {2}{3}{0}{1}", digitOne, digitTwo, digitThree, digitFour);

            // Decrypting algorithm
            if (digitOne < 7)
            {
                digitOne += 3;
            }
            else digitOne -= 7;

            if (digitTwo < 7)
            {
                digitTwo += 3;
            }
            else digitTwo -= 7;

            if (digitThree < 7)
            {
                digitThree += 3;
            }
            else digitThree -= 7;

            if (digitFour < 7)
            {
                digitFour += 3;
            }
            else digitFour -= 7;

            // Output decrypted number
            Console.WriteLine("Decrypted number: {0}{1}{2}{3}", digitOne, digitTwo, digitThree, digitFour);
        }
    }
}

