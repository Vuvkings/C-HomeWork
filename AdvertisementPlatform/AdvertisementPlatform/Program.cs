// See https://aka.ms/new-console-template for more information
using AdvertisementPlatform;
using System.Threading;



/*
 "Яндекс.Директ:/ru" 
"Ревдинский рабочий:/ru/svrd/revda,/ru/svrd/pervik" 
"Газета уральских москвичей:/ru/msk,/ru/permobl,/ru/chelobl"
"Крутая реклама:/ru/svrd"
 */
var advertismentPlatform = new AdvertismentPlatform();
advertismentPlatform.AddPlatform("Яндекс.Директ:/ru");
advertismentPlatform.AddPlatform("Ревдинский рабочий:/ru/svrd/revda,/ru/svrd/pervik");
advertismentPlatform.AddPlatform("Газета уральских москвичей:/ru/msk,/ru/permobl,/ru/chelobl");
advertismentPlatform.AddPlatform("Крутая реклама:/ru/svrd");

var location = "/ru/msk";
var platforms = advertismentPlatform.GetPlatform(location);
Console.WriteLine($"рекламные площадки, действующие в локации {location}:");
Console.WriteLine(platforms);
foreach(var platform in platforms)
{
    Console.WriteLine(platform);
}



/*      Test algoritm
 Dictionary<string, string> platforms = new Dictionary<string, string>();
//List<string> platformsList = new List<string>();
var elements = "Ревдинский рабочий:/ru/svrd/revda,/ru/svrd/pervik".Split(':');
for (int i = 0; i < elements.Length; i++)
{
    Console.WriteLine(elements[i]);
}

var locations = elements[1].Split(',');
for (int i = 0; i < locations.Length; i++)
{

    Console.WriteLine(locations[i]);
}

platforms.Add(locations[0], elements[0]);
platforms.Add(locations[1], elements[0]);

List<string> GetPlatforms(string location)
{
    List<string> platformsList = new List<string>();

    foreach (var loco in platforms)
    {
        if (location == loco.Key) platformsList.Add(loco.Value);
        // Console.WriteLine(loco.Value);
    }

    return platformsList;
}

var listPl = GetPlatforms("/ru/svrd/revda");
foreach (var pl in listPl) { Console.WriteLine(pl); }

foreach (var loco in platforms)
{
    Console.WriteLine($"key: {loco.Key}  value: {loco.Value}");
}
 */



