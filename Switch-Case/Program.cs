// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string? week = Console.ReadLine();

switch (week)
{
    case "PAZARTESİ" : 
    Console.WriteLine("Hafta içi");
    break;
    case "SALI" : 
    Console.WriteLine("Hafta içi");
    break;
    case "ÇARŞAMBA" : 
    Console.WriteLine("Hafta içi");
    break;
    case "PERŞEMBE" : 
    Console.WriteLine("Hafta içi");
    break;
    case "CUMA" : 
    Console.WriteLine("Hafta içi");
    break;
    case "CUMARTESİ" : 
    Console.WriteLine("Hafta sonu");
    break;
    case "PAZAR" : 
    Console.WriteLine("Hafta sonu");
    break;
    default:
    Console.WriteLine("GEÇERLİ GÜN GİRİN!");
    break;
}
