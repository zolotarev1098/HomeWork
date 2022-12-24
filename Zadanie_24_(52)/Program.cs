Console.Clear();
Console.Write("Введите количество строк массива m: ");
int m = Int32.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива n: ");
int n = Int32.Parse(Console.ReadLine());
int [,] array = new int [m,n];
double [] sum = new double [n];
double [] x = new double [n];
void M (int[,] array) 
{
for (int i=0; i<array.GetLength(0); i++) 
{
    for (int j=0; j<array.GetLength(1); j++) 
    {
        array[i,j] = new Random().Next(0, 11);
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}
}
M (array);
 for (int j=0; j<array.GetLength(1); j++)
 {
    for (int i=0; i<array.GetLength(0); i++)
    {
        sum [j]+= array[i,j];
    }
    x [j]= Math.Round(sum[j]/array.GetLength(0),2);
    }
Console.WriteLine($"[{string.Join("    ", x)}]");