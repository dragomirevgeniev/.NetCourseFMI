using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    public class CaesarCipher
    {
        // method that shifts the chars
        private static char Cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
                return ch;

            char offset = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - offset) % 26) + offset);
        }

        // method that encrypt the plaintext
        public static string Encipher(string input, int key)
        {
            string output = "";

            foreach (char ch in input)
                output += Cipher(ch, key);

            return output;
        }

        // method that decrypt the plaintext
        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }
    }
}
