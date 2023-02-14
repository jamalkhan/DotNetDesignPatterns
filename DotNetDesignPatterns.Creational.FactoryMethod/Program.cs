﻿Console.WriteLine("Hello, World!");

var creators = new List<CarCreator>();
creators.Add(new SportsCarCreator());
creators.Add(new JalopyCreator());

foreach (var creator in creators)
{
    var car = creator.FactoryMethod();
    Console.WriteLine($"Created a {car.GetType().Name} with a Top Speed of {car.TopSpeed}");
}
Console.ReadLine();