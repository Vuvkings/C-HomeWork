// See https://aka.ms/new-console-template for more information
using Games_Collection;



var game1 = new Game("GT5", "RockstarGames", "Action/RPG", 2013);
var game2 = new Game("RDR2", "RockstarGames", "Action/RPG", 2018);
var game3 = new Game("MaxPayne", "RockstarGames", "Action/RPG", 2013);
var game4 = new Game("Witcher3", "RockstarGames", "Action/RPG", 2015);
var game5 = new Game("Starckraft2", "Blizzard", "Strategy", 2010);
var game6 = new Game("Cyberpunk2077", "CDProjectRed", "Action/RPG", 2020);
var game7 = new Game("Dota2", "Valve", "MOBA", 2013);

var games = new GameCollection();

games.AddGame(game1);
games.AddGame(game2);
games.AddGame(game3);
games.AddGame(game4);
games.AddGame(game5);
games.AddGame(game6);
games.AddGame(game7);

Console.WriteLine(games);

//games.RemoveGame("Cyberpunk2077", 2013);
Console.WriteLine(games);

var gameByDeveloper = games.FindGamesByDeveloper("RockstarGames");

Console.WriteLine("Games By Rockstar:");
foreach (var game in gameByDeveloper)
{
    Console.WriteLine(game);
}

var gamesByGenre = games.GetGameByGenre("Action/RPG");
Console.WriteLine("Action games:");
foreach (var game in gamesByGenre)
{
    Console.WriteLine(game);
}

//var gamesByYear = games.GroupByYear(2013);
//Console.WriteLine("2013 games:");
//foreach (var game in gamesByYear)
//{ 
//Console.WriteLine(game); 
//}

Dictionary<string, List<Game>> gamesByDeveloper = new Dictionary<string, List<Game>>();
for (int i = 0; i < games.Count; i++)
{
    //if (!gamesByDeveloper.ContainsKey(games[i].Developer))
    //{
    //    gameByDeveloper[games[i].Developer].Add(games[i]);

    //}
    //gameByDeveloper[games[i].Developer].Add(games[i]);
}

HashSet<string> gamesTitles = new HashSet<string>();

for (int i = 0;i < games.Count; i++)
{
    gamesTitles.Add(games[i].Title);
}