namespace ConsoleApplication2
{
    public class TLSFinder
    {
        public int[] Count(string document)
        {
            var regex = "[A-Za-z]{3}";
            var lowercase = document.ToLower(); //to make the ascii conversions part easier
            var tally = FindAllTheThings.Find(lowercase, regex);
            return tally;
        }
    }
}