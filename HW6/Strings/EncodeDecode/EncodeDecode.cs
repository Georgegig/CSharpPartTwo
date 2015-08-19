using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeDecode
{
    class EncodeDecode
    {
        static void Main()
        {
            Console.WriteLine("Input the cipher");
            string cipher = Console.ReadLine();
            Console.WriteLine("input the message to be coded");
            string str = Console.ReadLine();


            EncoderDecoder(EncoderDecoder(str, cipher), cipher);
        }

        static string EncoderDecoder(string message, string key)
        {
            var strBuilder = new StringBuilder();
            for (int i = 0; i < message.Length; i++)
            {
                strBuilder.Append((char)(message[i] ^ key[i % key.Length]));
            }
            Console.WriteLine(strBuilder.ToString());
            return strBuilder.ToString();
        }
    }
}
