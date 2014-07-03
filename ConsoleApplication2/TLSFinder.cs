namespace ConsoleApplication2
{
    using System.Text.RegularExpressions;

    public class TLSFinder
    {
        public string Count(document )
        {
            string regex = RegexString();
            string[] tally = FindAllTheThings.Find(string
            document,
            string regex)
            ;
            return tally
        }
    }

    public class FindAllTheThings
    {
        public string Find(string document, string regex)
        {
            for (var i = 0; i < document.Length; i++)
            {
                if (Regex.IsMatch(document[], regex)) {}
            }
        }
    }

    public class RegexString {}
}