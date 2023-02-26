
string[] numbers = new string[6] { "1", "12", "123", "hello", "world", "2" };
string[] finalnumbers = new string[6];

void NumbersUnderFour(string[] numbers, string[] finalnumbers)
{
    int count = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i].Length <= 3)
        {
            finalnumbers[i] = numbers[i];
            count++;
        }
    }
}

void PrintArray(string[] finalnumbers)
{
    for (int i = 0; i < finalnumbers.Length; i++)
    {
        Console.Write($"{finalnumbers[i]} ");
    }
    Console.WriteLine();
}

NumbersUnderFour(numbers, finalnumbers);
PrintArray(finalnumbers);