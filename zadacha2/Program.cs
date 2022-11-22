int GetRandomNumberInRange(int start, int end)
{
    int result = 0;
    result = new Random().Next(start, end + 1);
    return result;
}

int randomNumber = GetRandomNumberInRange(10, 999);

int threeDigitNumber(int number)
{
    int intEnd = (randomNumber % 100) / 10;
    return intEnd;
}

int maxDigit = threeDigitNumber (randomNumber);
Console.WriteLine($"Число {randomNumber} третьим числом является {maxDigit}");

