void PrintM(double[] value)
{
    for (int i = 0; i < value.Length; i++)
    {
        Console.Write(value[i]+ " ");
    }
    Console.WriteLine();
}

void PrintArr(int[,] value)
{
    for (int i = 0; i < value.GetLength(0); i++)
    {
        for (int j = 0; j < value.GetLength(1); j++)
        {
            Console.Write(value[i, j]+ " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] RandomArr(int start, int end)
{
    int[,] arr = new int[new Random().Next(1, 10), new Random().Next(1, 10)];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(start, end + 1);
        }
    }
    return arr;
}

int[,] arr = RandomArr(0, 99);
PrintArr(arr);

double[] average = new double[arr.GetLength(1)];
for(int i = 0; i < arr.GetLength(1); i++)
{
    for(int j = 0; j < arr.GetLength(0); j++)
    {
        average[i] = average[i] + arr[j, i]; 
    }
    average[i] = Math.Round(average[i] / arr.GetLength(0), 2);
}

PrintM(average);