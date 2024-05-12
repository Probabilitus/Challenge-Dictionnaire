namespace Challenge_Dictionnaire
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mots = new Dictionary<string, string>()
            {
                { "a", "bonjour" },
                { "b", "hello" },
                { "c", "salut" }

            };
            foreach (var mot in mots)
            {
                Console.WriteLine(mot.Value);
            }
        }
    }
}