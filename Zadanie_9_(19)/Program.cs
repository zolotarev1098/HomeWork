Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Int32.Parse(Console.ReadLine());
int[] array = new int[1 + (int)Math.Log10(n)];
for (int i = array.Length - 1; i >= 0; i--)
{
    int digit;
    n = Math.DivRem(n, 10, out digit);
    array[i] = digit;
}
if (array[0] == array[4] && array[1] == array[3]) 
    Console.WriteLine("Да");
else 
    Console.WriteLine("Нет");
