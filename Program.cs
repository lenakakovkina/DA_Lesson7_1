int minValue = 1;
int maxValue = 10;
int value = GetNumberFromUser(minValue, maxValue);
Console.WriteLine($"User input the next value:{value}");



int GetNumberFromUser(int min, int max)
{
    int UserValue;
    Console.WriteLine($"Input value from {min} to {max}");
    UserValue = int.Parse(Console.ReadLine());

    if (!(UserValue >= min && UserValue <= max))
    {
        do
        {
            Console.WriteLine("Error. Try one more time.");
            Console.WriteLine($"Input value from {min} to {max}");
            UserValue = int.Parse(Console.ReadLine());
        }
        while (!(UserValue >= min && UserValue <= max));
        return UserValue;

    }
    else
    {
        return UserValue;
    }

}

