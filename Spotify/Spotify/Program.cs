namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Song song = new Song("test", , 3, Genre.ROCK);
            Person user = new Person("Angelo");
            Person user2 = new Person("Piet");

            Console.WriteLine(user2.ShowFriends);

        }
    }
}