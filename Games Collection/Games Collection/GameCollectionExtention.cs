using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games_Collection
{
    public static class GameCollectionExtention
    {
        public static Dictionary<int, List<Game>> GroupByYear(this GameCollection collection)
        {
            var gamesByYear = new Dictionary<int, List<Game>>();

            for (int i = 0; i < collection.Count; i++)
            {
                var currentGame = collection[i];
                if (!gamesByYear.ContainsKey(currentGame.ReleaseYear))
                {
                    gamesByYear[currentGame.ReleaseYear] = [];
                }

                gamesByYear[currentGame.ReleaseYear].Add(currentGame);
            }
            return gamesByYear;

        }
        public static List<Game> GroupByYear(this GameCollection collection, int releaseYear)
        {
            List<Game> gamesByYear = collection.GroupByYear(releaseYear);
            return gamesByYear;
            throw new GameNotFoundExeption();
        }

        public static List<Game> SearhBy(this GameCollection collection, Func<Game, bool> func)
        {
            var gamesByDeveloper = new List<Game>();

            for (int i = 0; i< collection.Count; i++)
            {
                if (func.Invoke(collection[i])) 
                {
                    gamesByDeveloper.Add(collection[i]);
                }
            }

            if (gamesByDeveloper.Count > 0) 
            {
                return gamesByDeveloper; 
            }
            throw new GameNotFoundExeption();
        }
    }
}
