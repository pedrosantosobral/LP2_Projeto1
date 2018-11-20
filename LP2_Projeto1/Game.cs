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

        public Game(int id, string name, DateTime release_date, int required_age,
                    int dlc_counts, int metacritic, int movie_count, 
                    int recommendation_count, int screenshot_count, int owners, 
                    int number_of_players, int achievment_count, 
                    bool controller_support, bool platform_windows, 
                    bool platform_linux, bool platform_mac, 
                    bool category_singleplayer,bool category_multiplayer,
                   bool category_coop, bool category_include_level_editor, 
                    bool category_vr_support, Uri support_url, string about_text,
                    Uri header_image, Uri website)
        {
            this.id = id;
            this.name = name;
            this.release_date = release_date;
            this.required_age = required_age;
            this.dlc_counts = dlc_counts;
            this.metacritic = metacritic;
            this.movie_count = movie_count;
            this.recommendation_count = recommendation_count;
            this.screenshot_count = screenshot_count;
            this.owners = owners;
            this.number_of_players = number_of_players;
            this.achievment_count = achievment_count;
            this.controller_support = controller_support;
            this.platform_windows = platform_windows;
            this.platform_mac = platform_mac;
            this.platform_linux = platform_linux;
            this.category_singleplayer = category_singleplayer;
            this.category_multiplayer = category_multiplayer;
            this.category_coop = category_coop;
            this.category_include_level_editor = category_include_level_editor;
            this.category_vr_support = category_vr_support;
            this.support_url = support_url;
            this.about_text = about_text;
            this.header_image = header_image;
            this.website = website;

        }
    }
}
