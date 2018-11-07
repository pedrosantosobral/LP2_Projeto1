using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
namespace LP2_Projeto1
{
    public class Game
    {
        private int id;
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

        public Game(string s)
        {
            string[] str = s.Split(",");

            id = Convert.ToInt32(str[0]);
            name = str[1];
            release_date = Convert.ToDateTime(str[2]);
            required_age = Convert.ToInt32(str[3]);
            dlc_counts = Convert.ToInt32(str[4]);
            metacritic = Convert.ToInt32(str[5]);
            movie_count = Convert.ToInt32(str[6]);
            recommendation_count = Convert.ToInt32(str[7]);
            screenshot_count = Convert.ToInt32(str[8]);
            owners = Convert.ToInt32(str[9]);
            number_of_players = Convert.ToInt32(str[10]);
            achievment_count = Convert.ToInt32(str[11]);
            controller_support = Convert.ToBoolean(str[12]);
            platform_windows = Convert.ToBoolean(str[13]);
            platform_linux = Convert.ToBoolean(str[14]);
            platform_mac = Convert.ToBoolean(str[15]);
            category_singleplayer = Convert.ToBoolean(str[16]);
            category_multiplayer = Convert.ToBoolean(str[17]);
            category_coop = Convert.ToBoolean(str[18]);
            category_include_level_editor = Convert.ToBoolean(str[19]);
            category_vr_support = Convert.ToBoolean(str[20]);
            support_url = new Uri(str[21]);
            about_text = str[22];
            header_image = new Uri(str[23]);
            website = new Uri(str[24]);

        }
    }
}
