using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate.Services
{
    internal class validtaion
    {
        List<Int64> IDs = new List<Int64>();
        List<string> Titles = new List<string>();


        private string id;
        private string title;
        private string genres;

        public String validate(string line)
        {


            var ind = line.IndexOf('"');
            if (ind == -1)
            {
                var movie = line.Split(',');

                id = movie[0];
                title = movie[1];
                genres = movie[2].Replace("|", ", ");

            }
            else
            {
                id = line.Substring(0, ind - 1);

                line = line.Substring(ind + 1);
                ind = line.IndexOf('"');

                title = line.Substring(0, ind);
                line = line.Substring(ind + 2);

                genres = line.Replace("|", ", ");


            }
           



            return $"ID: {id}\nTitle: {title}\nGenre:{genres}";
        }

        
        public Boolean IdContains(Int64 id)
        {
            if (IDs.Contains(id))
            {
                return true;
            }

            return false;
        }

        public Boolean TitleContains(string title)
        {
            if (Titles.Contains(title))
            {
                return true;
            }

            return false;

        }
    }
}
