using System;
using System.Collections.Generic;
using System.Linq;
namespace LPprojeto1MinhaCopia
{
    public class Filters
    {
        public List<Game> filteredList;
        public List<Game> searchList;


        public Filters(List<Game> searchList)
        {
            this.searchList = searchList;
            filteredList = searchList;
        }

        public void ApplyFilters(bool[] boolFilters, int[] intFilters,
                                 string name, DateTime dt)
        {
            if (name != null)
            {
                filteredList = filteredList.Where(game =>
                game.name.ToLower().Contains(name.ToLower())).ToList();
            }

            if (dt != DateTime.MinValue)
            {
                filteredList = filteredList.Where(game => game.release_date >
                dt).ToList();
            }

            if (intFilters[0] != 0)
            {
                filteredList = filteredList.Where(game => game.required_age >
                                                  intFilters[0]).ToList();
            }


            if (intFilters[1] != 0)
            {
                filteredList = filteredList.Where(game => game.metacritic >
                                                  intFilters[1]).ToList();
            }


            if (intFilters[2] != 0)
            {
                filteredList = filteredList.Where(game => game.recommendation_count >
                                                  intFilters[2]).ToList();
            }

            if (boolFilters[0] != false)
            {
                filteredList = filteredList.Where(game => game.controller_support
                                                  == true).ToList();
            }

            if (boolFilters[1] != false)
            {
                filteredList = filteredList.Where(game => game.platform_windows
                                                  == true).ToList();
            }

            if (boolFilters[2] != false)
            {
                filteredList = filteredList.Where(game => game.platform_linux
                                                  == true).ToList();
            }

            if (boolFilters[3] != false)
            {
                filteredList = filteredList.Where(game => game.platform_mac
                                                  == true).ToList();
            }

            if (boolFilters[4] != false)
            {
                filteredList = filteredList.Where(game => game.category_singleplayer
                                                  == true).ToList();
            }

            if (boolFilters[5] != false)
            {
                filteredList = filteredList.Where(game => game.category_multiplayer
                                                  == true).ToList();
            }

            if (boolFilters[6] != false)
            {
                filteredList = filteredList.Where(game => game.category_coop
                                                  == true).ToList();
            }

            if (boolFilters[7] != false)
            {
                filteredList = filteredList.Where(game => game.category_include_level_editor
                                                  == true).ToList();
            }

            if (boolFilters[8] != false)
            {
                filteredList = filteredList.Where(game => game.category_vr_support
                                                  == true).ToList();
            }

        }

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