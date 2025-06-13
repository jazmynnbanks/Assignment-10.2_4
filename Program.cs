List<int> numbers = new List<int> { 55, 200, 100, 76, 230, 65, 95 };

Console.WriteLine("The numbers greater than 80 are:");

foreach (int number in numbers)
{
    if (number > 80)
    {
        Console.WriteLine(number);
    }
}
    