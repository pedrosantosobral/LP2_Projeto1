using System;
using System.Net;

namespace LP2_Projeto1
{
    /// <summary>
    /// Class Game that contais all the variables to be used in other classes
    /// </summary>
    public class Game
    {
        internal readonly int id;
        internal readonly string name;
        internal readonly DateTime release_date;
        internal readonly int required_age;
        internal readonly int dlc_counts;
        internal readonly int metacritic;
        internal readonly int movie_count;
        internal readonly int recommendation_count;
        internal readonly int screenshot_count;
        internal readonly int owners;
        internal readonly int number_of_players;
        internal readonly int achievment_count;
        internal readonly bool controller_support;
        internal readonly bool platform_windows;
        internal readonly bool platform_linux;
        internal readonly bool platform_mac;
        internal readonly bool category_singleplayer;
        internal readonly bool category_multiplayer;
        internal readonly bool category_coop;
        internal readonly bool category_include_level_editor;
        internal readonly bool category_vr_support;
        internal readonly Uri support_url;
        internal readonly string about_text;
        internal readonly Uri header_image;
        internal readonly Uri website;


        /// <summary>
        /// Constructor that converts all the values
        /// Initializes a new instance of the <see cref="T:LP2_Projeto1.Game"/> class.
        /// </summary>
        /// <param name="str">String.</param>
        public Game(string[] str)
        {             id = Convert.ToInt32(str[0]);             name = str[1];             release_date = CheckDateTime(str[2]);             required_age = Convert.ToInt32(str[3]);             dlc_counts = Convert.ToInt32(str[4]);             metacritic = Convert.ToInt32(str[5]);             movie_count = Convert.ToInt32(str[6]);             recommendation_count = Convert.ToInt32(str[7]);             screenshot_count = Convert.ToInt32(str[8]);             owners = Convert.ToInt32(str[9]);             number_of_players = Convert.ToInt32(str[10]);             achievment_count = Convert.ToInt32(str[11]);             controller_support = Convert.ToBoolean(str[12]);             platform_windows = Convert.ToBoolean(str[13]);             platform_linux = Convert.ToBoolean(str[14]);             platform_mac = Convert.ToBoolean(str[15]);             category_singleplayer = Convert.ToBoolean(str[16]);             category_multiplayer = Convert.ToBoolean(str[17]);             category_coop = Convert.ToBoolean(str[18]);             category_include_level_editor = Convert.ToBoolean(str[19]);             category_vr_support = Convert.ToBoolean(str[20]);             support_url = CheckUrl(str[21]);             about_text = str[22];             header_image = CheckUrl(str[23]);             website = CheckUrl(str[24]);
        }

        /// <summary>
        /// Method to print all the game values from the file
        /// </summary>
        public void PrintAllValues()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("NAME: " + name);
            Console.WriteLine("RELEASE DATE: " + release_date.ToString());
            Console.WriteLine("MINIMUM:" + required_age);
            Console.WriteLine("DLCs:" + dlc_counts);
            Console.WriteLine("METACRITIC: " + metacritic);
            Console.WriteLine("MOVIES: " + movie_count);
            Console.WriteLine("RECOMENDATIONS: " + recommendation_count);
            Console.WriteLine("SCRENSHOTS :" + screenshot_count);
            Console.WriteLine("PURCHASES: " + owners);
            Console.WriteLine("NUMBER OF PLAYERS: " + number_of_players);
            Console.WriteLine("ACHIEVEMENTS: " + achievment_count);
            Console.WriteLine("CONTROLER SUPORT: " + controller_support);
            Console.WriteLine("WINDOWS PLATFORM?: " + platform_windows);
            Console.WriteLine("LINUX PLATFORM: " + platform_linux);
            Console.WriteLine("WINDOWS PLATFORM: " + platform_mac);
            Console.WriteLine("SINGLEPLAYER: " + category_singleplayer);
            Console.WriteLine("MULTIPLAYER: " + category_multiplayer);
            Console.WriteLine("COOP?: " + category_coop);
            Console.WriteLine("LEVEL EDITOR: " + category_include_level_editor);
            Console.WriteLine("VR SUPPORT: " + category_vr_support);
            Console.WriteLine("SITE: " + PrintUrl(support_url));
            Console.WriteLine("ABOUT: " + about_text);
            Console.WriteLine("IMAGE URL: " + PrintUrl(header_image));
            Console.WriteLine("PRINTS URL: " + PrintUrl(website));
        }

        /// <summary>
        /// Verify if the file has url or the name 'none'
        /// </summary>
        /// <returns>The URL.</returns>
        /// <param name="str">String.</param>
        public Uri CheckUrl(string str)
        {
            Uri tempUrl;
            /// If 'none', keeps the url null
            if (str.ToLower() == "none")
            {
                tempUrl = null;
                return tempUrl;
            }
            else
            {
                ///Tries to create the url
                bool isUrl = Uri.TryCreate(str, UriKind.RelativeOrAbsolute, out tempUrl);
                if (isUrl == false)
                {
                    tempUrl = null;
                }
                return tempUrl;
            }

        }

        /// <summary>
        /// verify of the file has date or a space
        /// </summary>
        /// <returns>The date time.</returns>
        /// <param name="str">String.</param>
        public DateTime CheckDateTime(string str)
        {
            DateTime tempDateTime;
            ///If there is a space, keeps the default value
            if (str.ToLower() == " ")
            {
                tempDateTime = default(DateTime);
                return tempDateTime;
            }
            else
            {
                bool isDateTime = DateTime.TryParse(str, out tempDateTime);
                if (isDateTime == false)
                {
                    tempDateTime = default(DateTime);
                }
                return tempDateTime;
            }

        }

        /// <summary>
        ///  Print the url
        /// </summary>
        /// <returns>The URL.</returns>
        /// <param name="url">URL.</param>
        public string PrintUrl(Uri url)
        {
            string s;
            if (url == null)
            {
                s = "None.";
            }
            else
            {
                s = url.ToString();
            }

            return s;
        }

        /// <summary>
        /// Method to download the game image
        /// </summary>
        public void DownloadImage()
        {
            using(WebClient client = new WebClient())
            {
                if (header_image != null)
                    client.DownloadFile(header_image, "image.jpg");
            }
            /// Open image after it downloads (ps: i couldn't make it work on mac
            /// but i know that it works on windows)
           // Process.Start("image.jpg");
        }
    }
}

