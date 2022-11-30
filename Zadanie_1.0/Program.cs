Console.Clear();
Console.WriteLine("Введите два числа");
int a = Int32.Parse(Console.ReadLine());
int b = Int32.Parse(Console.ReadLine());
if (a > b) 
{
    Console.WriteLine($"Max = {a}");
    //Console.WriteLine(a);
    Console.WriteLine($"Min = {b}");
    //Console.WriteLine(b);
}
else 
    {
    Console.WriteLine($"Max = {b}");
    //Console.WriteLine(b);
    Console.WriteLine($"Min = {a}");
    //Console.WriteLine(a);  
    }
