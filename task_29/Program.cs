Console.Clear();
int[] massiv = new int[8];
Random rnd = new Random();

for(int i = 0; i < massiv.Length; i++)
{
    massiv[i] = rnd.Next(0, 100);
    Console.Write(massiv[i] + ", ");
}
