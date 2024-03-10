// using System.Collections.Generic;

namespace Exercise03.MusicPlayApp {
    public class Album {
        private string name;
        private string artist;
        private string genre;
        private string year;
        private List<Song> songs;

        public Album(string name, string artist, string genre, string year){
            this.name = name;
            this.artist = artist;
            this.genre = genre;
            this.year = year;
            this.songs = songs ?? new List<Song>();
        }
        
        public string Name {
            get { return name; }
            set { name = value; }

        }

        public string Artist {
            get { return artist; }
            set { artist = value; }
        }

        public string Genre {
            get { return genre; }
            set { genre = value; }
        }

        public string Year {
            get { return Year; }
            set { Year = value; }
        }

        public List<Song> Songs {
            get { return songs; }
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }

    }

}