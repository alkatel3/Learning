namespace Trie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var trie = new Trie<int>();
            trie.Add("привіт", 50);
            trie.Add("світ", 100);
            trie.Add("приз", 200);
            trie.Add("провививка", 50);
            trie.Add("світовий", 100);
            trie.Add("подарунок", 200);
            trie.Add("прапор", 200);
            trie.Add("рік", 50);
            trie.Add("ріка", 1000);

            trie.Remove("провививка");
            trie.Remove("рік");

            Search(trie, "привіт");
            Search(trie, "провививка");
            Search(trie, "рік");

        }

        private static void Search(Trie<int> trie, string word)
        {
            if (trie.TrySearch(word, out int result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Didn't fint");
            }
        }
    }
}