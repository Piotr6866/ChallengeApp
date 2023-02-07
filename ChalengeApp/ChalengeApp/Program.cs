long number = 1111110234566;  // typ long ze względu na moźliwość użycia dłuższych liczb
//long number2 = long.MaxValue;
string numberAsString = number.ToString();
char[] Digits = numberAsString.ToArray();
int[] counter = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

foreach (char digit in Digits)
{
    counter[Convert.ToInt32(new string(digit, 1))]++;
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i + " => " + counter[i]);
}


