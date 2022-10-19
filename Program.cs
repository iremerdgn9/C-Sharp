// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World !");
Console.WriteLine("What is your name?");
var name = Console.ReadLine();
var currentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");


int a = 42;
int b = 55;
int c = a + b;
Console.WriteLine($"{ Environment.NewLine} c= {c}");
Console.ReadLine();
