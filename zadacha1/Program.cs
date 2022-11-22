int GetRandomNumberInRange(int start, int end)
{
    int result = 0;
    result = new Random().Next(start, end + 1);
    return result;
}

int randomNumber = GetRandomNumberInRange(100, 999);
 
int threeDigitNumber = randomNumber;
string stringNumber = Convert.ToString(threeDigitNumber);

Console.WriteLine($"Трехзначное число {randomNumber} вторая цифра этого числа является {stringNumber[1]}");
    