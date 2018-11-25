using System;
using System.IO;

namespace LPprojeto1MinhaCopia
{
    class Program
    {
        static void Main(string[] args)
        {
            Render render = new Render();
            render.ShowMainMenu();
         
            ReadFile file = new ReadFile("/Users/joanamarques/Desktop/LP2_Projeto1/LP2_Projeto1/games.csv");
            file.searchList[0].PrintAllValues();
        }
    }
}