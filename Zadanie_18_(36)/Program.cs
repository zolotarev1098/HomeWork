Console.Clear();
Console.WriteLine("Введите количество элементов массива");
int n = Int32.Parse(Console.ReadLine());
int[] array = new int [n];
int sum = 0;
for (int i=0; i< array.Length; i++) 
{
    array [i] = new Random().Next(-100,101);
}
Console.WriteLine($"[{string.Join(", ", array)}]");
for (int i=0; i< array.Length; i++) 
{
    if (i%2==1) 
    {
        sum += array[i];
    }
}
Console.Write(sum);