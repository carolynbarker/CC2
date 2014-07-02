namespace ConsoleApplication2
{
    using System.IO;

    public class DocumentGet
    {
        public string Lookup(string location)
        {
            return File.ReadAllText(location);
        }
    }
}