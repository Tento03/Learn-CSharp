string[] cars = { "Avanza", "Bmw", "Ferrari" };

for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine("Car loop regular:" + cars[i]);
}

Console.WriteLine("====================================");

foreach (var car in cars)
{
    Console.WriteLine("Car looped with foreach:" + car);
}

Console.WriteLine("====================================");

//List

List<string> characters = new List<string>();
characters.Add("Player");
characters.Add("Poppy");
characters.Add("Doey");
characters.Add("Protoype");

foreach(var character in characters)
{
    Console.WriteLine("Char in Poppy Playtime:" + character);
}

characters.Remove("Prototype");