using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
namespace LPprojeto1MinhaCopia
{
    public class Game
    {
        internal readonly int id;
        private string name;
        private DateTime release_date;
        private int required_age;
        private int dlc_counts;
        private int metacritic;
        private int movie_count;
        private int recommendation_count;
        private int screenshot_count;
        private int owners;
        private int number_of_players;
        private int achievment_count;
        private bool controller_support;
        private bool platform_windows;
        private bool platform_linux;
        private bool platform_mac;
        private bool category_singleplayer;
        private bool category_multiplayer;
        private bool category_coop;
        private bool category_include_level_editor;
        private bool category_vr_support;
        private Uri support_url;
        private string about_text;
        private Uri header_image;
        private Uri website;



        public Game(string[] str)
        {             id = Convert.ToInt32(str[0]);             name = str[1];             release_date = CheckDateTime(str[2]);             required_age = Convert.ToInt32(str[3]);             dlc_counts = Convert.ToInt32(str[4]);             metacritic = Convert.ToInt32(str[5]);             movie_count = Convert.ToInt32(str[6]);             recommendation_count = Convert.ToInt32(str[7]);             screenshot_count = Convert.ToInt32(str[8]);             owners = Convert.ToInt32(str[9]);             number_of_players = Convert.ToInt32(str[10]);             achievment_count = Convert.ToInt32(str[11]);             controller_support = Convert.ToBoolean(str[12]);             platform_windows = Convert.ToBoolean(str[13]);             platform_linux = Convert.ToBoolean(str[14]);             platform_mac = Convert.ToBoolean(str[15]);             category_singleplayer = Convert.ToBoolean(str[16]);             category_multiplayer = Convert.ToBoolean(str[17]);             category_coop = Convert.ToBoolean(str[18]);             category_include_level_editor = Convert.ToBoolean(str[19]);             category_vr_support = Convert.ToBoolean(str[20]);             support_url = CheckUrl(str[21]);             about_text = str[22];             header_image = CheckUrl(str[23]);             website = CheckUrl(str[24]);
        }

        public void PrintAllValues()
        {
            Console.WriteLine("id: " + id);
            Console.WriteLine("name: " + name);
            Console.WriteLine("release date: " + release_date.ToString());
            Console.WriteLine("minimum age:" + required_age);
            Console.WriteLine("DLCs:" + dlc_counts);
            Console.WriteLine("metacritic: " + metacritic);
            Console.WriteLine("movies: " + movie_count);
            Console.WriteLine("recomendation: " + recommendation_count);
            Console.WriteLine("screenshots :" + screenshot_count);
            Console.WriteLine("purchases: " + owners);
            Console.WriteLine("players: " + number_of_players);
            Console.WriteLine("achievements: " + achievment_count);
            Console.WriteLine("have controls: " + controller_support);
            Console.WriteLine("windows?: " + platform_windows);
            Console.WriteLine("linux?: " + platform_linux);
            Console.WriteLine("macOS?: " + platform_mac);
            Console.WriteLine("sigle player?: " + category_singleplayer);
            Console.WriteLine("multiplayer?: " + category_multiplayer);
            Console.WriteLine("coop?: " + category_coop);
            Console.WriteLine("level editor?: " + category_include_level_editor);
            Console.WriteLine("vr support?: " + category_vr_support);
            Console.WriteLine("site: " + PrintUrl(support_url));
            Console.WriteLine("about: " + about_text);
            Console.WriteLine("image url: " + PrintUrl(header_image));
            Console.WriteLine("prints url: " + PrintUrl(website));
        }


        public Uri CheckUrl(string str)
        {
            Uri tempUrl;
            if (str.ToLower() == "none")
            {
                tempUrl = null;
                return tempUrl;
            }
            else
            {

                bool isUrl = Uri.TryCreate(str, UriKind.RelativeOrAbsolute, out tempUrl);
                if (isUrl == false)
                {
                    tempUrl = null;
                }
                return tempUrl;
            }

        }

        public DateTime CheckDateTime(string str)
        {
            DateTime tempDateTime;
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
    }
}

