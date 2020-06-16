using System;

namespace ConstVarChain
{
    class Program
    {
        static void Main(string[] args)
        {
            const string welcome = "Welcome to my program! ";
            Console.WriteLine(welcome + "What is your name?");
            var personName = Console.ReadLine();
            Console.WriteLine("Where are you from? You do not need to answer this question if you feel uncomfortable doing so! ");
            var personLocation = Console.ReadLine();
            if (personLocation == "")
            {
                Chain chain1 = new Chain(personName);
            }
            else
            {
                Chain chain = new Chain(personName, personLocation);
            }

        }
    }
}
