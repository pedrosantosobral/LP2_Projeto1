using System;
using System.Collections.Generic;
namespace LPprojeto1MinhaCopia
{
    public class Render
    {
        List<Game> searchList;
        Filters filters;

        public Render(List<Game> searchList)
        {
            this.searchList = searchList;
            filters = new Filters(searchList);
        }

        public string[] selections = new string[14];

        public void ShowMainMenu()
        {
            Console.WriteLine("WELCOME TO CHINA STEAM DATABASE :D");
            Console.WriteLine("PICK AN OPTION:");
            Console.WriteLine("1 -> SHOW A GAME INFO");
            Console.WriteLine("2 -> MAKE ADVANCED SEARCH");
            Console.WriteLine("3 -> EXIT");

            int choice0 = Convert.ToInt32(Console.ReadLine());

            switch(choice0)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("INSERT DESIRED GAME ID TO SHOW:");
                    string temp = Console.ReadLine();
                        if (int.TryParse(temp, out int id))
                        {
                            if ((id % 10) == 0)
                            {
                                foreach (Game g in searchList)
                                {
                                    if (g.id == id)
                                    {
                                        g.PrintAllValues();
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("This game does not exist");
                                    }
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("This game does not exist");
                            }
                        }
                    break;
                case 2:
                    Console.Clear();
                    ShowSearchMenu();
                    break;
                case 3:
                    System.Environment.Exit(0);
                    break;
            }

        }

        public bool ShowSearchMenu()
        {
            bool returnvalue = false;

            Console.WriteLine("PICK AN OPTION:");
            Console.WriteLine("1 -> PICK ORDERING TYPE | CURRENT IS " + selections[14]);
            Console.WriteLine("2 -> PICK FILTERS");
            Console.WriteLine("3 -> START SEARCH");
            Console.WriteLine("");
            Console.WriteLine("0 -> BACK");

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
                    ShowMainMenu();
                    break;
            }

            return returnvalue;
        }

        public void ShowOrderMenu()
        {
            Console.WriteLine("CURRENT ORDERING TYPE: " + selections[14]);
            Console.WriteLine("");
            Console.WriteLine("PICK ONE ORDER TYPE:");
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
                    ShowSearchMenu();
                    break;
                case 2:
                    selections[14] = "NAME";
                    Console.Clear();
                    ShowSearchMenu();
                    break;
                case 3:
                    selections[14] = "LAUNCH DATE";
                    Console.Clear();
                    ShowSearchMenu();
                    break;
                case 4:
                    selections[14] = "METACRITIC";
                    Console.Clear();
                    ShowSearchMenu();
                    break;
                case 5:
                    selections[14] = "NUMBER OF DLCs";
                    Console.Clear();
                    ShowSearchMenu();
                    break;
                case 6:
                    selections[14] = "RECOMENDATIONS";
                    Console.Clear();
                    ShowSearchMenu();
                    break;
                case 7:
                    selections[14] = "NUMBER OF OWNERS";
                    Console.Clear();
                    ShowSearchMenu();
                    break;
                case 8:
                    selections[14] = "NUMBER OF PLAYERS";
                    Console.Clear();
                    ShowSearchMenu();
                    break;
                case 9:
                    selections[14] = "NUMBER OF ACHIEVEMENTS";
                    Console.Clear();
                    ShowSearchMenu();
                    break;
                case 0:
                    selections[14] = "NONE";
                    Console.Clear();
                    ShowSearchMenu();
                    break;
            }

        }

        public void ShowFilterMenu() 
        {
            Console.WriteLine("Filters added: NAME; {0} | DATE: {1} | AGE: {2} |" +
                              " METACRITIC: {3} | RECOMENDATIONS: {4} |" +
                              " CONTROLER SUPPORT {5} | FOR WINDOWS: {6} |" +
                              " FOR LINUX: {7} | FOR MAC: " +
                              "{8} | SINGLEPLAYER: {9} | MULTIPLAYER: {10} | " +
                              "COOPERATIVA {11} | LEVEL EDITOR: {12} | VR SUPORT: {13} ", selections[0], selections[1],
                              selections[2], selections[3], selections[4], selections[5],
                              selections[6], selections[7], selections[8], selections[9],
                              selections[10], selections[11], selections[12], selections[13]);
            Console.WriteLine("ADD FILTERS: ");
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
                    Console.Clear();
                    Console.WriteLine("INSERT NAME");
                    selections[0] = Console.ReadLine();
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("INSERT DATE(DAY/MONTH/YEAR)");
                    selections[1] = Console.ReadLine();
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("INSERT AGE");
                    selections[2] = Console.ReadLine();
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("INSERT DATE(DAY/MONTH/YEAR)");
                    selections[3] = Console.ReadLine();
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("INSERT DATE(DAY/MONTH/YEAR)");
                    selections[4] = Console.ReadLine();
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 6:
                    selections[5] = "TRUE";
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 7:
                    selections[6] = "TRUE";
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 8:
                    selections[7] = "TRUE";
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 9:
                    selections[8] = "TRUE";
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 10:
                    selections[9] = "TRUE";
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 11:
                    selections[10] = "TRUE";
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 12:
                    selections[11] = "TRUE";
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 13:
                    selections[12] = "TRUE";
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 14:
                    selections[13] = "TRUE";
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 15:
                    for (int i = 0; i < selections.Length; i++)
                    {
                        selections[i] = null;
                    }
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 0:
                    Console.Clear();
                    ShowSearchMenu();
                    break;
            }

            filters.ApplyFilters(selections);

        }

    }

}
