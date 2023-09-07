using System;

string name = "Oleksandr";
string Famale = "mężczyzna";
int Age = 25;

if (Famale == "mężczyzna" && Age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Oleksandr" && Age > 30) 
{
    Console.WriteLine("Ewa lat 30 ");
}
else if (Famale == "mężczyzna" && Age < 18)
{
    Console.WriteLine("Niepewnoletni mężczyzna ");
}
