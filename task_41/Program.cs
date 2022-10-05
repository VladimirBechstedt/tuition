int[] arr = new int[5];
int number = 0;

for(int i = 0; i < arr.Length; i++)
{
    Console.Write("Введите число: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if(arr[i] > 0) number++;
    Console.WriteLine();
}

Console.Write(number);
