using System;
using System.Text;

namespace StringBuilderDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentenceOne = "This is sentence one of this string. This string will be concatenated. ";
            string sentenceTwo = "This is the second sentence. I come after the first string! ";
            string sentenceThree = "Iam the final string to be concatenated. Leave me for the end! ";

            Console.WriteLine(sentenceOne + sentenceTwo + sentenceThree);
            Console.WriteLine("\nMaking this sentence uppercase: " + sentenceTwo.ToUpper());

            StringBuilder sb = new StringBuilder();

            sb.Append("\nThis sentence will be added as the first sentence in the string builder.\n");
            Console.WriteLine(sb);

            sb.Append("To continue with appending the string builder, I am now going to enter this sentence.\n");
            Console.WriteLine(sb);

            sb.Append("Iam almost down creating a paragraph sentence by sentence. This will make it sentence number 3!\n");
            Console.WriteLine(sb);

            sb.Append("This will be the last sentence in this paragraph. I hope this drill is a pass!");
            Console.WriteLine(sb);
            Console.Read();
        }
    }
}
