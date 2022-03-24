using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_S00200293_PersonalProject
{
    class Game
    {
        public int GameId { get; set; }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private DateTime releaseDate;

        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }

        private string publisher;

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        private int esrb;

        public int ESRB
        {
            get { return esrb; }
            set { esrb = value; }
        }

        private int pegi;

        public int PEGI
        {
            get { return pegi; }
            set { pegi = value; }
        }

        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
        }


        public Game(string title, string description, DateTime releaseDate, string publisher, int esrb, int pegi, string image)
        {
            this.Title = title;
            this.Description = description;
            this.ReleaseDate = releaseDate;
            this.Publisher = publisher;
            this.ESRB = esrb;
            this.PEGI = pegi;
            this.Image = image;
        }

        public override string ToString()
        {
            string info = $"{Title} - {Publisher} - {ReleaseDate.ToShortDateString()}";
            return info;
        }
    }
}
