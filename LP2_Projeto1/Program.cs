using System;
using System.IO;

namespace LPprojeto1MinhaCopia
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFile file = new ReadFile("/Users/pedrosantos/Desktop/LPprojeto1MinhaCopia/LPprojeto1MinhaCopia/games.csv");
            Render render = new Render(file.searchList);
            Filters filter = new Filters(render.selections, file.searchList);
            render.ShowMainMenu();

        }
    }
}