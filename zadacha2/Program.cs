int GetRandomNumberInRange(int start, int end)
{
    int result = 0;
    result = new Random().Next(start, end + 1);
    return result;
}

int randomNumber = GetRandomNumberInRange(10, 9999);// менять диапазон можно 
Console.WriteLine(randomNumber);
int count = randomNumber.ToString().Length;
Console.WriteLine(MakeArray(randomNumber, count));

int MakeArray(int a, int b)
{
    int result = 0;
    if (b < 3)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }
        result = (a / c) % 10;
    }
return result;
}
