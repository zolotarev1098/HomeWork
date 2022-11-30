Console.Clear();
Console.Write("Введите число: ");
int a = Int32.Parse(Console.ReadLine());
int i = 1;
while (i<=a)
{
    if (i%2==0)
    Console.WriteLine(i);
    i++;
}
i++;
