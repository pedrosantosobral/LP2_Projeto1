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
        string name;
        DateTime dt;
        int[] intFilters = new int[3];
        bool[] boolFilters = new bool[9];
        public string order;

        public void ShowMainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("WELCOME TO CHINA STEAM DATABASE :D");
                Console.WriteLine("PICK AN OPTION:");
                Console.WriteLine("1 -> SHOW A GAME INFO");
                Console.WriteLine("2 -> MAKE ADVANCED SEARCH");
                Console.WriteLine("3 -> EXIT");

                string choice0 = Console.ReadLine();

                switch (choice0)
                {
                    case "1":
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
                                        g.DownloadImage();
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("This game does not exist");
                            }
                            Console.ReadKey();
                        }
                        break;
                    case "2":
                        Console.Clear();
                        ShowSearchMenu();
                        break;
                    case "3":
                        System.Environment.Exit(0);
                        break;
                }
            }

        }

        public void ShowSearchMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("PICK AN OPTION:");
                Console.WriteLine("1 -> PICK ORDERING TYPE | CURRENT IS " + order);
                Console.WriteLine("2 -> PICK FILTERS");
                Console.WriteLine("3 -> START SEARCH");
                Console.WriteLine("");
                Console.WriteLine("0 -> BACK");

                string choice1 = Console.ReadLine();

                switch (choice1)
                {
                    case "1":
                        Console.Clear();
                        ShowOrderMenu();
                        break;
                    case "2":
                        Console.Clear();
                        ShowFilterMenu();
                        break;
                    case "3":
                        Console.Clear();
                        ShowSearchResults();
                        break;
                }

                if (choice1 == "0") break;
            }

        }

        public void ShowOrderMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("CURRENT ORDERING TYPE: " + order);
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
                Console.WriteLine("0 -> GO BACK");

                string choice2 = Console.ReadLine();

                switch (choice2)
                {
                    case "1":
                        order = "ID";
                        filters.ApplySort(order);
                        Console.Clear();
                        break;
                    case "2":
                        order = "NAME";
                        filters.ApplySort(order);
                        Console.Clear();
                        break;
                    case "3":
                        order = "RELEASE DATE";
                        filters.ApplySort(order);
                        Console.Clear();
                        break;
                    case "4":
                        order = "METACRITIC";
                        filters.ApplySort(order);
                        Console.Clear();
                        break;
                    case "5":
                        order = "NUMBER OF DLCs";
                        filters.ApplySort(order);
                        Console.Clear();
                        break;
                    case "6":
                        order = "RECOMENDATIONS";
                        filters.ApplySort(order);
                        Console.Clear();
                        break;
                    case "7":
                        order = "NUMBER OF OWNERS";
                        filters.ApplySort(order);
                        Console.Clear();
                        break;
                    case "8":
                        order = "NUMBER OF PLAYERS";
                        filters.ApplySort(order);
                        Console.Clear();
                        break;
                    case "9":
                        order = "NUMBER OF ACHIEVEMENTS";
                        filters.ApplySort(order);
                        Console.Clear();
                        break;
                }

                if (choice2 == "0") break;
            }

        }

        public void ShowFilterMenu() 
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Filters added: NAME: {0} | DATE: {1} | AGE: {2} |" +
                                  " METACRITIC: {3} | RECOMENDATIONS: {4} |" +
                                  " CONTROLER SUPPORT {5} | FOR WINDOWS: {6} |" +
                                  " FOR LINUX: {7} | FOR MAC: " +
                                  "{8} | SINGLEPLAYER: {9} | MULTIPLAYER: {10} | " +
                                  "COOPERATIVA {11} | LEVEL EDITOR: {12} | VR SUPORT: {13} ", name, dt,
                                  intFilters[0], intFilters[1], intFilters[2], boolFilters[0],
                                  boolFilters[1], boolFilters[2], boolFilters[3], boolFilters[4],
                                  boolFilters[5], boolFilters[6], boolFilters[7], boolFilters[8]);
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
                Console.WriteLine(" ");
                Console.WriteLine("0  -> BACK");

                string choice3 = Console.ReadLine();
                string input;

                switch (choice3)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("INSERT NAME");
                        name = Console.ReadLine();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("INSERT DATE(DAY/MONTH/YEAR)");
                        input = Console.ReadLine();
                        DateTime.TryParse(input, out DateTime dt);
                        this.dt = dt;
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("INSERT AGE");
                        input = Console.ReadLine();
                        int.TryParse(input, out int req_age);
                        intFilters[0] = req_age;
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("INSERT METACRITIC");
                        input = Console.ReadLine();
                        int.TryParse(input, out int meta);
                        intFilters[1] = meta;
                        Console.Clear();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("INSERT RECOMENDATIONS");
                        input = Console.ReadLine();
                        int.TryParse(input, out int reco);
                        intFilters[2] = reco;
                        Console.Clear();
                        break;
                    case "6":
                        boolFilters[0] = true;
                        Console.Clear();
                        break;
                    case "7":
                        boolFilters[1] = true;
                        Console.Clear();
                        break;
                    case "8":
                        boolFilters[2] = true;
                        Console.Clear();
                        break;
                    case "9":
                        boolFilters[3] = true;
                        Console.Clear();
                        break;
                    case "10":
                        boolFilters[4] = true;
                        Console.Clear();
                        break;
                    case "11":
                        boolFilters[5] = true;
                        Console.Clear();
                        break;
                    case "12":
                        boolFilters[6] = true;
                        Console.Clear();
                        break;
                    case "13":
                        boolFilters[7] = true;
                        Console.Clear();
                        break;
                    case "14":
                        boolFilters[8] = true;
                        Console.Clear();
                        break;
                }

                if (choice3 == "0") break;
            }
            filters.ApplyFilters(boolFilters, intFilters, name, dt);
        }

        public void ShowSearchResults()
        {
            int index = 0;
            int count = 10;
            foreach (Game g in filters.filteredList)
            {
                index++;
                Console.WriteLine($"ID: {g.id}");
                Console.WriteLine($"NAME: {g.name}");
                Console.WriteLine($"RELEASE DATE: {g.release_date}");
                Console.WriteLine($"DLC COUNT: {g.dlc_counts}");
                Console.WriteLine($"METACRITIC: {g.metacritic}");
                Console.WriteLine($"RECOMMENDATION COUNT: {g.recommendation_count}");
                Console.WriteLine($"PEOPLE THET OWN THE GAME: {g.owners}");
                Console.WriteLine($"NUMBER OF PLAYERS: {g.number_of_players}");
                Console.WriteLine($"ACHIEVEMENTE COUNT: {g.achievment_count}");
                Console.WriteLine();

                if(count - index == 0 || filters.filteredList.Count - index == 0)
                {
                    count += 10;
                    Console.WriteLine("PRESS ANY KEY TO CONTINUE VIEWING THE VALUES.");
                    Console.ReadKey();
                    Console.Clear();
                }

                filters.filteredList = filters.searchList;
            }
        }

    }

}
