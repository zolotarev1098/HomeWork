Console.WriteLine("Введите три числа");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());
double d = 0;
if (a>b) 
{
    d = a;
}
else 
{
    d = b;
}
if (d>c)
{
    Console.WriteLine($"Max = {d}");
    //Console.WriteLine(d);
}
else
{
    Console.WriteLine($"Max = {c}");
    //Console.WriteLine(c);
}