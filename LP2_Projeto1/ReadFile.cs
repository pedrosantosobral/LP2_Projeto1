using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace LP2_Projeto1
{
    /// <summary>
    /// Class that reads the file and put the information in a HashSet and then
    /// add it to a List
    /// </summary>
    public class ReadFile
    {
        /// String with the game object
        public string[] gamesFile;

        /// <summary>
        /// HashSet with all the games
        /// </summary>
        public HashSet<Game> allGames;

        /// <summary>
        /// List with the games
        /// </summary>
        public List<Game> searchList = new List<Game>();

        /// <summary>
        /// Constructor that reads the file, put them in the HashSet and then
        /// copied them to a List
        /// Initializes a new instance of the <see cref="T:LP2_Projeto1.ReadFile"/> class.
        /// </summary>
        /// <param name="path">Path.</param>
        public ReadFile(string path)
        {
            gamesFile = File.ReadAllLines(path);
            allGames = HashSetAllGames(gamesFile);
            searchList = allGames.ToList<Game>();
        }
        /// <summary>
        /// method that creates a Hashset list and recives a game object
        /// </summary>
        /// <returns>The set all games.</returns>
        /// <param name="game">Game.</param>
        public HashSet<Game> HashSetAllGames(string[] game)
        {
            ///Temporary hashset to manage game objects
            HashSet<Game> hashTemp = new HashSet<Game>();

            ///Go throught a game object
            for (int i = 1; i < game.Length; i++)
            {
                ///Split the fields by comas
                Game g = new Game(game[i].Split(','));

                ///Add the game object to the temporary hashset
                if (!hashTemp.Contains(g))
                {
                    hashTemp.Add(g);
                }
            }
            ///Return the temporary hashset
            return hashTemp;
        }




    }
}