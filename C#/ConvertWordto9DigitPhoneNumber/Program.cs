using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertWordto9DigitPhoneNumber
{
    class Program
    {
        static string WordTo9Digit(String word)
        {
            string num = "";
            char [] wordArray = word.ToCharArray();

            Hashtable numPad = new Hashtable();
            numPad.Add("a", "2");
            numPad.Add("b", "2");
            numPad.Add("c", "2");
            numPad.Add("d", "3");
            numPad.Add("e", "3");
            numPad.Add("f", "3");
            numPad.Add("g", "4");
            numPad.Add("h", "4");
            numPad.Add("i", "4");
            numPad.Add("j", "5");
            numPad.Add("k", "5");
            numPad.Add("l", "5");
            numPad.Add("m", "6");
            numPad.Add("n", "6");
            numPad.Add("o", "6");
            numPad.Add("p", "7");
            numPad.Add("q", "7");
            numPad.Add("r", "7");
            numPad.Add("s", "7");
            numPad.Add("t", "8");
            numPad.Add("u", "8");
            numPad.Add("v", "8");
            numPad.Add("w", "9");
            numPad.Add("x", "9");
            numPad.Add("y", "9");
            numPad.Add("z", "9");

            for (int i = 0; i < word.Length; i++)
            {
                if (numPad.ContainsKey(wordArray[i].ToString()))
                {
                    num += numPad[wordArray[i].ToString()];
                }
            }



            return num;
        }
        static void Main(string[] args)
        {
            String word1 = "apple";
            String word2 = "flower";
            String word3 = "aaa";
            String word4 = "abcd";

            //char ab = 'a';
            //ab++;
            //Console.WriteLine(ab);
            Console.WriteLine("Text the word " + word1 + " or 1-800-" + WordTo9Digit(word1));
            Console.WriteLine("Text the word " + word2 + " or 1-800-" + WordTo9Digit(word2));
            Console.WriteLine("Text the word " + word3 + " or 1-800-" + WordTo9Digit(word3));
            Console.WriteLine("Text the word " + word4 + " or 1-800-" + WordTo9Digit(word4));

        }
    }
}
