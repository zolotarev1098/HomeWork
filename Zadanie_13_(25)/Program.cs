Console.Clear();
Console.WriteLine("Введите два числа");
int a = Int32.Parse(Console.ReadLine());
int b = Int32.Parse(Console.ReadLine());
int c = 1;
for (int i=0; i<b; i++)
{
    c= c*a;
}
Console.WriteLine(c);