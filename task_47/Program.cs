double[,] RandomArr(int row, int column)
{
    double[,] arr = new double[row, column];
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
            arr[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(-10, 10), 2);
        }
    }
    return arr;
}

Console.Write("Введите колличество строк в массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());

double[,] arr = RandomArr(row, column);

for(int i = 0; i < arr.GetLength(0); i++)
{
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
}


