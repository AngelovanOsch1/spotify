namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Song song = new Song("test", , 3, Genre.ROCK);
            Person user2 = new Person("Piet");
            List<Person> users = new List<Person>();
            users.Add(user2);
            Person user = new Person("Angelo", users);
            Song song = new Song("test", new List<Artist>(), 5, Genre.ROCK);
            Playlist playlist = new Playlist(user, "test");
            playlist.Add(song);
            Console.WriteLine(user.ShowFriends());

        }
    }
}