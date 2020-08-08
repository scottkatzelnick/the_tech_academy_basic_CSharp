using System;
using System.Globalization;

namespace TwentyOne
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.\n>>>: ");
            string inputName = Console.ReadLine();

            TextInfo playerNameTI = new CultureInfo("en-US", false).TextInfo; // Creates a TextInfo based on the "en-US" culture
            string lowerPlayerName = playerNameTI.ToLower(inputName); // First pass normalization to lower-case all letters
            string playerName = playerNameTI.ToTitleCase(lowerPlayerName); // Last pass normalization to capitalize player's name

            Console.Write("\nAnd how much money did you bring today?\n>>>: ");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.Write($"\nHello {playerName}. Would you like to join a game of 21, right now?\n>>>: ");
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "yea" || answer == "yup" || answer == "ya" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play(); // Abstract method, contains logic for game itself
                }
                game -= player;
                Console.WriteLine("\nThank you for playing!\n");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now!");
            Console.Read();
        }
    }
}
