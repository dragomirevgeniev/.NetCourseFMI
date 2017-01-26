using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranspositionCipher
{
    class TranspositionCipherTests
    {
        static void Main(string[] args)
        {
            Encryption encryption = new Encryption("beauty");
            string plainText = "thisistheplaintext";
            string encryptedText = encryption.Encrypt(plainText);
            Console.WriteLine("Plaintext: {0}", plainText);
            Console.WriteLine("Encrypted text: {0}", encryptedText);
            Console.WriteLine("Decrypted text: {0}", encryption.Decrypt(encryptedText));
        }
    }
}
