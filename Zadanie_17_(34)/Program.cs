Console.Clear();
Console.WriteLine("Введите количество элементов массива");
int n = Int32.Parse(Console.ReadLine());
int[] array = new int [n];
int c=0;
for (int i=0; i< array.Length; i++) 
{
    array [i] = new Random().Next(100,1000);
}
Console.WriteLine($"[{string.Join(", ", array)}]");
for (int i=0; i<array.Length; i++) 
{
    if (array[i]%2==0)
    c++;
}
Console.WriteLine(c);