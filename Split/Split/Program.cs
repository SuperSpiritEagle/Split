using System;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Мороз и солнце день чудесный";

            string[] words = text.Split(new char[] { });

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
