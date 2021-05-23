using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static string Pangrams(string sentence)
        {
            List<string> letters = new List<string>();

            for (int i = 0; i < sentence.Length; i++)
                if (char.IsLetter(sentence[i]))
                    if (!letters.Contains(sentence[i].ToString()))
                        letters.Add(sentence[i].ToString().ToLower());
            return letters.Count == 29 ? "Pangrams" : "Not Prangrams";
        }
        static void Main(string[] args)
        {
            Console.Write("Sentence : ");
            string sentence = Console.ReadLine();

            string getvalue = Pangrams(sentence);
            Console.Write("Screen Output : {0}", getvalue);
            Console.Read();
        }
    }
}
