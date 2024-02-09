var number = 1223445667778888990;
var numberInString = number.ToString();
var letters = numberInString.ToArray();
var countersDigit = new int[10];

foreach (var digit in letters)
{
    countersDigit[digit - 48]++; // minus nr znaku cyfry 0 w tablicy ASCII
}

Console.WriteLine($"{number}\n");

for (var i=0; i<countersDigit.Length; i++)
{
    Console.WriteLine($"{i}=> {countersDigit[i]}");
}
