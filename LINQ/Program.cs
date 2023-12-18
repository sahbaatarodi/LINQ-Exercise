using System;
using System.Collections.Generic;
using System.Linq;
namespace Linq
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string> { "The legend of Zelda", "Tetris", "Pac-Man", "Minecraft" };
            var orderedGames = videoGames.OrderBy(game => game.Length);

            foreach (var game in orderedGames)
            {
                Console.WriteLine(game);
            }

        }
    }
}
