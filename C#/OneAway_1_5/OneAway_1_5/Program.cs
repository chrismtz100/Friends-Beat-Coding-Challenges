using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneAway_1_5
{
    class Program
    {
        static Boolean checkReplacement(String x, String y)
        {
            if (x.Equals(y)) //No change
            {
                return false;
            }
            for (int i = 0; i < x.Length; i++)
            {
                if (x.Substring(i,1) != y.Substring(i,1))
                {
                    return true;
                }
            }
            return false;
        }
        static Boolean checkInsertionDeletion(String x, String y)
        {
            return false;
        }
        //OneAway: TRUE = There is a change that is one char away. FALSE = There was no change at all OR there is more than 1 change away.
        static Boolean OneAway(String x, String y)
        {
            bool foundDifference = false;
            //Insertion, Replacement, Deletion, or Nothing

            if (x.Length == y.Length) { //Replacement is 1 char diff 
                return checkReplacement(x, y);
            }
            else //Insertion/Deletion is either 1 char more or less
            {
                if (x.Length+1 == y.Length) //Insertion
                {
                    return checkInsertionDeletion(x, y);
                }
                else if (x.Length-1 == y.Length) //D
                                                 //eletion
                {
                    return checkInsertionDeletion(y, x);
                }
                else
                {
                    return foundDifference;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(OneAway("pale", "pale")); //false - No change
            Console.WriteLine(OneAway("paless", "pale")); //false - insertion - 2 away
            Console.WriteLine(OneAway("pale", "ple")); //true - deletion - 1 away
            Console.WriteLine(OneAway("pales", "pale")); //true - insertion - 1 away
            Console.WriteLine(OneAway("pale", "bale")); //true - replacement - 1 away
            Console.WriteLine(OneAway("pale", "bae")); //false - deletion AND replacement - 2 away
            Console.ReadKey();
        }
    }
}
