Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

while(number > 99999 || number < 10000 )
{
    Console.WriteLine("Введите пятизначное число: ");
    number = int.Parse(Console.ReadLine());
}

int i = number % 10;
int d = number / 10 % 10;
int b = number / 1000 % 10;
int a = number / 10000 % 10;

if(i == a && d == b)
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} НЕ является палиндромом");
}