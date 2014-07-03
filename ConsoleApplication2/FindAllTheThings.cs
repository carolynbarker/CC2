namespace ConsoleApplication2
{
    using System.Text.RegularExpressions;

    public class FindAllTheThings
    {
        private readonly int[] tally = new int[26 * 26 * 26];

        public int[] Find(string document, string regex)
        {
            for (var i = 0; i < document.Length; i++)
            {
                if (Regex.IsMatch(document.Substring(i, 3), regex))
                {
                    AddToTally(document.Substring(i, 3));
                }
            }
        }

        private void AddToTally(string foundthing)
        {
            var position = GetIndex(foundthing);
            tally[position]++;
        }

        private int GetIndex(string foundthing)
        {
            var first = foundthing[1] - 97;
            var second = foundthing[2] - 97;
            var third = foundthing[3] - 97;
            return first + 27 * second + 27 * 27 * third;
        }
    }
}