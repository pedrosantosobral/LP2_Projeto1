using System;
using System.Collections.Generic;
using System.Linq;

namespace LP2_Projeto1
{
    /// <summary>
    /// Class that contains all the filters used to make the searches
    /// </summary>
    public class Filters
    {
        /// <summary>
        /// The filtered list
        /// </summary>
        public List<Game> filteredList;

        /// <summary>
        /// List with all the games
        /// </summary>
        public List<Game> searchList;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:LP2_Projeto1.Filters"/> class.
        /// </summary>
        /// <param name="searchList">Search list.</param>
        public Filters(List<Game> searchList)
        {
            this.searchList = searchList;
            filteredList = searchList;
        }

        /// <summary>
        /// Method to apply the filters to the advanced search.
        /// </summary>
        /// <param name="boolFilters">Bool filters.</param>
        /// <param name="intFilters">Int filters.</param>
        /// <param name="name">Name.</param>
        /// <param name="dt">Dt.</param>
        public void ApplyFilters(bool[] boolFilters, int[] intFilters,
                                 string name, DateTime dt)
        {
            ///Filter for name
            if (name != null)
            {
                filteredList = filteredList.Where(game =>
                game.name.ToLower().Contains(name.ToLower())).ToList();
            }

            ///Filter for date
            if (dt != DateTime.MinValue)
            {
                filteredList = filteredList.Where(game => game.release_date >
                dt).ToList();
            }

            ///Filter for required age
            if (intFilters[0] != 0)
            {
                filteredList = filteredList.Where(game => game.required_age >
                                                  intFilters[0]).ToList();
            }

            ///Filter for metacritic
            if (intFilters[1] != 0)
            {
                filteredList = filteredList.Where(game => game.metacritic >
                                                  intFilters[1]).ToList();
            }

            ///Filter for recommendation count
            if (intFilters[2] != 0)
            {
                filteredList = filteredList.Where(game => game.recommendation_count >
                                                  intFilters[2]).ToList();
            }

            ///Filter for controller support
            if (boolFilters[0] != false)
            {
                filteredList = filteredList.Where(game => game.controller_support
                                                  == true).ToList();
            }

            ///Filter for windows platform
            if (boolFilters[1] != false)
            {
                filteredList = filteredList.Where(game => game.platform_windows
                                                  == true).ToList();
            }

            ///Filter for linux platform
            if (boolFilters[2] != false)
            {
                filteredList = filteredList.Where(game => game.platform_linux
                                                  == true).ToList();
            }

            ///Filter for mac platform
            if (boolFilters[3] != false)
            {
                filteredList = filteredList.Where(game => game.platform_mac
                                                  == true).ToList();
            }

            ///Filter for singleplayer category
            if (boolFilters[4] != false)
            {
                filteredList = filteredList.Where(game => game.category_singleplayer
                                                  == true).ToList();
            }

            ///Filter for multiplayer category
            if (boolFilters[5] != false)
            {
                filteredList = filteredList.Where(game => game.category_multiplayer
                                                  == true).ToList();
            }

            ///Filter for cooperation category
            if (boolFilters[6] != false)
            {
                filteredList = filteredList.Where(game => game.category_coop
                                                  == true).ToList();
            }

            ///Filter for level editor
            if (boolFilters[7] != false)
            {
                filteredList = filteredList.Where(game => game.category_include_level_editor
                                                  == true).ToList();
            }

            ///Filter for vr support
            if (boolFilters[8] != false)
            {
                filteredList = filteredList.Where(game => game.category_vr_support
                                                  == true).ToList();
            }

        }

        /// <summary>
        /// Method to apply the sort to the advanced search.
        /// </summary>
        /// <param name="order">Order.</param>
        public void ApplySort(string order)
        {
            switch (order)
            {
                case "ID":
                    filteredList.Sort((x, y) => x.id.CompareTo(y.id));
                    Console.Clear();
                    break;
                case "NAME":
                    filteredList.Sort((x, y) => x.name.CompareTo(y.name));
                    Console.Clear();
                    break;
                case "RELEASE DATE":
                    filteredList.Sort((x, y) => y.release_date.CompareTo(x.release_date));
                    Console.Clear();
                    break;
                case "METACRITIC":
                    filteredList.Sort((x, y) => y.metacritic.CompareTo(x.metacritic));
                    Console.Clear();
                    break;
                case "NUMBER OF DLCs":
                    filteredList.Sort((x, y) => y.dlc_counts.CompareTo(x.dlc_counts));
                    Console.Clear();
                    break;
                case "RECOMMENDATIONS":
                    filteredList.Sort((x, y) => y.recommendation_count.CompareTo(x.recommendation_count));
                    Console.Clear();
                    break;
                case "NUMBER OS OWNERS":
                    filteredList.Sort((x, y) => y.owners.CompareTo(x.owners));
                    Console.Clear();
                    break;
                case "NUMBER OF PLAYERS":
                    filteredList.Sort((x, y) => y.number_of_players.CompareTo(x.number_of_players));
                    Console.Clear();
                    break;
                case "NUMBER OF ACHIEVEMENTS":
                    filteredList.Sort((x, y) => y.achievment_count.CompareTo(x.achievment_count));
                    Console.Clear();
                    break;
            }

        }

    }
}