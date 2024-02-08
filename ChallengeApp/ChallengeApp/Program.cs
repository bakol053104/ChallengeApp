var name = "Ewa";
var age = 11;
var sex = 'M'; // K- kobieta, M- mężczyzna

if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (sex == 'K')
{
            if (age < 30)
            {
                Console.WriteLine("Kobieta poniżej 30 lat");
            }     
}
    else if (age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }



