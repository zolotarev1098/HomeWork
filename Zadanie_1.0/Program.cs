Console.WriteLine("Введите два числа");
int a = Int32.Parse(Console.ReadLine());
int b = Int32.Parse(Console.ReadLine());
if (a > b) 
{
    Console.Write("Max = ");
    Console.WriteLine(a);
    Console.Write("Min = ");
    Console.WriteLine(b);
}
else 
    {
    Console.Write("Max = ");
    Console.WriteLine(b);
    Console.Write("Min = ");
    Console.WriteLine(a);  
    }
