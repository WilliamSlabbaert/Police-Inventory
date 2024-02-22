// See https://aka.ms/new-console-template for more information
using Police_System.models;

Console.WriteLine("Hello, World!");
var date = DateTime.Today.AddYears(-10);
var temp = new Employee() { DateOfBirth = date};


Console.WriteLine(temp.DateOfBirth);
Console.WriteLine(temp.CurrentAge);
