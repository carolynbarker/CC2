namespace ConsoleApplication2
{
    public class TLSFinder
    {
        public string RegexString
        {
            get { return "[A-Za-z]{3}"; }
        }

        public int[] Count(string document)
        {
            string regex = RegexString();
            var lowercase = document.ToLower(); //to make the ascii conversions part easier
            var tally = FindAllTheThings.Find(lowercase, regex);
            return tally;
        }
    }
}