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
            var tally = TLSFinder.Count(document);
            PrintSomethingRelevant(tally);
        }

        private void PrintSomethingRelevant(int[] tally)
        {
            Console.Write("Enter desired frequency:");
            var freq = Console.ReadLine();
            FindThoseTLSs(freq, tally);
        }

        private void FindThoseTLSs(int freq, int[] tally)
        {
            for (var i = 0; i < tally.Length; i++)
            {
                if (tally[i] == freq)
                {
                    Deconvert(i);
                }
            }
        }

        private void Deconvert(int i)
        {
            var first = (char)((i % 27) + 97);
            var second = (char)((((i - first) % (27 * 27)) / 27) + 97);
            var third = (char)(((i - first - 27 * second) / (27 * 27)) + 97);
            Console.WriteLine(first, second, third);
        }
    }
}