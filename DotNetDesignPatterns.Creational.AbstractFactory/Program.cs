Console.WriteLine("----------------------");
Console.WriteLine("DotNetDesignPatterns.AbstractFactory");
Console.WriteLine("Jamal Khan");
Console.WriteLine("Please view the Readme");
Console.WriteLine("----------------------");

Console.WriteLine("Do you like Nintendo?");
var nintendoFactory = new NintendoVideoGameFactory();
var nintendoClient = new Client(nintendoFactory);
nintendoClient.Run();
Console.WriteLine("");

Console.WriteLine("Do you like Sega?");
var segaFactory = new SegaVideoGameFactory();
var segaClient = new Client(segaFactory);
segaClient.Run();
Console.WriteLine("");

Console.WriteLine("Press Enter to Quit");
Console.ReadLine();
