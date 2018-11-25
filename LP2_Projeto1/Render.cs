using System;
using System.Collections.Generic;
namespace LPprojeto1MinhaCopia
{
    public class Render
    {
        public string[] selections = new string[15]{ "NONE", "NONE", "NONE", 
            "NONE", "NONE", "NONE", "NONE", "NONE", "NONE", "NONE", "NONE", 
            "NONE", "NONE", "NONE", "NONE"};

        public bool ShowMainMenu()
        {
            bool returnvalue = false;

            Console.WriteLine("Pick a option");
            Console.WriteLine("1 -> PICK ORDERING TYPE | CURRENT IS " + selections[14]);
            Console.WriteLine("2 -> PICK FILTERS");
            Console.WriteLine("3 -> START SEARCH");
            Console.WriteLine("");
            Console.WriteLine("0 -> QUIT");

            int choice1 = Convert.ToInt32(Console.ReadLine());

            switch(choice1)
            {
                case 1:
                    Console.Clear();
                    ShowOrderMenu();
                    break;
                case 2:
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 3:
                    Console.Clear();
                    returnvalue = true;
                    break;
                case 0:
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
            }

            return returnvalue;
        }

        public void ShowOrderMenu()
        {
            Console.WriteLine("CURRENT ORDERING TYPE: " + selections[14]);
            Console.WriteLine("");
            Console.WriteLine("Pick one order type:");
            Console.WriteLine("1 -> ID");
            Console.WriteLine("2 -> NAME");
            Console.WriteLine("3 -> LAUNCH DATE");
            Console.WriteLine("4 -> METACRITIC");
            Console.WriteLine("5 -> NUMBER OF DLCs");
            Console.WriteLine("6 -> RECOMENDATIONS");
            Console.WriteLine("7 -> NUMBER OF OWNERS");
            Console.WriteLine("8 -> NUMBER OF PLAYERS");
            Console.WriteLine("9 -> NUMBER OF ACHIEVEMENTS");
            Console.WriteLine(" ");
            Console.WriteLine("0 -> CLEAR ORDERING TYPE AND GO BACK");

            int choice2 = Convert.ToInt32(Console.ReadLine());

            switch (choice2)
            {
                case 1:
                    selections[14] = "ID";
                    Console.Clear();
                    ShowMainMenu();
                    break;
                case 2:
                    selections[14] = "NAME";
                    Console.Clear();
                    ShowMainMenu();
                    break;
                case 3:
                    selections[14] = "LAUNCH DATE";
                    Console.Clear();
                    ShowMainMenu();
                    break;
                case 4:
                    selections[14] = "METACRITIC";
                    Console.Clear();
                    ShowMainMenu();
                    break;
                case 5:
                    selections[14] = "NUMBER OF DLCs";
                    Console.Clear();
                    ShowMainMenu();
                    break;
                case 6:
                    selections[14] = "RECOMENDATIONS";
                    Console.Clear();
                    ShowMainMenu();
                    break;
                case 7:
                    selections[14] = "NUMBER OF OWNERS";
                    Console.Clear();
                    ShowMainMenu();
                    break;
                case 8:
                    selections[14] = "NUMBER OF PLAYERS";
                    Console.Clear();
                    ShowMainMenu();
                    break;
                case 9:
                    selections[14] = "NUMBER OF ACHIEVEMENTS";
                    Console.Clear();
                    ShowMainMenu();
                    break;
                case 0:
                    selections[14] = "NONE";
                    Console.Clear();
                    ShowMainMenu();
                    break;
            }

        }

        public void ShowFilterMenu() 
        {
            Console.WriteLine("Filters added: {0} {1} {2} {3} {4} {5} {6} {7} " +
                              "{8} {9} {10} {11} {12} ", selections[0],selections[1],
                              selections[2], selections[3],selections[4],selections[5],
                              selections[6],selections[7],selections[8],selections[9],
                              selections[10],selections[11],selections[12],selections[13]);
            Console.WriteLine("Add filters: ");
            Console.WriteLine("1  -> NAME");
            Console.WriteLine("2  -> DATE");
            Console.WriteLine("3  -> AGE");
            Console.WriteLine("4  -> METACRITIC");
            Console.WriteLine("5  -> RECOMENDATIONS");
            Console.WriteLine("6  -> CONTROLLER SUPPORT");
            Console.WriteLine("7  -> FOR WINDOWS");
            Console.WriteLine("8  -> FOR LINUX");
            Console.WriteLine("9  -> FOR MAC");
            Console.WriteLine("10 -> SINGLEPLAYER");
            Console.WriteLine("11 -> MULTIPLAYER");
            Console.WriteLine("12 -> COOPERATIVE");
            Console.WriteLine("13 -> LEVEL EDITOR");
            Console.WriteLine("14 -> VR SUPPORT");
            Console.WriteLine("15 -> CLEAR FILTERS");
            Console.WriteLine(" ");
            Console.WriteLine("0  -> BACK");

            int choice3 = Convert.ToInt32(Console.ReadLine());

            switch (choice3)
            {
                case 1:
                    selections[0] = "NAME";
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 2:
                    selections[1] = "DATA";
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 3:
                    selections[2] = "AGE";
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 4:
                    selections[3] = "METACRITIC";
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 5:
                    selections[4] = "RECOMENDATIONS";
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 6:
                    selections[5] = "CONTROLLER SUPPORT";
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 7:
                    selections[6] = "FOR WINDOWS";
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 8:
                    selections[7] = "FOR LINUX";
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 9:
                    selections[8] = "FOR MAC :3";
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 10:
                    selections[9] = "SINGLEPLAYER";
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 11:
                    selections[10] = "MULTIPLAYER";
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 12:
                    selections[11] = "COOPERATIVE";
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 13:
                    selections[12] = "LEVEL EDITOR";
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 14:
                    selections[13] = "VR SUPPORT";
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 0:
                    Console.Clear();
                    ShowMainMenu();
                    break;
            }

        }


    }

}
