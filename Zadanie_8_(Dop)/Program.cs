Console.Clear();
Console.WriteLine("Введите поседовательность чисел. Что-бы закончить ввод введите 0.");
int n = Int32.Parse(Console.ReadLine());
int m = n;
int n2 = 0; 
while (n != 0)
{
    n = Int32.Parse(Console.ReadLine());
if (n > m)
    {
    n2 = m;
    m = n;
    }
else if (n > n2)
    n2 = n; 
}
Console.WriteLine($"{n2}");