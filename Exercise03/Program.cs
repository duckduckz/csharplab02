namespace Exercise03.MusicPlayApp {
    public class MusicPlayAPP{
        static void Main(string[] args)
        {
            Song song1 = new Song("Song 1", 180);
            Song song2 = new Song("Song 2", 210);
            Song song3 = new Song("Song 3", 200);


            Album album = new Album("Album 1", "Artist 1", "Rock", "2021");
            album.AddSong(song1);
            album.AddSong(song2);
            album.AddSong(song3);


            Player player = new Player();

            foreach (Song song in album.Songs)
            {
                player.PlaySong(song);
            }
        }
    }
}