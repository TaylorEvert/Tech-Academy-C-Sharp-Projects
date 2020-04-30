using System;
using System.Collections.Generic;

namespace ArraysListsLoopsDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adds user text to array then prints new text value
            string[] userArray = { "Index 0 of the array. The user added: ", "Index 1 of the array. The user has now added: ",
                "Index 2 of the array. The user keeps adding to the string: ", "Index 3 of the array. Anything else to add? "};
            Console.WriteLine("Please enter some text: ");
            string userAnswer = Console.ReadLine();
            for (int i = 0; i < userArray.Length; i++)
            {
                userArray[i] = userArray[i] + userAnswer;
            }
            for (int s = 0; s < userArray.Length; s++)
            {
                Console.WriteLine(userArray[s]);
            }

            // Fixed infinite loop
            for (int i = 0; i < 50; i--)
            {
                Console.Write("INFINITE ");
                i += 2;
            }

            // Loop using a "<" comparison operator
            for (int i = 0; i < 100; i++)
            {
                if (i == 22)
                {
                    Console.WriteLine("You hit a random number");
                }
                Console.Write("Using the \"<\" operator. ");
                i += 1;
            }

            // Loop using "<=" comparison operator
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(i + " ");
            }

            // String List with output depending on the name chosen 
            List<string> userNames = new List<string>() { "Taylor", "Jacob", "Evan", "Ashley", "Tre", "Nathan" };
            Console.WriteLine("\nPlease select one of the names: 'Taylor','Jacob','Evan','Ashley','Tre','Nathan'");
            string selectedName = Console.ReadLine();
            bool searching = true;
            bool doesExit = true;
            while (searching)
            {
                foreach (string name in userNames)
                {
                    if (selectedName == name)
                    {
                        Console.WriteLine("Corresponding Index: " + userNames.IndexOf(selectedName));
                        searching = false;
                        doesExit = false;
                    }
                }
                if (doesExit)
                {
                    Console.WriteLine("Could not find specified name. Exiting Program.");
                    Environment.Exit(-1);
                }
            }

            // String List with output depending on choice. Duplicate in string list
            List<string> userNames2 = new List<string>() { "Taylor", "Jacob", "Evan", "Ashley", "Tre", "Nathan", "Taylor" };
            Console.WriteLine("\nPlease select one of the names: 'Taylor','Jacob','Evan','Ashley','Tre','Nathan'");
            string thisName = Console.ReadLine();
            bool isSearching = true;
            bool isExit = true;
            while (isSearching)
            {
                foreach (string names in userNames2)
                {
                    if (thisName == names)
                    {
                        Console.WriteLine("Corresponding Index: " + userNames2.IndexOf(thisName));
                        isExit = false;
                    }
                }
                if (isExit)
                {
                    Console.WriteLine("Could not find the selected name. Closing program. ");
                    Environment.Exit(-1);
                }
                isSearching = false;
            }

            // Evaluate list for duplicates and show them
            string duplicateName = "Taylor";
            foreach (string listNames in userNames2)
            {
                bool contains = userNames2.Contains(listNames);
                Console.WriteLine(listNames + " is in the list.");
                if (listNames == duplicateName && contains)
                {
                    Console.WriteLine(listNames + " is in the list more than once. ");
                }
            }

        }
    }
}
