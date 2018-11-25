using System;
using System.IO;

namespace LPprojeto1MinhaCopia
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFile file = new ReadFile("/Users/joanamarques/Desktop/LP2_Projeto1/LP2_Projeto1/games.csv");
            Render render = new Render(file.searchList);
            render.ShowMainMenu();

        }
    }
}