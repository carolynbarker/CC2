namespace ConsoleApplication2
{
    using System;

    internal class Program
    {
        public void Run()
        {
            Console.Write("Enter text file location:");
            var input = Console.ReadLine();
            var documentGet = new DocumentGet();
            var document = documentGet.Lookup(input);
            var tally = new TLSFinder().Count(document);
            PrintSomethingRelevant(tally);
        }

        private static void Main()
        {
            new Program().Run();
            Console.Read();
        }

        private void PrintSomethingRelevant(int[] tally)
        {
            Console.Write("Enter desired frequency:");
            var freq = Convert.ToInt32(Console.ReadLine());
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
            var first = (char)((i % 26) + 97);
            var second = (char)((((i - first + 97) % (26 * 26)) / 26) + 97);
            var third = (char)(((i - (first - 97) - (26 * (second - 97))) / (26 * 26)) + 97);
            char[] doireallyneed = { first, second, third };
            var twofuckingsteps = new string(doireallyneed);
            Console.WriteLine(twofuckingsteps);
        }
    }
}