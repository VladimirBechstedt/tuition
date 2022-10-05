Console.Write("Введите координаты:");

double[] b = {Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())};

Console.Write("Введите координаты:");

double[] k = {Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())};

double x = (b[0] - b[1]) / (k[1] - k[0]);
double y = k[0] * x + b[0];

Console.WriteLine();
Console.Write($"({x}; {y})");