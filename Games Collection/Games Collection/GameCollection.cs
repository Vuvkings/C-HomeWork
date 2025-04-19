using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games_Collection
{
    public class GameCollection
    {
        private List<Game> games;

        public int Count => games.Count;

        public GameCollection()
        {
            games = new List<Game>();
        }

        public Game this[int index]
        {
            get
            {
                return games[index];
            }
            set
            {
                games[index] = value;
            }
        }
        public void AddGame(Game game)
        {
            games.Add(game);
        }
        public void RemoveGame(string Title, int releaseYear)
        {
            games.RemoveAll(a => a.Title == Title && a.ReleaseYear == releaseYear);
        }

        public List<Game> FindGamesByDeveloper(string developer)
        {
           
            return this.SearhBy(a => a.Developer== developer);
            throw new GameNotFoundExeption();
        }

        public List<Game> GetGameByGenre(string genre)
        {
            return this.SearhBy(a => a.Genre == genre);
            throw new GameNotFoundExeption();
        }
        public override string ToString()
        {
            return string.Join("\n", games);
        }

    }
}
