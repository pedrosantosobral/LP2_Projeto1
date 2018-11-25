using System;
using System.Collections.Generic;
namespace LPprojeto1MinhaCopia
{
    public class Filters
    {
        private string[] selections;
        List<Game> searchList;

        public Filters(string[] selections, List<Game> searchList)
        {
            this.selections = selections;
            this.searchList = searchList;
        }

        public void SpecifyFilters()
        {
            if (selections[0].ToUpper() != "NONE")
            {
                SearchForName();
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
                //todo
                //Method();
            }
            if (selections[6].ToUpper() != "NONE")
            {
                //todo
                //Method();
            }
            if (selections[7].ToUpper() != "NONE")
            {
                //todo
                //Method();
            }
            if (selections[8].ToUpper() != "NONE")
            {
                //todo
                //Method();
            }
            if (selections[9].ToUpper() != "NONE")
            {
                //todo
                //Method();
            }
            if (selections[10].ToUpper() != "NONE")
            {
                //todo
                //Method();
            }
            if (selections[11].ToUpper() != "NONE")
            {
                //todo
                //Method();
            }
            if (selections[12].ToUpper() != "NONE")
            {
                //todo
                //Method();
            }
            if (selections[13].ToUpper() != "NONE")
            {
                //todo
                //Method();
            }
        }

        public void SearchForName()
        {
            Console.WriteLine("IN");
        }






    }
}
