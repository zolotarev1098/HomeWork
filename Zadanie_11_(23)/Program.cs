Console.Clear();
Console.WriteLine("Введите число");
int n = Int32.Parse(Console.ReadLine());
int a = 1;
while (a<=n)
{
   double k = Math.Pow(a,3);
   Console.WriteLine(k);
   a++;
}