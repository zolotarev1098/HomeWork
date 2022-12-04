Console.Clear();
Console.WriteLine("Введите цифру обозначающую день недели");
int n = Int32.Parse(Console.ReadLine());
if (n <= 5)
   {
    Console.WriteLine("Рабочий день");
    }
else if (n == 6 || n == 7)
    {
    Console.WriteLine("Выходной");
    }
else if (n > 7)
{
Console.WriteLine("В недели 7 дней :)");
}

 