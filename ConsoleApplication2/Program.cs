namespace ConsoleApplication2
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            Console.Write("Enter text file location:");
            var input = Console.ReadLine();
            var document = DocumentGet.Lookup(input);
            string[] tally = TLSFinder.Count(document);
            PrintSomethingRelevant(tally);
        }
    }