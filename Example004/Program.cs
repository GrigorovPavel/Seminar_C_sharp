// Написать программу, которая на вход принимает трехзначное число,
// а на выходе показывает его последнюю цифру.

Console.WriteLine("Введите трёхзначное число : ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0)   // Проверка на отрицательное значение
{
    number = -1 * number;
}

if (number >= 100 && number <= 999)    // Условие что число трехзначное
{
    int lastNumber = number % 10;     // %-остаток от деления. %10 - всегда последнее число.
    Console.WriteLine($"{number} -> {lastNumber}");
}
else
{
    Console.WriteLine($"{number} -> Не трёхзначное число! ");
}