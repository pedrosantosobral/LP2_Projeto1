using System;
namespace LPprojeto1MinhaCopia
{
    public class Render
    {
        public Render()
        {

        }

        public bool ShowMainMenu()
        {
            bool returnvalue = false;

            Console.WriteLine("Pick a option");
            Console.WriteLine("1 -> PICK ORDER");
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
            Console.WriteLine("0 -> BACK");

            int choice2 = Convert.ToInt32(Console.ReadLine());

            switch (choice2)
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
                    ShowFilterMenu();
                    break;
                case 4:
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 5:
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 6:
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 7:
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 8:
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 9:
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 0:
                    Console.Clear();
                    ShowMainMenu();
                    break;
            }


        }

        public void ShowFilterMenu() 
        {
            Console.WriteLine("Pick one filter: ");
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
            Console.WriteLine("14 -> VR READY");
            Console.WriteLine(" ");
            Console.WriteLine("0  -> BACK");

            int choice3 = Convert.ToInt32(Console.ReadLine());

            switch (choice3)
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
                    ShowFilterMenu();
                    break;
                case 4:
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 5:
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 6:
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 7:
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 8:
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 9:
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 10:
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 11:
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 12:
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 13:
                    Console.Clear();
                    ShowFilterMenu();
                    break;
                case 14:
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
