Console.Clear();
Console.WriteLine("");
int a = Int32.Parse(Console.ReadLine());
int[] k = new int[a];
int Max = 0;
int t = 0;
int x = 1;
for (int i = 0; i < a; i++ )
    {
        k[i] = new Random().Next(1, 9);         
    }
Console.WriteLine($"[{string.Join(", ", k)}]");  
while (x < a-1)
{
   t = k[x] + k[x-1] + k[x+1];
    if  (t > Max)
    Max = t;
    x++;
} 
Console.WriteLine(Max);   
