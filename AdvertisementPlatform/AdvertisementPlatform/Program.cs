// See https://aka.ms/new-console-template for more information
using AdvertisementPlatform;
Console.WriteLine("Hello, World!");
//var n = Convert.ToInt32(Console.ReadLine());
int n = 10;
var advertismentPlatform = new AdvertismentPlatform();


for (int i = 0; i < n; i++)
{
    var value = Console.ReadLine();
    advertismentPlatform.AddPlatform(value);
}

var location = Console.ReadLine();
var advertismentPlatforms = advertismentPlatform.GetPlatform(location);

for (int i = 0; i < advertismentPlatforms.Count; i++)
{
    Console.WriteLine(advertismentPlatforms[i]);
}