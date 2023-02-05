// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, Piotr! Co słychać");
var name = "Ewa";
var sex = "Kobieta";
var age = 33;
if (sex == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex == "Mężczyzna" && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Nieznany warunek");
}


