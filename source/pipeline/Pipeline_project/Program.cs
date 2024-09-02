// See https://aka.ms/new-console-template for more information
using Pipeline_project;

Console.WriteLine("Hello, World!");
Calculator calc = new Calculator();
Console.WriteLine("Addition of 5 and 3: " + calc.Add(5, 3));
Console.WriteLine("Subtraction of 5 and 3: " + calc.Subtract(5, 3));