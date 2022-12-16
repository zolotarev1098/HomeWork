Console.Clear();
Console.WriteLine("Введите кол-во элементов массива");
int a = Int32.Parse(Console.ReadLine());
int[] array = new int [a];
for (int i = 0; i < array.Length; i++)
 {
   Console.Write($"Введите {i+1} элемент массива: ");
   array[i] = Int32.Parse(Console.ReadLine());
}
Console.WriteLine($"[{string.Join(", ", array)}]");