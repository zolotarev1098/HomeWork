Console.Clear();
Console.Write("Введите последовательность чисел через запятую: ");
int[] array = Console.ReadLine().Split(",").Select(x => int.Parse(x)).ToArray();
int a (int []array) 
{
    int i =0;
    foreach(int element in array) 
    {
        if (element >0 )
        i++;
    }
    return i;
}

Console.Write(a(array));