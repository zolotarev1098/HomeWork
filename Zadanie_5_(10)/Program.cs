Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int n1 = Int32.Parse(Console.ReadLine());
int n2 = (n1 % 100) / 10;
Console.WriteLine(n2);