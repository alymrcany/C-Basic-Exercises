// See https://aka.ms/new-console-template for more information
Console.Write("Enter your name: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
string name = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

Console.WriteLine("Hello "+name);