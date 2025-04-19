using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games_Collection
{
    public class Game
    {
        public string Title { get; set; }
        public string Developer { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }

        public Game(string title, string developer, string genre, int realeaseYear)
        {
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(developer) || string.IsNullOrWhiteSpace(developer))
            {
                throw new ArgumentException("Пожалуйста, введите данные игры");
            }
            Title = title;
            Developer = developer;
            Genre = genre;
            ReleaseYear = realeaseYear;
        }

        public override string ToString()
        {
            return $"Название: {Title}\nРазработчик: {Developer}\nЖанр: {Genre}\nГод выпуска: {ReleaseYear}\n";
        }

        public static bool operator ==(Game game1, Game game2)
        {
            return game1.Title == game2.Title && game1.ReleaseYear == game2.ReleaseYear;
        }
        public static bool operator !=(Game game1, Game game2)
        {
            return game1.Title != game2.Title && game1.ReleaseYear != game2.ReleaseYear;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }
            

            Game currentGame = (Game)obj;

            return this == currentGame;
        }
    }
}
