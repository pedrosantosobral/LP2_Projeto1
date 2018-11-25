using System;
using System.Collections.Generic;
namespace LPprojeto1MinhaCopia
{
    public class Filters
    {
        private string[] selections;
        public List<Game> filteredList = new List<Game>();
        public List<Game> searchList;
        bool isRepeatedFlag = false;
        bool i = false;

        public Filters(string[] selections, List<Game> searchList)
        {
            this.selections = selections;
            this.searchList = searchList;
        }

        public void SpecifyFilters()
        {
            if (selections[0].ToUpper() != "NONE")
            {

            }
            if (selections[1].ToUpper() != "NONE")
            {
                //todo
                //Method();
            }
            if (selections[2].ToUpper() != "NONE")
            {
                //todo
                //Method();
            }
            if (selections[3].ToUpper() != "NONE")
            {
                //todo
                //Method();
            }
            if (selections[4].ToUpper() != "NONE")
            {
                //todo
                //Method();
            }
            if (selections[5].ToUpper() != "NONE")
            {
                selections[5] = "TRUE";
            }
            if (selections[6].ToUpper() != "NONE")
            {
                selections[6] = "TRUE";
            }
            if (selections[7].ToUpper() != "NONE")
            {
                selections[7] = "TRUE";
            }
            if (selections[8].ToUpper() != "NONE")
            {
                selections[8] = "TRUE";
            }
            if (selections[9].ToUpper() != "NONE")
            {
                selections[9] = "TRUE";
            }
            if (selections[10].ToUpper() != "NONE")
            {
                selections[10] = "TRUE";
            }
            if (selections[11].ToUpper() != "NONE")
            {
                selections[11] = "TRUE";
            }
            if (selections[12].ToUpper() != "NONE")
            {
                selections[12] = "TRUE";
            }
            if (selections[13].ToUpper() != "NONE")
            {
                selections[13] = "TRUE";
            }
        }

        public bool SearchBool(string[] s, Game g)
        {


            if (Convert.ToBoolean(s[5]) == g.controller_support && isRepeatedFlag == false)
            {
                isRepeatedFlag = true;
                filteredList.Add(g);
            }
            if (Convert.ToBoolean(s[6]) == g.platform_windows && isRepeatedFlag == false)
            {
                isRepeatedFlag = true;
                filteredList.Add(g);
            }
            if (Convert.ToBoolean(s[7]) == g.platform_linux && isRepeatedFlag == false)
            {
                isRepeatedFlag = true;
                filteredList.Add(g);
            }
            if (Convert.ToBoolean(s[8]) == g.platform_mac && isRepeatedFlag == false)
            {
                isRepeatedFlag = true;
                filteredList.Add(g);
            }
            if (Convert.ToBoolean(s[9]) == g.category_singleplayer && isRepeatedFlag == false)
            {
                isRepeatedFlag = true;
                filteredList.Add(g);
            }
            if (Convert.ToBoolean(s[10]) == g.category_multiplayer && isRepeatedFlag == false)
            {
                isRepeatedFlag = true;
                filteredList.Add(g);
            }
            if (Convert.ToBoolean(s[11]) == g.category_coop && isRepeatedFlag == false)
            {
                isRepeatedFlag = true;
                filteredList.Add(g);
            }
            if (Convert.ToBoolean(s[12]) == g.category_include_level_editor && isRepeatedFlag == false)
            {
                isRepeatedFlag = true;
                filteredList.Add(g);
            }
            if (Convert.ToBoolean(s[13]) == g.category_vr_support && isRepeatedFlag == false)
            {
                isRepeatedFlag = true;
                filteredList.Add(g);
            }
            return isRepeatedFlag;
        }








    }
}
