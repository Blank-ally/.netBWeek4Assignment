using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate.Services
{
    internal class Movie { 
        validtaion check = new validtaion();

        Int64 id;
        string title;
        string[] genres;

        public Movie(Int64 id, string title, string[] genres) {

            this.id = id;
            this.title = title;
            this.genres = genres;
        }


        public Int64 ID{ get; set; }
        public String Title { get; set; }
        public String[] Genres { get; set; }

        public string Display() {
            return $"ID: {id}\n Title: {title}\n genres: {string.Join('|', genres)} ";
        }



    }
}
