Console.Clear();
Console.WriteLine("Введите число");
int n1 = Int32.Parse(Console.ReadLine());
int n2 = 0;
int n4 = 1;
int n7 = n1; 
if (n1 < 100)
    Console.WriteLine("Третьей цифры нет");
else 
{
while ( n1 % 10 > 0)
    {
    n1 = n1 / 10;
    n2++;
    } 
while (n2 >= 4)
    {
    n4 = n4 * 10; 
    n2--;
    }
int n5 = (n7 / n4) % 10;
Console.WriteLine(n5);
}
