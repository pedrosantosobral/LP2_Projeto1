using System;
using System.IO;

namespace LP2_Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] game = File.ReadAllLines("games.csv");

            for (int i = 1; i < game.Length; i++)
            {
                Game g = new Game(game[i]);
            }
        }
    }
}