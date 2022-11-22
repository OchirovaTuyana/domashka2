Console.Write("Введите цифру обозначающую день недели: ");
int i = Convert.ToInt32(Console.ReadLine());

if (i < 1 || i > 7) 
{
    Console.WriteLine("Введенная цифра не является днем недели");
}
else if (i == 6 || i == 7) 
{
    Console.WriteLine("Выходной день");
}
else Console.WriteLine("Не выходной день");
