using System;
using System.Collections.Generic;

namespace TwentyOne
{
    public abstract class Game // Abstarct Class - Never instantiated, just inherited
    {
        // Props
        public List<string> Players { get; set; }

        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play(); // Abstract Method - Needs to be implemented in inheriting class, never here

        public virtual void ListPlayers() // Virtual Method - Can have implementation here, but can be overriden
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
