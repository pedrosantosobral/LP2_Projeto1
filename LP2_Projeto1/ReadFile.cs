using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace LPprojeto1MinhaCopia
{
    public class ReadFile
    {
        //string with the game object
        public string[] gamesFile;
        public HashSet<Game> allGames;
        public List<Game> searchList = new List<Game>();

        public ReadFile(string path)
        {
            gamesFile = File.ReadAllLines(path);
            allGames = HashSetAllGames(gamesFile);
            searchList = allGames.ToList<Game>();
        }

        //method that creates a Hashset list and recives a game object
        public HashSet<Game> HashSetAllGames(string[] game)
        {
            //temporary hashset to manage game objects
            HashSet<Game> hashTemp = new HashSet<Game>();

            //go throught a game object
            for (int i = 1; i < game.Length; i++)
            {
                //split the fields by comas
                Game g = new Game(game[i].Split(','));

                //add the game object to the temporary hashset
                if (!hashTemp.Contains(g))
                {
                    hashTemp.Add(g);
                }
            }
            //return the temporary hashset
            return hashTemp;
        }




    }
}