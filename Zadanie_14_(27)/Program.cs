Console.Clear();
Console.WriteLine("Введите число");
int n = Int32.Parse(Console.ReadLine());
int c = 0;  
int[] array = new int[1 + (int)Math.Log10(n)];
for (int i = array.Length - 1; i >= 0; i--)
{
    int digit;
    n = Math.DivRem(n, 10, out digit);
    array[i] = digit;
}
for(int a=0; a<array.Length; a++)
    {
        c = c + array[a]; 
    }
Console.WriteLine(c);

