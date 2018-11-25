using System;
using System.Collections.Generic;
using System.Linq;
namespace LPprojeto1MinhaCopia
{
    public class Filters
    {
        private string[] selections;
        public List<Game> filteredList;
        public List<Game> searchList;


        public Filters(List<Game> searchList)
        {
            this.searchList = searchList;
            filteredList = searchList;
        }

        public void ApplyFilters(string[] selections)
        {
            if(selections[0] != null)
            {
                filteredList = filteredList.Where(game => 
                game.name.ToLower().Contains(selections[0].ToLower())).ToList();
            }

            if(DateTime.TryParse(selections[1], out DateTime dt))
            {
                filteredList = filteredList.Where(game => game.release_date > 
                                                  dt).ToList();
            }

            if (int.TryParse(selections[2], out int req_age))
            {
                filteredList = filteredList.Where(game => game.required_age >
                                                  req_age).ToList();
            }


            if (int.TryParse(selections[3], out int meta))
            {
                filteredList = filteredList.Where(game => game.metacritic >
                                                  meta).ToList();
            }


            if (int.TryParse(selections[4], out int recommendation))
            {
                filteredList = filteredList.Where(game => game.recommendation_count >
                                                  recommendation).ToList();
            }

            if (selections[5] != null)
            {
                filteredList = filteredList.Where(game => game.controller_support 
                                                  == true).ToList();
            }

            if (selections[6] != null)
            {
                filteredList = filteredList.Where(game => game.platform_windows
                                                  == true).ToList();
            }

            if (selections[7] != null)
            {
                filteredList = filteredList.Where(game => game.platform_linux
                                                  == true).ToList();
            }

            if (selections[8] != null)
            {
                filteredList = filteredList.Where(game => game.platform_mac
                                                  == true).ToList();
            }

            if (selections[9] != null)
            {
                filteredList = filteredList.Where(game => game.category_singleplayer
                                                  == true).ToList();
            }

            if (selections[10] != null)
            {
                filteredList = filteredList.Where(game => game.category_multiplayer
                                                  == true).ToList();
            }

            if (selections[11] != null)
            {
                filteredList = filteredList.Where(game => game.category_coop
                                                  == true).ToList();
            }

            if (selections[12] != null)
            {
                filteredList = filteredList.Where(game => game.category_include_level_editor
                                                  == true).ToList();
            }

            if (selections[13] != null)
            {
                filteredList = filteredList.Where(game => game.category_vr_support
                                                  == true).ToList();
            }

        }

    }
}
