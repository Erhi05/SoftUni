namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            char[] stringArray = username.ToCharArray();
            Array.Reverse(stringArray);
            string password = new string(stringArray);
            int attempts = 4;

            while (attempts > 0)
            {
                attempts--;
                string typedPass = Console.ReadLine();
                if (password == typedPass)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    Console.WriteLine(attempts == 0 ? $"User {username} blocked!" : "Incorrect password. Try again.");
                }
            }
        }
    }
}
