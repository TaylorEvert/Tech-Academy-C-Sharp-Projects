using System;
using System.Collections.Generic;

namespace ArrayDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            // String Array with output to console depending on index choice
            string[] stringArray = {"You chose me in the array! Iam at index 0.", "This is the second string in the array. Iam at index 1." ,
                    "This is another sentence in the string array. Iam at index 2.", "Iam the last sentence in the string array. Iam at index 3. " };
            Console.WriteLine("Please choose a sentence from the array. Options: '0','1','2','3'");
            int chosenSentence = Convert.ToInt32(Console.ReadLine());
            if (chosenSentence > 3)
            {
                Console.WriteLine("Option Not Available. Closing Program.");
                Environment.Exit(-1);
            }
            Console.WriteLine(stringArray[chosenSentence]);

            // Integer Array with output to console depending on index choice
            int[] numArray = {12,13,55,68,75,1,89,18,70 };
            Console.WriteLine("Please choose an index from the array. Options: '0','1','2','3','4','5','6','7','8'");
            int chosenNum = Convert.ToInt32(Console.ReadLine());
            if (chosenNum > 8)
            {
                Console.WriteLine("Option Not Available. Closing Program.");
                Environment.Exit(-1);
            }
            Console.WriteLine(numArray[chosenNum]);

            // String List with output to console depending on index choice
            List<string> stringList = new List<string>();
            stringList.Add("Iam the first sentence in the list. Iam at index 0. ");
            stringList.Add("Iam the second sentence from this list. Iam at index 1. ");
            stringList.Add("Iam the third sentence from the list. Iam at index 2. ");
            stringList.Add("Add me to the list at index 3! ");
            stringList.Add("I want to be at index 4 as the 5th sentence! ");
            Console.WriteLine("Please choose a sentence from the list. Options: '0','1','2','3','4'");
            int chosenList = Convert.ToInt32(Console.ReadLine());
            if (chosenList > 4)
            {
                Console.WriteLine("Option Not Available. Closing Program.");
                Environment.Exit(-1);
            }
            Console.WriteLine(stringList[chosenList]);
            Console.Read();

        }
    }
}
