
Console.WriteLine("Введите номер строки:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца:");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[5,7];

for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
      array[i,j]=new Random().Next(0,10);
      Console.Write(array[i,j]+" ");
   }
   Console.WriteLine();
}

if (row<array.GetLength(0)&&column<array.GetLength(1))
{
    Console.WriteLine($"Значение элемента {row}, {column} равно {array[row-1,column-1]}");
}
else
{
    Console.WriteLine("Значение не существует!");
}