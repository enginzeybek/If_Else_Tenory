// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int time = DateTime.Now.Hour;

if (time <= 18)
{
    Console.WriteLine("İYİ GÜNLER");
}
else if (time <= 6)
{
    Console.WriteLine("İYİ SABAHLAR");
}
else if (time <= 24)
{
    Console.WriteLine("İYİ AKŞAMLAR");
}

String sonuc = time <= 18 ? "İYİ GÜNLER" : "İYİ GECELER";
Console.WriteLine(sonuc);