Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

for(int b = 1; b <= a; b++)
{
    double c = Math.Pow(b, 3);
    Console.Write($"{c}, ");
}