using System;
using System.IO;

namespace LPprojeto1MinhaCopia
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFile file = new ReadFile(args[0]);
            Render render = new Render(file.searchList);
            render.ShowMainMenu();

        }
    }
}