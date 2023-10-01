Console.WriteLine("Введите трёхзначное число : ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0)
{
    number = -1 * number;
}

if (number >= 100 && number <= 999)
{
    int lastNumber = number % 10;
    Console.WriteLine($"{number} -> {lastNumber}");
}
else
{
    Console.WriteLine($"{number} -> Не трёхзначное число! ");
}