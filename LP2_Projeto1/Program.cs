using System;

namespace LP2_Projeto1
{
    class Program
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        static void Main(string[] args)
        {
            /// Instance for the ReadFile class
            ReadFile file = new ReadFile(args[0]);

            /// Instance for the Render class
            Render render = new Render(file.searchList);

            /// Calls the main menu from the Render class
            render.ShowMainMenu();

        }
    }
}