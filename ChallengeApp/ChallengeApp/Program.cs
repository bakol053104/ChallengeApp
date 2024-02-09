var number = 1223445667778888990;
var numberInString = number.ToString();
var letters = numberInString.ToArray();
var CountersDigit = new int[10];

foreach (var digit in letters)
{
    CountersDigit[digit - 48]++; // minus nr znaku cyfry 0 w tablicy ASCII
}

Console.WriteLine($"{number}\n");

for (var i=0; i<CountersDigit.Length; i++)
{
    Console.WriteLine($"{i}=> {CountersDigit[i]}");
}
