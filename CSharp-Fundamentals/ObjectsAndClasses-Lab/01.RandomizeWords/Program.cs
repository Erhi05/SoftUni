namespace _01.RandomizeWords
{
    internal class Program
    {
        class RandomizeWords
        {
            public string Input { get; set; }
            public List<string> RandomizedInput { get; set; }

            public void Randomize()
            {
                RandomizedInput = new List<string>();

                List<string> splitted = Input.Split(" ").ToList();
                int count = splitted.Count;
                Random random = new Random();

                for (int i = 0; i < count; i++)
                {
                    int index = random.Next(0, splitted.Count);
                    RandomizedInput.Add(splitted[index]);

                    splitted.RemoveAt(index);
                }
            }
        }

        static void Main(string[] args)
        {
            RandomizeWords randomizeWords = new RandomizeWords();

            randomizeWords.Input = Console.ReadLine();
            randomizeWords.Randomize();

            foreach (var word in randomizeWords.RandomizedInput)
            {
                Console.WriteLine(word);
            }
        }
    }
}
