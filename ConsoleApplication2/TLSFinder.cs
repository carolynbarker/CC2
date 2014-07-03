namespace ConsoleApplication2
{
    using System.Text.RegularExpressions;

    public class TLSFinder
    {
        public string Count(string document)
        {
            string regex = RegexString();
            var lowercase = document.ToLower() //to make the ascii conversions part easier
            var tally = FindAllTheThings.Find(lowercase, regex);
            return tally
        }
    }

    public class FindAllTheThings
    {
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
            tally
        }
    }

    public class RegexString
    {
    return
}

}

    }