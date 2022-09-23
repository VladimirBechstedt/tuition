Console.Clear();
int [] a = new int [3];
int [] b = new int [3];

Console.Write("Введите число A: ");
a[0] = Convert.ToInt32(Console.ReadLine());
a[1] = Convert.ToInt32(Console.ReadLine());
a[2] = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
b[0] = Convert.ToInt32(Console.ReadLine());
b[1] = Convert.ToInt32(Console.ReadLine());
b[2] = Convert.ToInt32(Console.ReadLine());

double p = Math.Sqrt(Math.Pow(b[0] - a[0], 2) + Math.Pow(b[1] - a[1], 2) + Math.Pow(b[2] - a[2], 2));

Console.WriteLine(p);