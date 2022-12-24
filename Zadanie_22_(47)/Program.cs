Console.Clear();
Console.Write("Введите количество строк массива m: ");
int m = Int32.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива n: ");
int n = Int32.Parse(Console.ReadLine());
double[,] array = new double [m,n];
for (int i=0; i<array.GetLength(0); i++) 
{
    for (int j=0; j<array.GetLength(1); j++) 
    {
        array[i,j] = new Random().NextDouble() * (10 + 10) - 10;
        array[i,j] = Math.Round(array[i,j],2);
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}