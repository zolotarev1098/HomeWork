Console.Clear();
Console.WriteLine("Введите количество элементов массива");
int n = Int32.Parse(Console.ReadLine());
double [] array = new double [n];
double max =0;
double min = 101;
for (int i=0; i< array.Length; i++) 
{
    array [i] = new Random().Next(-100,101);
}
Console.WriteLine($"[{string.Join(", ", array)}]");
for (int i=0; i< array.Length; i++) 
{
    if (array[i]>max) 
    max = array[i];
}
for (int i=0; i< array.Length; i++) 
{
    if (array[i]<min) 
    min = array[i];
}
Console.Write(max-min);