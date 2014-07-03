namespace ConsoleApplication2
{
    using System.Text.RegularExpressions;

    public class FindAllTheThings
    {
        public int[] SetupTally()
        {
            var tally = new int[26 * 26 * 26];

            for (var i = 0; i < tally.Length; i++)
            {
                tally[i] = 0;
            }

            return tally;
        }

        public int[] Find(string document, string regex)
        {
            var tally = SetupTally();
            for (var i = 0; i < document.Length - 3; i++)
            {
                if (Regex.IsMatch(document.Substring(i, 3), regex))
                {
                    var position = GetIndex(document.Substring(i, 3));
                    tally[position]++;
                }
            }
            return tally;
        }

        public int GetIndex(string foundthing)
        {
            var first = foundthing[0] - 97;
            var second = foundthing[1] - 97;
            var third = foundthing[2] - 97;
            return first + 26 * second + 26 * 26 * third;
        }
    }
}